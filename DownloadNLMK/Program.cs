﻿
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using NLog;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using QS.Project.DB;
using QS.Project.Services.Interactive;
using QS.Services;
using QSMachineConfig;
using workwear.Domain.Company;
using workwear.Domain.Regulations;
using workwear.Domain.Stock;
using workwear.Measurements;
using workwear.Tools.Oracle;

namespace DownloadNLMK
{
	class MainClass
	{
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
		static IInteractiveService interactive = new ConsoleInteractiveService();
		static NLMKOracle NLMKOracle;

		public static void Main(string[] args)
		{
			int processed;
			double totalRows;
			#region config
			MachineConfig.ConfigFileName = "workwear.ini";
			MachineConfig.ReloadConfigFile();

			NLMKOracle = new NLMKOracle();
			NLMKOracle.Connect(interactive);
			if(NLMKOracle.Connection == null)
				return;

			ConnectConfig.InitConnection(interactive);
			if(OrmConfig.NhConfig == null)
				return;

			#endregion

			using(var uow = UnitOfWorkFactory.CreateWithoutRoot()) {
				logger.Info("start");
				logger.Info("Создаем типы номеклатур");
				var nomeclatureTypes = new NomenclatureTypes(uow);

				logger.Info("Загружаем SKLAD.SAP_ZMAT");
				var dtSAP_ZMAT = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.SAP_ZMAT");
				logger.Info("Обработка SKLAD.SAP_ZMAT");
				var dicSAP_ZMAT = new Dictionary<string, Nomenclature>();
				int categoryFail = 0;
				foreach(var zmat in dtSAP_ZMAT) {
					var nomenclature = new Nomenclature {
						Name = zmat.NMAT ?? zmat.NMAT_,
						Ozm = uint.Parse(zmat.ZMAT), 
						Comment = "Выгружен из ОМТР",
					};
					if(dicSAP_ZMAT.ContainsKey(zmat.ZMAT)) {
						logger.Error($"Дубль строки для ОЗМ {zmat.ZMAT}\n >>{dicSAP_ZMAT[zmat.ZMAT].Name}\n >>{nomenclature.Name}");
						continue;
					}
					dicSAP_ZMAT.Add(zmat.ZMAT, nomenclature);
					if(nomenclature.Name == null) {
						logger.Error($"Для ОЗМ {nomenclature.Ozm} нет названия.");
						categoryFail++;
						continue;
					}

					nomenclature.Type = nomeclatureTypes.ParseNomenclatureName(nomenclature.Name, zmat.EDIZ == 839);

					if(nomenclature.Type == null) {
						categoryFail++;
						continue;
					}
					if(nomenclature.Type.WearCategory.HasValue) {
						nomenclature.Sex = nomeclatureTypes.ParseSex(nomenclature.Name);
						if(SizeHelper.HasClothesSex(nomenclature.Type.WearCategory.Value)) {
							if(nomenclature.Sex == null)
								logger.Warn($"Не найден пол для [{nomenclature.Name}]");
						}
						else {
							if(nomenclature.Sex != null)
								logger.Warn($"Пол найден в [{nomenclature.Name}], но тип {nomenclature.Type.Name} без пола.");
						}
					}

					if(zmat.EDIZ != null && zmat.EDIZ.ToString() != nomenclature.Type.Units.OKEI)
						logger.Error($"Единица измерения не соответсвует {zmat.EDIZ} != {nomenclature.Type.Units.OKEI} для [{nomenclature.Name}]");
				}
				logger.Warn($"Для {categoryFail} номеклатур, не найдено категорий.");

				logger.Info("Загружаем PROTECTION_TOOL");
				var dtPROTECTION_TOOLS = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.PROTECTION_TOOL");
				logger.Info("Загружаем PROTECTION_REPLACEMENT");
				var dtPROTECTION_REPLACEMENT = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.PROTECTION_REPLACEMENT");

				var dicProtectionTools = new Dictionary<string, ProtectionTools>();
				var dicSkipedProtectionTools = new Dictionary<string, dynamic>();
				logger.Info("Обработка СИЗ...");
				foreach(var row in dtPROTECTION_TOOLS) {
					//if(String.IsNullOrWhiteSpace(row.NAME)) {
					//	logger.Warn($"СИЗ с кодом {row.PROTECTION_ID} не имеет названия. Пропускаем...");
					//	dicSkipedProtectionTools[row.PROTECTION_ID] = row;
					//	continue;
					//}
					var item = new ProtectionTools();
					item.Name = row.NAME;
					dicProtectionTools[row.PROTECTION_ID] = item;
				}
				logger.Info($"Загружено {dicProtectionTools.Count} СИЗ-ов.");
				logger.Info("Обработка Аналогов СИЗ...");
				int analogCount = 0;
				int analogNotFound = 0;
				foreach(var row in dtPROTECTION_REPLACEMENT) {
					if(!dicProtectionTools.ContainsKey(row.PROTECTION_ID)) {
						logger.Warn($"Аналог PROTECTION_REPLACEMENT.PROTECTION_ID={row.PROTECTION_ID} не найден в загруженных СИЗ-ах.");
						analogNotFound++;
						continue;
					}
					if(!dicProtectionTools.ContainsKey(row.PROTECTION_ID_ANALOG)) {
						logger.Warn($"Аналог PROTECTION_REPLACEMENT.PROTECTION_ID_ANALOG={row.PROTECTION_ID_ANALOG} не найден в загруженных СИЗ-ах.");
						analogNotFound++;
						continue;
					}
					dicProtectionTools[row.PROTECTION_ID].Analogs.Add(dicProtectionTools[row.PROTECTION_ID_ANALOG]);
					analogCount++;
				}
				logger.Info($"Загружено {analogCount} аналогов СИЗ-ов.");
				logger.Info($"Не найдено {analogNotFound} аналогов СИЗ-ов.");

				logger.Info("Загружаем ANALOQUE_PROTECTION");
				var dtANALOQUE_PROTECTION = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.ANALOQUE_PROTECTION");
				logger.Info("Связываем СИЗ с номеклатурой.");
				var noUsedNomenclature = dicSAP_ZMAT.Values.ToList();
				foreach(var link in dtANALOQUE_PROTECTION) {
					ProtectionTools protection = dicProtectionTools[link.PROTECTION_ID];
					if(!dicSAP_ZMAT.ContainsKey(link.MAT)) {
						logger.Error($"Номеклатура {link.MAT} не найдена");
						continue;
					}
					var nomenclature = dicSAP_ZMAT[link.MAT];
					protection.AddNomeclature(nomenclature);
					noUsedNomenclature.Remove(nomenclature);
				}
				logger.Info($"Добавлено {dtANALOQUE_PROTECTION.Count()} связей.");
				if(noUsedNomenclature.Count > 0) {
					logger.Warn($"Не использовано {noUsedNomenclature.Count} из {dicSAP_ZMAT.Count} номеклатур:\n"
						+ String.Join("\n", noUsedNomenclature.Select(x => x.Name)));
				}
#if !NOSAVE
				logger.Info($"Сохраняем типы...");
				foreach(var item in nomeclatureTypes.ItemsTypes) {
					uow.Save(item);
				}
				uow.Commit();

				logger.Info($"Сохраняем номенклатуру...");
				int i = 0;
				foreach(var item in dicSAP_ZMAT.Values) {
					uow.Save(item);
					i++;
					if(i % 100 == 0) {
						uow.Commit();
						Console.Write($"\r\tСохранили {i} [{(float)i / dicSAP_ZMAT.Count:P}]... ");
					}
				}
				uow.Commit();
				Console.Write("Завершено\n");

				logger.Info($"Сохраняем СИЗ...");
				i = 0;
				foreach(var item in dicProtectionTools.Values) {
					uow.Save(item);
					i++;
					if(i % 100 == 0) {
						uow.Commit();
						Console.Write($"\r\tСохранили {i} [{(float)i / dicProtectionTools.Count:P}]... ");
					}
				}
				uow.Commit();
				Console.Write("Завершено\n");
#endif
				logger.Info("Загружаем NORMA");
				var dtNORMA = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.NORMA");
				logger.Info("Загружаем NORMA_ROW");
				var dtNORMA_ROW = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.NORMA_ROW");

				logger.Info("Загружаем PROFF_STAFF");
				var PROFF_STAFF = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.PROFF_STAFF")
					.ToDictionary<dynamic, string>(x => x.PROFF_ID);

				logger.Info("Обработка норм...");
				var dicNorms = new Dictionary<string, Norm>();
				var dicNormsRows = new Dictionary<string, NormItem>();
				var dicNormsByProff = new Dictionary<string, Norm>();

				foreach(var rowNorma in dtNORMA) {
					if(!PROFF_STAFF.ContainsKey(rowNorma.PROFF_ID)) {
						logger.Warn($"Профессия NORMA.PROFF_ID={rowNorma.PROFF_ID} не найдена в PROFF_STAFF.");
						continue;
					}

					Norm norm = new Norm();
					norm.DateFrom = rowNorma.DATE_BEGIN;
					norm.DateTo = rowNorma.DATE_END;
					norm.Name = PROFF_STAFF[rowNorma.PROFF_ID].NAME_PROFF;
					dicNorms[rowNorma.NORMA_ID] = norm;
					dicNormsByProff[rowNorma.PROFF_ID] = norm;
				}

				logger.Info($"Загружено {dicNorms.Count()} норм.");

				logger.Info("Обработка строк норм...");
				int normRows = 0;
				processed = 0;
				totalRows = dtNORMA_ROW.Count();
				foreach(var rowNorma in dtNORMA_ROW) {
					processed++;
					if(processed % 100 == 0)
						Console.Write($"\r\tОбработано строк {processed} [{processed / totalRows:P}]... ");
					if(!dicProtectionTools.ContainsKey(rowNorma.PROTECTION_ID)) {
						if(dicSkipedProtectionTools.ContainsKey(rowNorma.PROTECTION_ID))
							logger.Warn($"PROTECTION_ID={rowNorma.PROTECTION_ID} в норме NORMA_ID={rowNorma.NORMA_ID} [{dicNorms[rowNorma.NORMA_ID].Name}] была пропущена.");
						else
							logger.Warn($"В норме NORMA_ID={rowNorma.NORMA_ID} {dicNorms[rowNorma.NORMA_ID].Name} есть ссылка на PROTECTION_ID={rowNorma.PROTECTION_ID} которой нет.");
						continue;
					}
					NormItem normItem = new NormItem();
					normItem.Amount = Convert.ToInt32(rowNorma.COUNT);
					normItem.NormPeriod = NormPeriodType.Month;
					normItem.Item = dicProtectionTools[rowNorma.PROTECTION_ID];
					normItem.PeriodCount = Convert.ToInt32(rowNorma.WEARING_PERIOD);
					normItem.Norm = dicNorms[rowNorma.NORMA_ID];
					dicNorms[rowNorma.NORMA_ID].Items.Add(normItem);
					dicNormsRows.Add(rowNorma.NORMA_ROW_ID, normItem);
					normRows++;
				}
				Console.Write("Готово\n");
				logger.Info($"Загружено {normRows} из {dtNORMA_ROW.Count()} строк норм.");

#if !NOSAVE
				logger.Info($"Сохраняем нормы...");
				i = 0;
				foreach(var norm in dicNorms.Values) {
					uow.Save(norm);
					i++;
					if(i % 100 == 0) {
						uow.Commit();
						Console.Write($"\r\tСохранили {i} [{(float)i / dicNorms.Count:P}]... ");
					}
				}
				uow.Commit();
				Console.Write("Завершено\n");
#endif

				logger.Info("Загружаем PERSONAL_CARD");
				var PERSONAL_CARD = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.PERSONAL_CARD c WHERE c.TN IN(SELECT TN FROM KIT.EXP_HUM_SKLAD)"); //FIXME Ускоряем не грузим карточки без сотрудника.
				logger.Info($"Загружено {PERSONAL_CARD.Count()} PERSONAL_CARD");

				logger.Info("Загружаем EXP_HUM_SKLAD");
				var EXP_HUM_SKLAD = NLMKOracle.Connection.Query("SELECT * FROM KIT.EXP_HUM_SKLAD t WHERE t.TN IN (SELECT TN FROM SKLAD.PERSONAL_CARD)")//FIXME Ускоряем не грузим сотрудников без карточек.
					.ToDictionary<dynamic, decimal>(x => x.TN);
				logger.Info($"Загружено {EXP_HUM_SKLAD.Count()} EXP_HUM_SKLAD");

				logger.Info("Загружаем RELAT_PERS_PROFF");
				var RELAT_PERS_PROFF = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.RELAT_PERS_PROFF")
					.ToDictionary<dynamic, string>(x => x.PERSONAL_CARD_ID);
				logger.Info($"Загружено {RELAT_PERS_PROFF.Count()} RELAT_PERS_PROFF");

				logger.Info("Обработка PERSONAL_CARD");
				var dicPERSONAL_CARD = new Dictionary<string, EmployeeCard>();
				int skipCards = 0;
				int withNorm = 0;
				processed = 0;
				totalRows = PERSONAL_CARD.Count();
				foreach (var row in PERSONAL_CARD) {
					processed++;
					if(processed % 100 == 0)
						Console.Write($"\r\tОбработано карточек {processed} [{processed / totalRows:P}]... ");
					if(row.TN == null) {
						//FIXME Пока не загружаем карточки без TN, возможно в будущем надо реализовать.
						skipCards++;
						continue;
					}
					if(!EXP_HUM_SKLAD.ContainsKey(row.TN)) {
						logger.Error($"Сотрудник с TN={row.TN} не найден.");
						continue;
					}
					var info = EXP_HUM_SKLAD[row.TN];
					EmployeeCard card = new EmployeeCard();
					card.PersonnelNumber = row.TN.ToString();
					card.LastName = info.SURNAME;
					card.FirstName = info.NAME;
					card.Patronymic = info.SECNAME;
					card.Sex = info.E_SEX == 2 ? Sex.F : (info.E_SEX == 1 ? Sex.M : Sex.None); ;
					card.DismissDate = info.DUVOL;
					card.HireDate = info.DHIRING;

					card.ProfessionId = (int?)info.E_PROF;
					card.SubdivisionId = (int?)info.PARENT_DEPT_CODE;
					card.DepartmentId = (int?)info.ID_DEPT;
					card.PostId = (int?)info.ID_WP;
					dicPERSONAL_CARD.Add(row.PERSONAL_CARD_ID, card);

					//Связываем с нормой
					if(!RELAT_PERS_PROFF.ContainsKey(row.PERSONAL_CARD_ID)) {
						//logger.Warn($"Для {card.ShortName} TN={row.TN} связь с профессией ОМТР не найдена.");
						continue;
					}
					var proff = RELAT_PERS_PROFF[row.PERSONAL_CARD_ID];
					if(!dicNormsByProff.ContainsKey(proff.PROFF_ID)) {
						logger.Warn($"Для {card.ShortName} TN={row.TN} PROFF_ID={proff.PROFF_ID} норма не найдена.");
						continue;
					}
					var norm = dicNormsByProff[proff.PROFF_ID];
					card.UsedNorms.Add(norm);
					withNorm++;
				}
				Console.Write("Готово\n");
				logger.Info($"Пропущено {skipCards} карточек без ТН.");
				logger.Info($"Обработано {dicPERSONAL_CARD.Count()} личных карточек.");
				logger.Info($"C профессией {withNorm}.");

				logger.Info("Загружаем PERSONAL_CARDS");
				var PERSONAL_CARDS = NLMKOracle.Connection.Query("SELECT * FROM SKLAD.PERSONAL_CARDS r " +
					"WHERE r.PROTECTION_ID IS NOT NULL AND r.PERSONAL_CARD_ID IN (SELECT c.PERSONAL_CARD_ID FROM SKLAD.PERSONAL_CARD c WHERE c.TN IN(SELECT TN FROM KIT.EXP_HUM_SKLAD))"); //FIXME Ускоряем не загружаем строки для сотрудников которых не грузили...
				logger.Info($"Загружено {PERSONAL_CARDS.Count()} PERSONAL_CARDS");

				logger.Info("Обработка строк карточек...");
				totalRows = PERSONAL_CARDS.Count();
				int cardSkippedRows = 0;
				processed = 0;
				foreach(var item in PERSONAL_CARDS) {
					processed++;
					if(processed % 100 == 0)
						Console.Write($"\r\tОбработано строк {processed} [{processed / totalRows:P}]... ");
					if(!dicPERSONAL_CARD.ContainsKey(item.PERSONAL_CARD_ID)) {
						logger.Warn($"Строка для карточки PERSONAL_CARD_ID={item.PERSONAL_CARD_ID} пропущена");
						cardSkippedRows++;
						continue;
					}
					EmployeeCard card = dicPERSONAL_CARD[item.PERSONAL_CARD_ID];
					EmployeeCardItem cardItem;
					if(item.NORMA_ROW_ID != null) {
						NormItem normRow = dicNormsRows[item.NORMA_ROW_ID];
						cardItem = new EmployeeCardItem(card, normRow);
						if(!card.UsedNorms.Contains(normRow.Norm)) {
							card.UsedNorms.Add(normRow.Norm);
							withNorm++;
						}
						if(!DomainHelper.EqualDomainObjects(cardItem.Item, dicProtectionTools[item.PROTECTION_ID])) {
							logger.Warn($"По в норме {cardItem.Item.Name}!={dicProtectionTools[item.PROTECTION_ID].Name}");
						}
					}
					else {
						cardItem = new EmployeeCardItem {
							EmployeeCard = card,
							Item = dicProtectionTools[item.PROTECTION_ID]
						};
					}
					card.WorkwearItems.Add(cardItem);
				}
				Console.Write("Готово\n");
				logger.Info($"Пропущено {skipCards} строк карточек");
				logger.Info($"В итоге {withNorm} карточек с нормами.");
				logger.Info($"Карточек без строк: {dicPERSONAL_CARD.Values.Count(x => !x.WorkwearItems.Any())}");

#if !NOSAVE
				logger.Info($"Сохраняем личные карточки...");
				i = 0;
				foreach(var card in dicPERSONAL_CARD.Values) {
					uow.Save(card);
					i++;
					if(i % 100 == 0) {
						uow.Commit();
						Console.Write($"\r\tСохранили {i} [{(float)i / dicPERSONAL_CARD.Count:P}]... ");
					}
				}
				uow.Commit();
				Console.Write("Завершено\n");
#endif
			}
			logger.Info("Работа завершена. Нажмите любую кнопку для закрытия консоли...");
			Console.ReadLine();
		}
	}
}
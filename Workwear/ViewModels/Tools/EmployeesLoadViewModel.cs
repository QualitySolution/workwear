﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Dialect.Function;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using QS.Dialog;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.ViewModels.Dialog;
using workwear.Domain.Company;
using workwear.Tools.Import;

namespace workwear.ViewModels.Tools
{
	public class EmployeesLoadViewModel : UowDialogViewModelBase
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public EmployeesLoadViewModel(IUnitOfWorkFactory unitOfWorkFactory, INavigationManager navigation, IInteractiveMessage interactiveMessage, DataParser dataParser) : base(unitOfWorkFactory, navigation)
		{
			Title = "Загрузка сотрудников";
			this.interactiveMessage = interactiveMessage ?? throw new ArgumentNullException(nameof(interactiveMessage));
			this.dataParser = dataParser ?? throw new ArgumentNullException(nameof(dataParser));
		}

		private int currentStep;
		public virtual int CurrentStep {
			get => currentStep;
			set => SetField(ref currentStep, value);
		}

		#region private
		XSSFWorkbook wb;
		XSSFSheet sh;
		#endregion

		#region Шаг 1

		public bool SensetiveLoadButton => SelectedSheet != null;

		private string fileName;
		private readonly IInteractiveMessage interactiveMessage;
		private readonly DataParser dataParser;

		public virtual string FileName {
			get => fileName;
			set {
				SetField(ref fileName, value);
				if(!String.IsNullOrWhiteSpace(FileName))
					LoadFile();
			}
		}

		public List<ImportedSheet> Sheets { get; set; } = new List<ImportedSheet>();
		private ImportedSheet selectedSheet;
		[PropertyChangedAlso(nameof(SensetiveLoadButton))]
		public virtual ImportedSheet SelectedSheet {
			get => selectedSheet;
			set => SetField(ref selectedSheet, value);
		}

		public void SecondStep()
		{
			CurrentStep = 1;
			LoadSheet();
			AutoSetupColumns();
			OnPropertyChanged(nameof(DisplayRows));
		}

		#endregion

		#region Шаг 2
		private int headerRow;
		public virtual int HeaderRow {
			get => headerRow;
			set {
				if(SetField(ref headerRow, value)) {
					RefreshColumnsTitle();
					OnPropertyChanged(nameof(DisplayRows));
				}
			}
		}

		public List<ImportedColumn> Columns = new List<ImportedColumn>();

		public ImportedColumn GetColumn(DataType dataType) => Columns.FirstOrDefault(x => x.DataType == dataType);

		private int maxSourceColumns;
		public virtual int MaxSourceColumns {
			get => maxSourceColumns;
			set => SetField(ref maxSourceColumns, value);
		}

		private List<SheetRow> xlsRows;
		public virtual List<SheetRow> XlsRows {
			get => xlsRows;
			set => SetField(ref xlsRows, value);
		}

		public List<SheetRow> DisplayRows => XlsRows.Skip(HeaderRow).ToList();

		public bool SensetiveStep3Button => Columns.Any(x => x.DataType == DataType.Fio) 
			|| (Columns.Any(x => x.DataType == DataType.LastName) && Columns.Any(x => x.DataType == DataType.FirstName));

		#endregion

		#region Шаг 3
		#region Статистика
		private int countSkipRows;
		public virtual int CountSkipRows {
			get => countSkipRows;
			set => SetField(ref countSkipRows, value);
		}

		private int countMultiMatch;
		public virtual int CountMultiMatch {
			get => countMultiMatch;
			set => SetField(ref countMultiMatch, value);
		}
		#endregion

		public void ReadEmployees()
		{
			CurrentStep = 2;
			if(Columns.Any(x => x.DataType == DataType.PersonnelNumber))
				MatchByNumber();
			else
				MatchByName();
		}

		private void MatchByName()
		{
			var list = DisplayRows;
			var lastnameColumn = GetColumn(DataType.LastName);
			var firstColumn = GetColumn(DataType.FirstName);
			var patronymicColumn = GetColumn(DataType.Patronymic);
			var searchValues = list.Select(x => (x.CellValue(lastnameColumn.Index) + "|" + x.CellValue(firstColumn.Index)).ToUpper())
							.Where(x => x != "|")
							.Distinct().ToArray();
			var exists = UoW.Session.QueryOver<EmployeeCard>()
				.Where(Restrictions.In(
				Projections.SqlFunction(
							  "upper", NHibernateUtil.String,
							  Projections.SqlFunction(new StandardSQLFunction("CONCAT_WS"),
							  	NHibernateUtil.String,
							  	Projections.Constant(""),
								Projections.Property<EmployeeCard>(x => x.LastName),
								Projections.Constant("|"),
								Projections.Property<EmployeeCard>(x => x.FirstName)
							   )),
						   searchValues))
				.List();

			foreach(var employee in exists) {
				var found = list.Where(x => String.Equals(x.CellValue(lastnameColumn.Index), employee.LastName, StringComparison.CurrentCultureIgnoreCase) 
					&& String.Equals(x.CellValue(firstColumn.Index), employee.FirstName, StringComparison.CurrentCultureIgnoreCase)
					&& (patronymicColumn == null || String.Equals(x.CellValue(patronymicColumn.Index), employee.Patronymic, StringComparison.CurrentCultureIgnoreCase))
				).ToArray();
				found.First().Employees.Add(employee);
				if(found.First().Employees.Count == 2)
					CountMultiMatch++;
				//Пропускаем дубликаты строк в файле
				foreach(var toSkip in found.Skip(1)) {
					toSkip.Skiped = true;
					CountSkipRows++;
				}
			}
		}

		private void MatchByNumber()
		{
			var list = DisplayRows;
			var numberColumn = GetColumn(DataType.PersonnelNumber);
			var numbers = list.Select(x => x.CellValue(numberColumn.Index))
							.Where(x => !String.IsNullOrWhiteSpace(x))
							.Distinct().ToArray();
			var exists = UoW.Session.QueryOver<EmployeeCard>()
				.Where(x => x.PersonnelNumber.IsIn(numbers))
				.List();

			foreach(var employee in exists) {
				var found = list.Where(x => x.CellValue(numberColumn.Index) == employee.PersonnelNumber).ToArray();
				found.First().Employees.Add(employee);
				if(found.First().Employees.Count == 2)
					CountMultiMatch++;
				//Пропускаем дубликаты строк в файле
				foreach(var toSkip in found.Skip(1)) {
					toSkip.Skiped = true;
					CountSkipRows++;
				}
			}
		}

		#endregion

		#region private Methods

		private void LoadFile()
		{
			try {
				using(var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read)) {
					wb = new XSSFWorkbook(fs);
				}
			}
			catch(IOException ex) when(ex.HResult == -2147024864) {
				interactiveMessage.ShowMessage(ImportanceLevel.Error, "Указанный файл уже открыт в другом приложении. Оно заблокировало доступ к файлу.");
				return;
			}
			
			for(int s = 0; s < wb.NumberOfSheets; s++) {
				var sheet = new ImportedSheet {
					Number = s,
					Title = wb.GetSheetName(s)
				};
				Sheets.Add(sheet);
			}
			OnPropertyChanged(nameof(Sheets));
		}

		private void AutoSetupColumns()
		{
			logger.Info("Ищем заголовочную строку...");

			var bestMath = new DataType[MaxSourceColumns];
			int bestColumns = 0;
			int bestHeaderRow = 0;
			SheetRow bestRow = null;
			int rowNum = 0;
			foreach(var row in XlsRows) {
				var types = new DataType[MaxSourceColumns];
				rowNum++;
				for(int i = 0; i < MaxSourceColumns; i++) {
					var value = row.CellValue(i).ToLower();
					types[i] = dataParser.ColumnNames.ContainsKey(value) ? dataParser.ColumnNames[value] : DataType.Unknown;
				}
				if(bestColumns < types.Count(x => x != DataType.Unknown)) {
					bestMath = types;
					bestRow = row;
					bestColumns = types.Count(x => x != DataType.Unknown);
					bestHeaderRow = rowNum;
				}
				if(bestColumns >= 3)
					break;
			}

			for(int i = 0; i < MaxSourceColumns; i++)
				Columns[i].DataType = bestMath[i];

			logger.Debug($"Найдено соответсвие в {bestColumns} заголовков в строке {bestHeaderRow}");
			HeaderRow = bestHeaderRow;
			logger.Info("Ок");
		}

		private void RefreshColumnsTitle()
		{
			if(HeaderRow == 0) {
				for(int i = 0; i < MaxSourceColumns; i++)
					Columns[i].Title = CellReference.ConvertNumToColString(i);
			}
			else {
				var row = XlsRows[HeaderRow - 1];
				for(int i = 0; i < MaxSourceColumns; i++)
					Columns[i].Title = row.CellValue(i);
			}
			OnPropertyChanged(nameof(Columns));
		}

		private void LoadSheet()
		{
			logger.Info("Читаем лист...");
			sh = (XSSFSheet)wb.GetSheet(SelectedSheet.Title);
			XlsRows = new List<SheetRow>();

			int maxColumns = 0;
			int i = 0;
			while(sh.GetRow(i) != null) {
				xlsRows.Add(new SheetRow(sh.GetRow(i)));
				maxColumns = Math.Max(sh.GetRow(i).Cells.Count, maxColumns);
				i++;
			}
			Columns.Clear();
			for(int icol = 0; icol < maxColumns; icol++) {
				var column = new ImportedColumn(icol);
				column.PropertyChanged += Column_PropertyChanged;;
				Columns.Add(column);
			}
			MaxSourceColumns = maxColumns;

			logger.Info($"Прочитано {maxColumns} колонок и {i} строк");
		}

		void Column_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(ImportedColumn.DataType))
				OnPropertyChanged(nameof(SensetiveStep3Button));
		}

		#endregion
	}
}

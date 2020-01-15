﻿using Autofac;
using QS.BusinessCommon;
using QS.BusinessCommon.Domain;
using QS.Dialog;
using QS.Dialog.GtkUI;
using QS.DomainModel.NotifyChange;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Permissions;
using QS.Project.DB;
using QS.Project.Domain;
using QS.Project.Services;
using QS.Project.Services.GtkUI;
using QS.Report.ViewModels;
using QS.Report.Views;
using QS.Services;
using QS.Tdi;
using QS.Validation;
using QS.Validation.GtkUI;
using QS.Views.Resolve;
using QSOrmProject;
using QSProjectsLib;
using workwear.Dialogs.Organization;
using workwear.Dialogs.Regulations;
using workwear.Domain.Company;
using workwear.Domain.Regulations;
using workwear.Domain.Stock;
using workwear.Domain.Users;
using workwear.JournalViewModels;
using workwear.JournalViewModels.Company;
using workwear.JournalViewModels.Statements;
using workwear.Tools;
using workwear.ViewModels.Company;
using workwear.ViewModels.Statements;
using workwear.Views.Company;

namespace workwear
{
	partial class MainClass
	{
		static void CreateBaseConfig ()
		{
			logger.Info ("Настройка параметров базы...");

			// Настройка ORM
			var db = FluentNHibernate.Cfg.Db.MySQLConfiguration.Standard
				.ConnectionString (QSMain.ConnectionString)
				.ShowSql ()
				.FormatSql ();

			OrmConfig.ConfigureOrm (db, new System.Reflection.Assembly[] {
				System.Reflection.Assembly.GetAssembly (typeof(MainClass)),
				System.Reflection.Assembly.GetAssembly (typeof(MeasurementUnits)),
			});

			//Настраиваем классы сущьностей

			OrmMain.AddObjectDescription(MeasurementUnitsOrmMapping.GetOrmMapping());
			//Спецодежда
			OrmMain.AddObjectDescription<RegulationDoc>().Dialog<RegulationDocDlg>().DefaultTableView().SearchColumn("Документ", i => i.Title).OrderAsc(i => i.Name).End();
			OrmMain.AddObjectDescription<Norm>().Dialog<NormDlg>();
			OrmMain.AddObjectDescription<ItemsType>().Dialog<ItemTypeDlg> ().DefaultTableView ().SearchColumn ("Наименование", i => i.Name).OrderAsc (i => i.Name).End ();
			OrmMain.AddObjectDescription<Post>().DefaultTableView ().SearchColumn ("Название", e => e.Name).End ();
			//Организация
			OrmMain.AddObjectDescription<EmployeeCard>().Dialog<EmployeeCardDlg>().UseSlider(false).DefaultTableView ().SearchColumn ("Имя", e => e.FullName).End ();
			OrmMain.AddObjectDescription<EmployeeVacation>().Dialog<EmployeeVacationDlg>();
			OrmMain.AddObjectDescription<Subdivision>().Dialog<ObjectDlg> ().DefaultTableView ().SearchColumn("Код", e => e.Code).SearchColumn ("Название", e => e.Name).SearchColumn ("Адрес", e => e.Address).End ();
			OrmMain.AddObjectDescription<Leader>().DefaultTableView ().SearchColumn ("Имя", e => e.Name).End ();
			OrmMain.AddObjectDescription<VacationType>().Dialog<VacationTypeDlg>().DefaultTableView().SearchColumn("Название", e => e.Name).Column("Исключать из носки", e => e.ExcludeFromWearing ? "Да" : "Нет").SearchColumn("Комментарий", e => e.Comments).End();
			//Общее
			OrmMain.AddObjectDescription<UserBase>().DefaultTableView ().Column ("Имя", e => e.Name).End ();
			OrmMain.AddObjectDescription<UserSettings>();
			//Склад
			OrmMain.AddObjectDescription<Nomenclature>().Dialog<NomenclatureDlg> ().DefaultTableView ()
					.SearchColumn ("Наименование", i => i.Name)
					.SearchColumn ("Размер", i => i.Size)
					.SearchColumn ("Рост", i => i.WearGrowth).OrderAsc (i => i.Name).End ();
			OrmMain.AddObjectDescription<Income>().Dialog<IncomeDocDlg>();
			OrmMain.AddObjectDescription<Expense>().Dialog<ExpenseDocDlg>();
			OrmMain.AddObjectDescription<Writeoff>().Dialog<WriteOffDocDlg>();

			NotifyConfiguration.Enable();
			BuisnessLogicGlobalEventHandler.Init(new GtkQuestionDialogsInteractive());
			GtkAppServicesConfig.CreateDefaultGtkServices();
			JournalsColumnsConfigs.RegisterColumns();
		}

		public static Autofac.IContainer AppDIContainer;

		static void AutofacClassConfig()
		{
			var builder = new ContainerBuilder();

			#region База
			builder.RegisterType<DefaultUnitOfWorkFactory>().As<IUnitOfWorkFactory>();
			builder.RegisterType<DefaultSessionProvider>().As<ISessionProvider>();
			#endregion

			#region Сервисы
			#region GtkUI
			builder.RegisterType<GtkMessageDialogsInteractive>().As<IInteractiveMessage>();
			builder.RegisterType<GtkQuestionDialogsInteractive>().As<IInteractiveQuestion>();
			builder.RegisterType<GtkInteractiveService>().As<IInteractiveService>();
			builder.RegisterType<GtkValidationViewFactory>().As<IValidationViewFactory>();
			builder.RegisterType<GtkDeleteEntityService>().As<IDeleteEntityService>();
			#endregion GtkUI
			//FIXME Нужно в конечнои итоге попытаться избавится от CommonServce вообще.
			builder.RegisterType<CommonServices>().As<ICommonServices>();
			builder.RegisterType<UserService>().As<IUserService>();
			builder.RegisterType<ValidationService>().As<IValidationService>();
			//FIXME Реализовать везде возможность отсутствия сервиса прав, чтобы не приходилось создавать то что не используется
			builder.RegisterType<DefaultAllowedPermissionService>().As<IPermissionService>();
			#endregion

			#region Навигация
			builder.RegisterType<ClassNamesHashGenerator>().As<IPageHashGenerator>();
			builder.Register((ctx) => new AutofacViewModelsTdiPageFactory(AppDIContainer)).As<IViewModelsPageFactory>();
			builder.Register((ctx) => new AutofacTdiPageFactory(AppDIContainer)).As<ITdiPageFactory>();
			builder.RegisterType<TdiNavigationManager>().AsSelf().As<INavigationManager>().As<ITdiCompatibilityNavigation>().SingleInstance();
			builder.RegisterType<BasedOnNameTDIResolver>().As<ITDIWidgetResolver>();
			builder.Register(cc => new ClassNamesBaseGtkViewResolver(typeof(RdlViewerView), typeof(OrganizationView))).As<IGtkViewResolver>();
			#endregion

			#region Старые диалоги
			builder.RegisterType<ExpenseDocDlg>().AsSelf();
			#endregion

			#region Старые общие диалоги
			builder.RegisterType<OrmReference>().AsSelf();
			builder.RegisterType<ReferenceRepresentation>().AsSelf();
			#endregion

			#region Rdl
			builder.RegisterType<RdlViewerViewModel>().AsSelf();
			#endregion

			#region ViewModels
			//Company
			builder.RegisterType<OrganizationViewModel>().AsSelf();
			//Statements
			builder.RegisterType<IssuanceSheetViewModel>().AsSelf();
			#endregion

			//builder.RegisterType<OneEntrySearchView>().Named<Widget>("GtkJournalSearchView");
			#region JournalViewModels
			//Company
			builder.RegisterType<OrganizationJournalViewModel>().AsSelf();
			//Statements
			builder.RegisterType<IssuanceSheetJournalViewModel>().AsSelf();
			#endregion

			AppDIContainer = builder.Build();
		}
	}
}
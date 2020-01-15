using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Gtk;
using NLog;
using QS.BusinessCommon.Domain;
using QS.Dialog.Gtk;
using QS.Navigation;
using QS.Report;
using QS.Tdi;
using QS.Tdi.Gtk;
using QS.Updater;
using QSOrmProject;
using QSProjectsLib;
using QSSupportLib;
using QSTelemetry;
using workwear;
using workwear.Dialogs.DataBase;
using workwear.Domain.Company;
using workwear.Domain.Regulations;
using workwear.Domain.Stock;
using workwear.Domain.Users;
using workwear.JournalViewers;
using workwear.JournalViewModels.Company;
using workwear.JournalViewModels.Statements;
using workwear.Representations.Organization;
using workwear.Tools;
using workwear.ViewModel;
using workwear.ViewModels.Company;

public partial class MainWindow : Gtk.Window
{
	private static Logger logger = LogManager.GetCurrentClassLogger();

	private ILifetimeScope AutofacScope = MainClass.AppDIContainer.BeginLifetimeScope();
	public TdiNavigationManager NavigationManager;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		//Передаем лебл
		QSMain.StatusBarLabel = labelStatus;
		this.Title = MainSupport.GetTitle();
		QSMain.MakeNewStatusTargetForNlog();

		QSMain.CheckServer(this); // Проверяем настройки сервера
		MainSupport.LoadBaseParameters();

		MainUpdater.RunCheckVersion(true, true, true);

		if(QSMain.User.Login == "root") {
			string Message = "Вы зашли в программу под администратором базы данных. У вас есть только возможность создавать других пользователей.";
			MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
												  MessageType.Info,
												  ButtonsType.Ok,
												  Message);
			md.Run();
			md.Destroy();
			Users WinUser = new Users();
			WinUser.Show();
			WinUser.Run();
			WinUser.Destroy();
			return;
		}

		if(QSMain.connectionDB.DataSource == "demo.qsolution.ru") {
			string Message = "Вы подключились к демонстрационному серверу. Сервер предназначен для оценки " +
				"возможностей программы, не используйте его для работы, так как ваши данные будут доступны " +
				"любому пользователю через интернет.\n\nДля полноценного использования программы вам необходимо " +
				"установить собственный сервер. Для его установки обратитесь к документации.\n\nЕсли у вас возникнут " +
				"вопросы вы можете обратится в нашу тех. поддержку.";
			MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
												  MessageType.Info,
												  ButtonsType.Ok,
												  Message);
			md.Run();
			md.Destroy();
			dialogAuthenticationAction.Sensitive = false;
		}

		this.KeyReleaseEvent += ClipboardWorkaround.HandleKeyReleaseEvent;
		TDIMain.MainNotebook = tdiMain;
		this.KeyReleaseEvent += TDIMain.TDIHandleKeyReleaseEvent;

		UsersAction.Sensitive = QSMain.User.Admin;
		labelUser.LabelProp = QSMain.User.Name;

		//Настраиваем новости
		MainNewsFeed.NewsFeeds = new List<NewsFeed>(){
			new NewsFeed("workwearnews", "Новости программы", "http://news.qsolution.ru/workwear.atom")
			};
		MainNewsFeed.LoadReadFeed();
		var newsmenu = new NewsMenuItem();
		menubar1.Add(newsmenu);
		newsmenu.LoadFeed();

		ReadUserSettings();

		NavigationManager = AutofacScope.Resolve<TdiNavigationManager>(new TypedParameter(typeof(TdiNotebook), tdiMain));
		tdiMain.WidgetResolver = AutofacScope.Resolve<ITDIWidgetResolver>(new TypedParameter(typeof(Assembly[]), new[] { Assembly.GetAssembly(typeof(OrganizationViewModel)) }));
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		a.RetVal = true;
		Application.Quit();
	}

	public override void Destroy()
	{
		AutofacScope.Dispose();
		base.Destroy();
	}

	protected void OnDialogAuthenticationActionActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ChangeUserPassword");
		QSMain.User.ChangeUserPassword(this);
	}

	protected void OnUsersActionActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("OpenUsers");
		Users winUsers = new Users();
		winUsers.Show();
		winUsers.Run();
		winUsers.Destroy();
	}

	protected void OnQuitActionActivated(object sender, EventArgs e)
	{
		Application.Quit();
	}

	protected void OnAction7Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("MeasurementUnits");
		tdiMain.OpenTab(OrmReference.GenerateHashName<MeasurementUnits>(),
						() => new OrmReference(typeof(MeasurementUnits))
					   );
	}

	protected void OnAction8Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("Post");
		tdiMain.OpenTab(OrmReference.GenerateHashName<Post>(),
						() => new OrmReference(typeof(Post))
					   );
	}

	protected void OnAction9Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("Leader");
		tdiMain.OpenTab(OrmReference.GenerateHashName<Leader>(),
				() => new OrmReference(typeof(Leader))
			   );
	}

	protected void OnAction5Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ItemsType");
		tdiMain.OpenTab(OrmReference.GenerateHashName<ItemsType>(),
				() => new OrmReference(typeof(ItemsType))
			   );
	}

	protected void OnAction6Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("Nomenclature");
		tdiMain.OpenTab(OrmReference.GenerateHashName<Nomenclature>(),
				() => new OrmReference(typeof(Nomenclature))
			   );
	}

	protected void OnAboutActionActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("RunAboutDialog");
		QSMain.RunAboutDialog();
	}

	protected void OnAction11Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ReportStockAllWear");
		var reportInfo = new ReportInfo {
			Title = "Складская ведомость",
			Identifier = "StockAllWear",
		};

		tdiMain.OpenTab(QSReport.ReportViewDlg.GenerateHashName(reportInfo),
						  () => new QSReport.ReportViewDlg(reportInfo)
						 );

	}

	protected void OnAction10Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ReportWearStatement");
		WearStatement widget = new WearStatement();
		tdiMain.OpenTab(
			QSReport.ReportViewDlg.GenerateHashName(widget),
			() => new QSReport.ReportViewDlg(widget)
		);
	}

	protected void OnAction12Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ReportListBySize");
		var reportInfo = new ReportInfo {
			Title = "Список по размерам",
			Identifier = "ListBySize",
		};

		tdiMain.OpenTab(QSReport.ReportViewDlg.GenerateHashName(reportInfo),
						  () => new QSReport.ReportViewDlg(reportInfo)
						 );

	}

	protected void OnHelpActionActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("OpenDocumentation");
		System.Diagnostics.Process.Start("workwear_ru.pdf");
	}

	protected void OnActionHistoryActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("RunChangeLogDlg");
		QSMain.RunChangeLogDlg(this);
	}

	protected void OnActionUpdateActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("CheckUpdate");
		MainUpdater.CheckAppVersionShowAnyway();
	}

	protected void OnActionSNActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("EditSerialNumber");
		EditSerialNumber.RunDialog();
	}

	protected void OnActionNormsActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("OpenNorms");
		tdiMain.OpenTab(
			ReferenceRepresentation.GenerateHashName<NormVM>(),
			() => new ReferenceRepresentation(new NormVM())
		);
	}

	protected void OnAction13Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ReportMonthIssueSheet");
		var widget = new OnIssueStatement();
		tdiMain.OpenTab(
			QSReport.ReportViewDlg.GenerateHashName(widget),
			() => new QSReport.ReportViewDlg(widget)
		);
	}

	protected void OnAction17Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ReportNotIssuedSheet");
		var widget = new NotIssuedSheetReportDlg();
		tdiMain.OpenTab(
			QSReport.ReportViewDlg.GenerateHashName(widget),
			() => new QSReport.ReportViewDlg(widget)
		);
	}

	protected void OnActionYearRequestSheetActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("AverageAnnualNeedReport");
		var reportInfo = new ReportInfo {
			Title = "Среднегодовая потребность",
			Identifier = "AverageAnnualNeed",
		};

		tdiMain.OpenTab(QSReport.ReportViewDlg.GenerateHashName(reportInfo),
						  () => new QSReport.ReportViewDlg(reportInfo)
						 );

	}

	protected void OnAction21Activated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ReportMonthQuarterRequestSheet");
		var widget = new RequestSheetDlg();
		tdiMain.OpenTab(
			QSReport.ReportViewDlg.GenerateHashName(widget),
			() => new QSReport.ReportViewDlg(widget)
		);
	}

	protected void OnActionStockBalanceActivated(object sender, EventArgs e)
	{
		tdiMain.OpenTab(TdiTabBase.GenerateHashName<StockBalanceView>(),
						() => new StockBalanceView()
					   );
	}

	protected void OnActionStockDocsActivated(object sender, EventArgs e)
	{
		tdiMain.OpenTab(TdiTabBase.GenerateHashName<StockDocumentsView>(),
				() => new StockDocumentsView()
			   );
	}

	protected void OnActionEmployeesActivated(object sender, EventArgs e)
	{
		tdiMain.OpenTab(
			ReferenceRepresentation.GenerateHashName<EmployeesVM>(),
			() => new ReferenceRepresentation(new EmployeesVM())
		);
	}

	protected void OnActionObjectsActivated(object sender, EventArgs e)
	{
		tdiMain.OpenTab(
			OrmReference.GenerateHashName<Subdivision>(),
			() => new OrmReference(typeof(Subdivision))
		);
	}

	#region Панель инструментов

	void ReadUserSettings()
	{
		switch(CurrentUserSettings.Settings.ToolbarStyle) {
			case ToolbarStyle.Both:
				ActionToolBarTextAndIcon.Activate();
				break;
			case ToolbarStyle.Icons:
				ActionToolBarIconOnly.Activate();
				break;
			case ToolbarStyle.Text:
				ActionToolBarTextOnly.Activate();
				break;
		}
		switch(CurrentUserSettings.Settings.ToolBarIconsSize) {
			case IconsSize.ExtraSmall:
				ActionIconsExtraSmall.Activate();
				break;
			case IconsSize.Small:
				ActionIconsSmall.Activate();
				break;
			case IconsSize.Middle:
				ActionIconsMiddle.Activate();
				break;
			case IconsSize.Large:
				ActionIconsLarge.Activate();
				break;
		}
		ActionShowBar.Active = CurrentUserSettings.Settings.ShowToolbar;
	}

	private void ToolBarMode(ToolbarStyle style)
	{
		if(CurrentUserSettings.Settings.ToolbarStyle != style) {
			CurrentUserSettings.Settings.ToolbarStyle = style;
			CurrentUserSettings.SaveSettings();
		}
		toolbarMain.ToolbarStyle = style;
		ActionIconsExtraSmall.Sensitive = ActionIconsSmall.Sensitive = ActionIconsMiddle.Sensitive = ActionIconsLarge.Sensitive =
			style != ToolbarStyle.Text;
	}

	private void ToolBarShow(bool show)
	{
		if(toolbarMain.Visible == show)
			return;

		if(CurrentUserSettings.Settings.ShowToolbar != show) {
			CurrentUserSettings.Settings.ShowToolbar = show;
			CurrentUserSettings.SaveSettings();
		}
		toolbarMain.Visible = show;
		ActionIconsExtraSmall.Sensitive = ActionIconsSmall.Sensitive = ActionIconsMiddle.Sensitive = ActionIconsLarge.Sensitive =
			ActionToolBarIconOnly.Sensitive = ActionToolBarTextOnly.Sensitive = ActionToolBarTextAndIcon.Sensitive =
			show;
	}

	private void ToolBarMode(IconsSize size)
	{
		if(CurrentUserSettings.Settings.ToolBarIconsSize != size) {
			CurrentUserSettings.Settings.ToolBarIconsSize = size;
			CurrentUserSettings.SaveSettings();
		}
		switch(size) {
			case IconsSize.ExtraSmall:
				toolbarMain.IconSize = IconSize.SmallToolbar;
				break;
			case IconsSize.Small:
				toolbarMain.IconSize = IconSize.LargeToolbar;
				break;
			case IconsSize.Middle:
				toolbarMain.IconSize = IconSize.Dnd;
				break;
			case IconsSize.Large:
				toolbarMain.IconSize = IconSize.Dialog;
				break;
		}
	}

	protected void OnActionToolBarTextOnlyToggled(object sender, EventArgs e)
	{
		if(ActionToolBarTextOnly.Active)
			ToolBarMode(ToolbarStyle.Text);
	}

	protected void OnActionToolBarIconOnlyToggled(object sender, EventArgs e)
	{
		if(ActionToolBarIconOnly.Active)
			ToolBarMode(ToolbarStyle.Icons);
	}

	protected void OnActionToolBarTextAndIconToggled(object sender, EventArgs e)
	{
		if(ActionToolBarTextAndIcon.Active)
			ToolBarMode(ToolbarStyle.Both);
	}

	protected void OnActionIconsExtraSmallToggled(object sender, EventArgs e)
	{
		if(ActionIconsExtraSmall.Active)
			ToolBarMode(IconsSize.ExtraSmall);
	}

	protected void OnActionIconsSmallToggled(object sender, EventArgs e)
	{
		if(ActionIconsSmall.Active)
			ToolBarMode(IconsSize.Small);
	}

	protected void OnActionIconsMiddleToggled(object sender, EventArgs e)
	{
		if(ActionIconsMiddle.Active)
			ToolBarMode(IconsSize.Middle);
	}

	protected void OnActionIconsLargeToggled(object sender, EventArgs e)
	{
		if(ActionIconsLarge.Active)
			ToolBarMode(IconsSize.Large);
	}

	protected void OnActionShowBarToggled(object sender, EventArgs e)
	{
		ToolBarShow(ActionShowBar.Active);
	}

	protected void OnActionBarObjectsActivated(object sender, EventArgs e)
	{
		ActionObjects.Activate();
	}

	protected void OnActionBarEmployeesActivated(object sender, EventArgs e)
	{
		ActionEmployees.Activate();
	}

	protected void OnActionBarStoreActivated(object sender, EventArgs e)
	{
		ActionStockDocs.Activate();
	}

	protected void OnActionBarStoreBalanceActivated(object sender, EventArgs e)
	{
		ActionStockBalance.Activate();
	}

	#endregion

	protected void OnActionSiteActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("OpenSite");
		System.Diagnostics.Process.Start("http://workwear.qsolution.ru/?utm_source=qs&utm_medium=app_workwear&utm_campaign=help_open_site");
	}

	protected void OnActionOpenReformalActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("OpenReformal.ru");
		System.Diagnostics.Process.Start("http://qs-workwear.reformal.ru/");
	}

	protected void OnActionVKActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("vk.com");
		System.Diagnostics.Process.Start("https://vk.com/qualitysolution");
	}

	protected void OnActionOdnoklasnikiActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("ok.ru");
		System.Diagnostics.Process.Start("https://ok.ru/qualitysolution");
	}

	protected void OnActionGoogleActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("plus.google.com");
		System.Diagnostics.Process.Start("https://plus.google.com/+QsolutionRu/posts");
	}

	protected void OnActionTwitterActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("twitter.com");
		System.Diagnostics.Process.Start("https://twitter.com/QSolutionRu");
	}

	protected void OnActionYouTubeActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("youtube.com");
		System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC4U9Rzp-yfRgWd2R0f4iIGg");
	}

	protected void OnActionRegulationDocActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("RegulationDoc");
		tdiMain.OpenTab(OrmReference.GenerateHashName<RegulationDoc>(),
						() => new OrmReference(typeof(RegulationDoc))
			   );
	}

	protected void OnActionBaseSettingsActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("DataBaseSettings");
		tdiMain.OpenTab(TdiTabBase.GenerateHashName<DataBaseSettingsDlg>(),
						() => new DataBaseSettingsDlg()
			   );
	}

	protected void OnActionVacationTypesActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount("VacationType");
		tdiMain.OpenTab<OrmReference, Type>(typeof(VacationType));
	}

	protected void OnActionOrganizationsActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount(nameof(OrganizationJournalViewModel));
		NavigationManager.OpenViewModel<OrganizationJournalViewModel>(null);
	}

	protected void OnActionIssuanceSheetsActivated(object sender, EventArgs e)
	{
		MainTelemetry.AddCount(nameof(IssuanceSheetJournalViewModel));
		NavigationManager.OpenViewModel<IssuanceSheetJournalViewModel>(null);
	}
}
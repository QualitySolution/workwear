
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action ActionBase;

	private global::Gtk.Action Action1;

	private global::Gtk.Action ActionReports;

	private global::Gtk.Action ActionHelp;

	private global::Gtk.Action dialogAuthenticationAction;

	private global::Gtk.Action UsersAction;

	private global::Gtk.Action quitAction;

	private global::Gtk.Action Action5;

	private global::Gtk.Action Action6;

	private global::Gtk.Action Action7;

	private global::Gtk.Action Action8;

	private global::Gtk.Action Action9;

	private global::Gtk.Action aboutAction;

	private global::Gtk.Action Action10;

	private global::Gtk.Action Action11;

	private global::Gtk.Action Action12;

	private global::Gtk.Action helpAction;

	private global::Gtk.Action ActionHistory;

	private global::Gtk.Action ActionUpdate;

	private global::Gtk.Action ActionSN;

	private global::Gtk.Action ActionNorms;

	private global::Gtk.Action Action13;

	private global::Gtk.Action ActionRequestSheet;

	private global::Gtk.Action ActionAverageAnnualNeed;

	private global::Gtk.Action Action22;

	private global::Gtk.Action Action33;

	private global::Gtk.Action Action21;

	private global::Gtk.Action ActionStockDocs;

	private global::Gtk.Action ActionStockBalance;

	private global::Gtk.Action ActionObjects;

	private global::Gtk.Action ActionEmployees;

	private global::Gtk.Action ActionBarObjects;

	private global::Gtk.Action ActionBarEmployees;

	private global::Gtk.Action ActionBarStore;

	private global::Gtk.Action ActionBarStoreBalance;

	private global::Gtk.Action Action24;

	private global::Gtk.ToggleAction ActionShowBar;

	private global::Gtk.RadioAction ActionToolBarTextOnly;

	private global::Gtk.RadioAction ActionToolBarIconOnly;

	private global::Gtk.RadioAction ActionToolBarTextAndIcon;

	private global::Gtk.RadioAction ActionIconsExtraSmall;

	private global::Gtk.RadioAction ActionIconsSmall;

	private global::Gtk.RadioAction ActionIconsMiddle;

	private global::Gtk.RadioAction ActionIconsLarge;

	private global::Gtk.Action ActionSite;

	private global::Gtk.Action ActionOpenReformal;

	private global::Gtk.Action Action38;

	private global::Gtk.Action ActionVK;

	private global::Gtk.Action ActionOdnoklasniki;

	private global::Gtk.Action ActionTwitter;

	private global::Gtk.Action ActionYouTube;

	private global::Gtk.Action ActionRegulationDoc;

	private global::Gtk.Action ActionBaseSettings;

	private global::Gtk.Action ActionVacationTypes;

	private global::Gtk.Action ActionOrganizations;

	private global::Gtk.Action ActionIssuanceSheets;

	private global::Gtk.Action ActionWarehouse;

	private global::Gtk.Action ActionDepartment;

	private global::Gtk.Action ActionProfession;

	private global::Gtk.Action ActionProtectionTools;

	private global::Gtk.Action ActionAmountEmployeeGetWear;

	private global::Gtk.Action ActionAmountIssuedWear;

	private global::Gtk.Action ActionUserSettings;

	private global::Gtk.Action ActionCardIssuee;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.HButtonBox hbuttonbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Toolbar toolbarMain;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Table table1;

	private global::Gtk.CheckButton cnbOpenInWindow;

	private global::QS.Views.Control.EntitySearch entitySearchEmployee;

	private global::Gtk.Label label3;

	private global::QS.Tdi.Gtk.TdiNotebook tdiMain;

	private global::QS.Widgets.ProgressWidget progresswidget1;

	private global::Gtk.Statusbar MainStatusBar;

	private global::Gtk.Label labelUser;

	private global::Gtk.Label labelStatus;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.ActionBase = new global::Gtk.Action("ActionBase", global::Mono.Unix.Catalog.GetString("База"), null, null);
		this.ActionBase.ShortLabel = global::Mono.Unix.Catalog.GetString("База");
		w1.Add(this.ActionBase, null);
		this.Action1 = new global::Gtk.Action("Action1", global::Mono.Unix.Catalog.GetString("Справочники"), null, null);
		this.Action1.ShortLabel = global::Mono.Unix.Catalog.GetString("Справочники");
		w1.Add(this.Action1, null);
		this.ActionReports = new global::Gtk.Action("ActionReports", global::Mono.Unix.Catalog.GetString("Отчеты"), null, null);
		this.ActionReports.ShortLabel = global::Mono.Unix.Catalog.GetString("Отчеты");
		w1.Add(this.ActionReports, null);
		this.ActionHelp = new global::Gtk.Action("ActionHelp", global::Mono.Unix.Catalog.GetString("Справка"), null, null);
		this.ActionHelp.ShortLabel = global::Mono.Unix.Catalog.GetString("Справка");
		w1.Add(this.ActionHelp, null);
		this.dialogAuthenticationAction = new global::Gtk.Action("dialogAuthenticationAction", global::Mono.Unix.Catalog.GetString("Изменить пароль"), null, "gtk-dialog-authentication");
		this.dialogAuthenticationAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Изменить пароль");
		w1.Add(this.dialogAuthenticationAction, null);
		this.UsersAction = new global::Gtk.Action("UsersAction", global::Mono.Unix.Catalog.GetString("Пользователи"), null, null);
		this.UsersAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Пользователи");
		w1.Add(this.UsersAction, null);
		this.quitAction = new global::Gtk.Action("quitAction", global::Mono.Unix.Catalog.GetString("Выход"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Выход");
		w1.Add(this.quitAction, null);
		this.Action5 = new global::Gtk.Action("Action5", global::Mono.Unix.Catalog.GetString("Типы номенклатуры"), null, null);
		this.Action5.ShortLabel = global::Mono.Unix.Catalog.GetString("Типы номенклатуры");
		w1.Add(this.Action5, null);
		this.Action6 = new global::Gtk.Action("Action6", global::Mono.Unix.Catalog.GetString("Номенклатура"), null, null);
		this.Action6.ShortLabel = global::Mono.Unix.Catalog.GetString("Номенклатура");
		w1.Add(this.Action6, null);
		this.Action7 = new global::Gtk.Action("Action7", global::Mono.Unix.Catalog.GetString("Единицы измерения"), null, null);
		this.Action7.ShortLabel = global::Mono.Unix.Catalog.GetString("Единицы измерения");
		w1.Add(this.Action7, null);
		this.Action8 = new global::Gtk.Action("Action8", global::Mono.Unix.Catalog.GetString("Должности"), null, null);
		this.Action8.ShortLabel = global::Mono.Unix.Catalog.GetString("Должности");
		w1.Add(this.Action8, null);
		this.Action9 = new global::Gtk.Action("Action9", global::Mono.Unix.Catalog.GetString("Руководители"), null, null);
		this.Action9.ShortLabel = global::Mono.Unix.Catalog.GetString("Руководители");
		w1.Add(this.Action9, null);
		this.aboutAction = new global::Gtk.Action("aboutAction", global::Mono.Unix.Catalog.GetString("_О программе"), null, "gtk-about");
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("_О программе");
		w1.Add(this.aboutAction, null);
		this.Action10 = new global::Gtk.Action("Action10", global::Mono.Unix.Catalog.GetString("Сводная ведомость"), null, null);
		this.Action10.ShortLabel = global::Mono.Unix.Catalog.GetString("Сводная ведомость");
		w1.Add(this.Action10, null);
		this.Action11 = new global::Gtk.Action("Action11", global::Mono.Unix.Catalog.GetString("Складская ведомость"), null, null);
		this.Action11.ShortLabel = global::Mono.Unix.Catalog.GetString("Складская ведомость");
		w1.Add(this.Action11, null);
		this.Action12 = new global::Gtk.Action("Action12", global::Mono.Unix.Catalog.GetString("Список по размерам"), null, null);
		this.Action12.ShortLabel = global::Mono.Unix.Catalog.GetString("Список по размерам");
		w1.Add(this.Action12, null);
		this.helpAction = new global::Gtk.Action("helpAction", global::Mono.Unix.Catalog.GetString("Документация"), null, "gtk-help");
		this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Документация");
		w1.Add(this.helpAction, null);
		this.ActionHistory = new global::Gtk.Action("ActionHistory", global::Mono.Unix.Catalog.GetString("История версий"), null, "gtk-file");
		this.ActionHistory.ShortLabel = global::Mono.Unix.Catalog.GetString("История версий");
		w1.Add(this.ActionHistory, null);
		this.ActionUpdate = new global::Gtk.Action("ActionUpdate", global::Mono.Unix.Catalog.GetString("Проверить обновление..."), null, "gtk-go-down");
		this.ActionUpdate.ShortLabel = global::Mono.Unix.Catalog.GetString("Проверить обновление...");
		w1.Add(this.ActionUpdate, null);
		this.ActionSN = new global::Gtk.Action("ActionSN", global::Mono.Unix.Catalog.GetString("Ввести серийный номер..."), null, null);
		this.ActionSN.ShortLabel = global::Mono.Unix.Catalog.GetString("Ввести серийный номер...");
		w1.Add(this.ActionSN, null);
		this.ActionNorms = new global::Gtk.Action("ActionNorms", global::Mono.Unix.Catalog.GetString("Нормы выдачи"), null, null);
		this.ActionNorms.ShortLabel = global::Mono.Unix.Catalog.GetString("Нормы выдачи");
		w1.Add(this.ActionNorms, null);
		this.Action13 = new global::Gtk.Action("Action13", global::Mono.Unix.Catalog.GetString("Ведомость на выдачу"), null, null);
		this.Action13.ShortLabel = global::Mono.Unix.Catalog.GetString("Ведомость на выдачу");
		w1.Add(this.Action13, null);
		this.ActionRequestSheet = new global::Gtk.Action("ActionRequestSheet", global::Mono.Unix.Catalog.GetString("Заявка на спецодежду"), null, null);
		this.ActionRequestSheet.ShortLabel = global::Mono.Unix.Catalog.GetString("Месячная заявка");
		w1.Add(this.ActionRequestSheet, null);
		this.ActionAverageAnnualNeed = new global::Gtk.Action("ActionAverageAnnualNeed", global::Mono.Unix.Catalog.GetString("Среднегодовая потребность"), null, null);
		this.ActionAverageAnnualNeed.ShortLabel = global::Mono.Unix.Catalog.GetString("Сводная заявка");
		w1.Add(this.ActionAverageAnnualNeed, null);
		this.Action22 = new global::Gtk.Action("Action22", global::Mono.Unix.Catalog.GetString("Справка по невыданному"), null, null);
		this.Action22.ShortLabel = global::Mono.Unix.Catalog.GetString("Справка по невыданному");
		w1.Add(this.Action22, null);
		this.Action33 = new global::Gtk.Action("Action33", global::Mono.Unix.Catalog.GetString("Вид"), null, null);
		this.Action33.ShortLabel = global::Mono.Unix.Catalog.GetString("Вид");
		w1.Add(this.Action33, null);
		this.Action21 = new global::Gtk.Action("Action21", global::Mono.Unix.Catalog.GetString("Склад"), null, null);
		this.Action21.ShortLabel = global::Mono.Unix.Catalog.GetString("Склад");
		w1.Add(this.Action21, null);
		this.ActionStockDocs = new global::Gtk.Action("ActionStockDocs", global::Mono.Unix.Catalog.GetString("Складские документы"), null, "store");
		this.ActionStockDocs.ShortLabel = global::Mono.Unix.Catalog.GetString("Складские документы");
		w1.Add(this.ActionStockDocs, null);
		this.ActionStockBalance = new global::Gtk.Action("ActionStockBalance", global::Mono.Unix.Catalog.GetString("Складские остатки"), null, "store-balance");
		this.ActionStockBalance.ShortLabel = global::Mono.Unix.Catalog.GetString("Складские остатки");
		w1.Add(this.ActionStockBalance, null);
		this.ActionObjects = new global::Gtk.Action("ActionObjects", global::Mono.Unix.Catalog.GetString("Подразделения"), null, "objects");
		this.ActionObjects.ShortLabel = global::Mono.Unix.Catalog.GetString("Подразделения");
		w1.Add(this.ActionObjects, null);
		this.ActionEmployees = new global::Gtk.Action("ActionEmployees", global::Mono.Unix.Catalog.GetString("Карточки сотрудников"), null, "employees");
		this.ActionEmployees.ShortLabel = global::Mono.Unix.Catalog.GetString("Карточки сотрудников");
		w1.Add(this.ActionEmployees, null);
		this.ActionBarObjects = new global::Gtk.Action("ActionBarObjects", global::Mono.Unix.Catalog.GetString("Подразделения"), null, "objects");
		this.ActionBarObjects.ShortLabel = global::Mono.Unix.Catalog.GetString("Подразделения");
		w1.Add(this.ActionBarObjects, null);
		this.ActionBarEmployees = new global::Gtk.Action("ActionBarEmployees", global::Mono.Unix.Catalog.GetString("Сотрудники"), null, "employees");
		this.ActionBarEmployees.ShortLabel = global::Mono.Unix.Catalog.GetString("Сотрудники");
		w1.Add(this.ActionBarEmployees, null);
		this.ActionBarStore = new global::Gtk.Action("ActionBarStore", global::Mono.Unix.Catalog.GetString("Склад"), null, "store");
		this.ActionBarStore.ShortLabel = global::Mono.Unix.Catalog.GetString("Склад");
		w1.Add(this.ActionBarStore, null);
		this.ActionBarStoreBalance = new global::Gtk.Action("ActionBarStoreBalance", global::Mono.Unix.Catalog.GetString("Остатки"), null, "store-balance");
		this.ActionBarStoreBalance.ShortLabel = global::Mono.Unix.Catalog.GetString("Остатки");
		w1.Add(this.ActionBarStoreBalance, null);
		this.Action24 = new global::Gtk.Action("Action24", global::Mono.Unix.Catalog.GetString("Панель инструментов"), null, null);
		this.Action24.ShortLabel = global::Mono.Unix.Catalog.GetString("Панель инструментов");
		w1.Add(this.Action24, null);
		this.ActionShowBar = new global::Gtk.ToggleAction("ActionShowBar", global::Mono.Unix.Catalog.GetString("Отображать"), null, null);
		this.ActionShowBar.Active = true;
		this.ActionShowBar.ShortLabel = global::Mono.Unix.Catalog.GetString("Отображать");
		w1.Add(this.ActionShowBar, null);
		this.ActionToolBarTextOnly = new global::Gtk.RadioAction("ActionToolBarTextOnly", global::Mono.Unix.Catalog.GetString("Только текст"), null, null, 0);
		this.ActionToolBarTextOnly.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.ActionToolBarTextOnly.ShortLabel = global::Mono.Unix.Catalog.GetString("Только текст");
		w1.Add(this.ActionToolBarTextOnly, null);
		this.ActionToolBarIconOnly = new global::Gtk.RadioAction("ActionToolBarIconOnly", global::Mono.Unix.Catalog.GetString("Только иконки"), null, null, 0);
		this.ActionToolBarIconOnly.Group = this.ActionToolBarTextOnly.Group;
		this.ActionToolBarIconOnly.ShortLabel = global::Mono.Unix.Catalog.GetString("Только иконки");
		w1.Add(this.ActionToolBarIconOnly, null);
		this.ActionToolBarTextAndIcon = new global::Gtk.RadioAction("ActionToolBarTextAndIcon", global::Mono.Unix.Catalog.GetString("Иконки и текст"), null, null, 0);
		this.ActionToolBarTextAndIcon.Group = this.ActionToolBarIconOnly.Group;
		this.ActionToolBarTextAndIcon.ShortLabel = global::Mono.Unix.Catalog.GetString("Иконки и текст");
		w1.Add(this.ActionToolBarTextAndIcon, null);
		this.ActionIconsExtraSmall = new global::Gtk.RadioAction("ActionIconsExtraSmall", global::Mono.Unix.Catalog.GetString("Очень маленькие иконки"), null, null, 0);
		this.ActionIconsExtraSmall.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.ActionIconsExtraSmall.ShortLabel = global::Mono.Unix.Catalog.GetString("Очень маленькие иконки");
		w1.Add(this.ActionIconsExtraSmall, null);
		this.ActionIconsSmall = new global::Gtk.RadioAction("ActionIconsSmall", global::Mono.Unix.Catalog.GetString("Маленькие иконки"), null, null, 0);
		this.ActionIconsSmall.Group = this.ActionIconsExtraSmall.Group;
		this.ActionIconsSmall.ShortLabel = global::Mono.Unix.Catalog.GetString("Маленькие иконки");
		w1.Add(this.ActionIconsSmall, null);
		this.ActionIconsMiddle = new global::Gtk.RadioAction("ActionIconsMiddle", global::Mono.Unix.Catalog.GetString("Средние иконки"), null, null, 0);
		this.ActionIconsMiddle.Group = this.ActionIconsExtraSmall.Group;
		this.ActionIconsMiddle.ShortLabel = global::Mono.Unix.Catalog.GetString("Средние иконки");
		w1.Add(this.ActionIconsMiddle, null);
		this.ActionIconsLarge = new global::Gtk.RadioAction("ActionIconsLarge", global::Mono.Unix.Catalog.GetString("Большие иконки"), null, null, 0);
		this.ActionIconsLarge.Group = this.ActionIconsExtraSmall.Group;
		this.ActionIconsLarge.ShortLabel = global::Mono.Unix.Catalog.GetString("Большие иконки");
		w1.Add(this.ActionIconsLarge, null);
		this.ActionSite = new global::Gtk.Action("ActionSite", global::Mono.Unix.Catalog.GetString("Сайт программы"), null, "www");
		this.ActionSite.ShortLabel = global::Mono.Unix.Catalog.GetString("Сайт программы");
		w1.Add(this.ActionSite, null);
		this.ActionOpenReformal = new global::Gtk.Action("ActionOpenReformal", global::Mono.Unix.Catalog.GetString("Предложить идею"), null, "www");
		this.ActionOpenReformal.ShortLabel = global::Mono.Unix.Catalog.GetString("Предложить идею");
		w1.Add(this.ActionOpenReformal, null);
		this.Action38 = new global::Gtk.Action("Action38", global::Mono.Unix.Catalog.GetString("Мы в социальных сетях"), null, null);
		this.Action38.ShortLabel = global::Mono.Unix.Catalog.GetString("Мы в социальных сетях");
		w1.Add(this.Action38, null);
		this.ActionVK = new global::Gtk.Action("ActionVK", global::Mono.Unix.Catalog.GetString("Вконтакте"), null, "vk");
		this.ActionVK.ShortLabel = global::Mono.Unix.Catalog.GetString("Вконтакте");
		w1.Add(this.ActionVK, null);
		this.ActionOdnoklasniki = new global::Gtk.Action("ActionOdnoklasniki", global::Mono.Unix.Catalog.GetString("Однокласники"), null, "odnoklasniki");
		this.ActionOdnoklasniki.ShortLabel = global::Mono.Unix.Catalog.GetString("Однокласники");
		w1.Add(this.ActionOdnoklasniki, null);
		this.ActionTwitter = new global::Gtk.Action("ActionTwitter", global::Mono.Unix.Catalog.GetString("Twitter"), null, "twitter");
		this.ActionTwitter.ShortLabel = global::Mono.Unix.Catalog.GetString("Twitter");
		w1.Add(this.ActionTwitter, null);
		this.ActionYouTube = new global::Gtk.Action("ActionYouTube", global::Mono.Unix.Catalog.GetString("YouTube"), null, "youtube");
		this.ActionYouTube.ShortLabel = global::Mono.Unix.Catalog.GetString("YouTube");
		w1.Add(this.ActionYouTube, null);
		this.ActionRegulationDoc = new global::Gtk.Action("ActionRegulationDoc", global::Mono.Unix.Catalog.GetString("Нормативные документы"), null, null);
		this.ActionRegulationDoc.ShortLabel = global::Mono.Unix.Catalog.GetString("Нормативные документы");
		w1.Add(this.ActionRegulationDoc, null);
		this.ActionBaseSettings = new global::Gtk.Action("ActionBaseSettings", global::Mono.Unix.Catalog.GetString("Настройки учета"), null, "gtk-properties");
		this.ActionBaseSettings.ShortLabel = global::Mono.Unix.Catalog.GetString("Настройки учета");
		w1.Add(this.ActionBaseSettings, null);
		this.ActionVacationTypes = new global::Gtk.Action("ActionVacationTypes", global::Mono.Unix.Catalog.GetString("Виды отпусков"), null, null);
		this.ActionVacationTypes.ShortLabel = global::Mono.Unix.Catalog.GetString("Виды отпусков");
		w1.Add(this.ActionVacationTypes, null);
		this.ActionOrganizations = new global::Gtk.Action("ActionOrganizations", global::Mono.Unix.Catalog.GetString("Организации"), null, null);
		this.ActionOrganizations.ShortLabel = global::Mono.Unix.Catalog.GetString("Организации");
		w1.Add(this.ActionOrganizations, null);
		this.ActionIssuanceSheets = new global::Gtk.Action("ActionIssuanceSheets", global::Mono.Unix.Catalog.GetString("Ведомости на выдачу"), null, null);
		this.ActionIssuanceSheets.ShortLabel = global::Mono.Unix.Catalog.GetString("Ведомости на выдачу");
		w1.Add(this.ActionIssuanceSheets, null);
		this.ActionWarehouse = new global::Gtk.Action("ActionWarehouse", global::Mono.Unix.Catalog.GetString("Склады"), null, null);
		this.ActionWarehouse.ShortLabel = global::Mono.Unix.Catalog.GetString("Склады");
		w1.Add(this.ActionWarehouse, null);
		this.ActionDepartment = new global::Gtk.Action("ActionDepartment", global::Mono.Unix.Catalog.GetString("Отделы"), null, null);
		this.ActionDepartment.ShortLabel = global::Mono.Unix.Catalog.GetString("Отделы");
		w1.Add(this.ActionDepartment, null);
		this.ActionProfession = new global::Gtk.Action("ActionProfession", global::Mono.Unix.Catalog.GetString("Профессии"), null, null);
		this.ActionProfession.ShortLabel = global::Mono.Unix.Catalog.GetString("Профессии");
		w1.Add(this.ActionProfession, null);
		this.ActionProtectionTools = new global::Gtk.Action("ActionProtectionTools", global::Mono.Unix.Catalog.GetString("Номенклатура ТОН"), null, null);
		this.ActionProtectionTools.ShortLabel = global::Mono.Unix.Catalog.GetString("Номенклатура ТОН");
		w1.Add(this.ActionProtectionTools, null);
		this.ActionAmountEmployeeGetWear = new global::Gtk.Action("ActionAmountEmployeeGetWear", global::Mono.Unix.Catalog.GetString("Количество сотрудников получивших СИЗ"), null, null);
		this.ActionAmountEmployeeGetWear.ShortLabel = global::Mono.Unix.Catalog.GetString("Количество сотрудников получивших СИЗ");
		w1.Add(this.ActionAmountEmployeeGetWear, null);
		this.ActionAmountIssuedWear = new global::Gtk.Action("ActionAmountIssuedWear", global::Mono.Unix.Catalog.GetString("Справка по выданному"), null, null);
		this.ActionAmountIssuedWear.ShortLabel = global::Mono.Unix.Catalog.GetString("Справка по выданному");
		w1.Add(this.ActionAmountIssuedWear, null);
		this.ActionUserSettings = new global::Gtk.Action("ActionUserSettings", global::Mono.Unix.Catalog.GetString("Настройки пользователя"), null, "gtk-preferences");
		this.ActionUserSettings.ShortLabel = global::Mono.Unix.Catalog.GetString("Настройки пользователя");
		w1.Add(this.ActionUserSettings, null);
		this.ActionCardIssuee = new global::Gtk.Action("ActionCardIssuee", global::Mono.Unix.Catalog.GetString("Выдача"), null, "smart-card");
		this.ActionCardIssuee.ShortLabel = global::Mono.Unix.Catalog.GetString("Выдача");
		w1.Add(this.ActionCardIssuee, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("QS: Спецодежда и имущество");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("workwear.icon.logo.ico");
		this.WindowPosition = ((global::Gtk.WindowPosition)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar1\'><menu name=\'ActionBase\' action=\'ActionBase\'><menuite" +
				"m name=\'dialogAuthenticationAction\' action=\'dialogAuthenticationAction\'/><menuit" +
				"em name=\'UsersAction\' action=\'UsersAction\'/><menuitem name=\'ActionBaseSettings\' " +
				"action=\'ActionBaseSettings\'/><menuitem name=\'ActionUserSettings\' action=\'ActionU" +
				"serSettings\'/><separator/><menuitem name=\'quitAction\' action=\'quitAction\'/></men" +
				"u><menu name=\'Action33\' action=\'Action33\'><menu name=\'Action24\' action=\'Action24" +
				"\'><menuitem name=\'ActionShowBar\' action=\'ActionShowBar\'/><separator/><menuitem n" +
				"ame=\'ActionToolBarTextOnly\' action=\'ActionToolBarTextOnly\'/><menuitem name=\'Acti" +
				"onToolBarIconOnly\' action=\'ActionToolBarIconOnly\'/><menuitem name=\'ActionToolBar" +
				"TextAndIcon\' action=\'ActionToolBarTextAndIcon\'/><separator/><menuitem name=\'Acti" +
				"onIconsExtraSmall\' action=\'ActionIconsExtraSmall\'/><menuitem name=\'ActionIconsSm" +
				"all\' action=\'ActionIconsSmall\'/><menuitem name=\'ActionIconsMiddle\' action=\'Actio" +
				"nIconsMiddle\'/><menuitem name=\'ActionIconsLarge\' action=\'ActionIconsLarge\'/></me" +
				"nu></menu><menu name=\'Action21\' action=\'Action21\'><menuitem name=\'ActionStockDoc" +
				"s\' action=\'ActionStockDocs\'/><menuitem name=\'ActionStockBalance\' action=\'ActionS" +
				"tockBalance\'/><separator/><menuitem name=\'ActionIssuanceSheets\' action=\'ActionIs" +
				"suanceSheets\'/></menu><menu name=\'Action1\' action=\'Action1\'><menuitem name=\'Acti" +
				"onOrganizations\' action=\'ActionOrganizations\'/><menuitem name=\'ActionObjects\' ac" +
				"tion=\'ActionObjects\'/><menuitem name=\'ActionDepartment\' action=\'ActionDepartment" +
				"\'/><menuitem name=\'ActionEmployees\' action=\'ActionEmployees\'/><separator/><menui" +
				"tem name=\'ActionRegulationDoc\' action=\'ActionRegulationDoc\'/><menuitem name=\'Act" +
				"ionProtectionTools\' action=\'ActionProtectionTools\'/><menuitem name=\'ActionNorms\'" +
				" action=\'ActionNorms\'/><separator/><menuitem name=\'Action5\' action=\'Action5\'/><m" +
				"enuitem name=\'Action6\' action=\'Action6\'/><menuitem name=\'ActionWarehouse\' action" +
				"=\'ActionWarehouse\'/><separator/><menuitem name=\'Action7\' action=\'Action7\'/><sepa" +
				"rator/><menuitem name=\'ActionProfession\' action=\'ActionProfession\'/><menuitem na" +
				"me=\'Action8\' action=\'Action8\'/><menuitem name=\'ActionVacationTypes\' action=\'Acti" +
				"onVacationTypes\'/><menuitem name=\'Action9\' action=\'Action9\'/></menu><menu name=\'" +
				"ActionReports\' action=\'ActionReports\'><menuitem name=\'Action10\' action=\'Action10" +
				"\'/><menuitem name=\'Action11\' action=\'Action11\'/><separator/><menuitem name=\'Acti" +
				"on12\' action=\'Action12\'/><separator/><menuitem name=\'Action13\' action=\'Action13\'" +
				"/><menuitem name=\'ActionRequestSheet\' action=\'ActionRequestSheet\'/><menuitem nam" +
				"e=\'ActionAverageAnnualNeed\' action=\'ActionAverageAnnualNeed\'/><separator/><menui" +
				"tem name=\'Action22\' action=\'Action22\'/><menuitem name=\'ActionAmountEmployeeGetWe" +
				"ar\' action=\'ActionAmountEmployeeGetWear\'/><menuitem name=\'ActionAmountIssuedWear" +
				"\' action=\'ActionAmountIssuedWear\'/></menu><menu name=\'ActionHelp\' action=\'Action" +
				"Help\'><menuitem name=\'helpAction\' action=\'helpAction\'/><menuitem name=\'ActionHis" +
				"tory\' action=\'ActionHistory\'/><menuitem name=\'ActionUpdate\' action=\'ActionUpdate" +
				"\'/><separator/><menuitem name=\'ActionSite\' action=\'ActionSite\'/><menuitem name=\'" +
				"ActionOpenReformal\' action=\'ActionOpenReformal\'/><menu name=\'Action38\' action=\'A" +
				"ction38\'><menuitem name=\'ActionVK\' action=\'ActionVK\'/><menuitem name=\'ActionOdno" +
				"klasniki\' action=\'ActionOdnoklasniki\'/><menuitem name=\'ActionTwitter\' action=\'Ac" +
				"tionTwitter\'/><menuitem name=\'ActionYouTube\' action=\'ActionYouTube\'/></menu><sep" +
				"arator/><menuitem name=\'ActionSN\' action=\'ActionSN\'/><separator/><menuitem name=" +
				"\'aboutAction\' action=\'aboutAction\'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.vbox1.Add(this.hbuttonbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbarMain'><toolitem name='ActionBarObjects' action='ActionBarObjects'/><toolitem name='ActionBarEmployees' action='ActionBarEmployees'/><toolitem name='ActionCardIssuee' action='ActionCardIssuee'/><toolitem name='ActionBarStore' action='ActionBarStore'/><toolitem name='ActionBarStoreBalance' action='ActionBarStoreBalance'/><toolitem/></toolbar></ui>");
		this.toolbarMain = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbarMain")));
		this.toolbarMain.Name = "toolbarMain";
		this.toolbarMain.ShowArrow = false;
		this.toolbarMain.ToolbarStyle = ((global::Gtk.ToolbarStyle)(2));
		this.toolbarMain.IconSize = ((global::Gtk.IconSize)(5));
		this.hbox1.Add(this.toolbarMain);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.toolbarMain]));
		w4.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.cnbOpenInWindow = new global::Gtk.CheckButton();
		this.cnbOpenInWindow.CanFocus = true;
		this.cnbOpenInWindow.Name = "cnbOpenInWindow";
		this.cnbOpenInWindow.Label = global::Mono.Unix.Catalog.GetString("открыть в текущей вкладке");
		this.cnbOpenInWindow.Active = true;
		this.cnbOpenInWindow.DrawIndicator = true;
		this.cnbOpenInWindow.UseUnderline = true;
		this.table1.Add(this.cnbOpenInWindow);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.cnbOpenInWindow]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entitySearchEmployee = new global::QS.Views.Control.EntitySearch();
		this.entitySearchEmployee.Events = ((global::Gdk.EventMask)(256));
		this.entitySearchEmployee.Name = "entitySearchEmployee";
		this.table1.Add(this.entitySearchEmployee);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.entitySearchEmployee]));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Поиск сотрудника:");
		this.table1.Add(this.label3);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox3.Add(this.table1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.table1]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.tdiMain = new global::QS.Tdi.Gtk.TdiNotebook();
		this.tdiMain.Name = "tdiMain";
		this.tdiMain.CurrentPage = 0;
		this.tdiMain.ShowTabs = false;
		this.tdiMain.Scrollable = true;
		this.vbox1.Add(this.tdiMain);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.tdiMain]));
		w11.Position = 3;
		// Container child vbox1.Gtk.Box+BoxChild
		this.progresswidget1 = new global::QS.Widgets.ProgressWidget();
		this.progresswidget1.Name = "progresswidget1";
		this.vbox1.Add(this.progresswidget1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.progresswidget1]));
		w12.Position = 4;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.MainStatusBar = new global::Gtk.Statusbar();
		this.MainStatusBar.Name = "MainStatusBar";
		this.MainStatusBar.Spacing = 6;
		// Container child MainStatusBar.Gtk.Box+BoxChild
		this.labelUser = new global::Gtk.Label();
		this.labelUser.Name = "labelUser";
		this.labelUser.LabelProp = global::Mono.Unix.Catalog.GetString("Пользователь");
		this.MainStatusBar.Add(this.labelUser);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.MainStatusBar[this.labelUser]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child MainStatusBar.Gtk.Box+BoxChild
		this.labelStatus = new global::Gtk.Label();
		this.labelStatus.Name = "labelStatus";
		this.labelStatus.Xalign = 1F;
		this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Ok");
		this.MainStatusBar.Add(this.labelStatus);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.MainStatusBar[this.labelStatus]));
		w14.Position = 2;
		this.vbox1.Add(this.MainStatusBar);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.MainStatusBar]));
		w15.Position = 5;
		w15.Expand = false;
		w15.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 943;
		this.DefaultHeight = 458;
		this.progresswidget1.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.dialogAuthenticationAction.Activated += new global::System.EventHandler(this.OnDialogAuthenticationActionActivated);
		this.UsersAction.Activated += new global::System.EventHandler(this.OnUsersActionActivated);
		this.quitAction.Activated += new global::System.EventHandler(this.OnQuitActionActivated);
		this.Action5.Activated += new global::System.EventHandler(this.OnAction5Activated);
		this.Action6.Activated += new global::System.EventHandler(this.OnAction6Activated);
		this.Action7.Activated += new global::System.EventHandler(this.OnAction7Activated);
		this.Action8.Activated += new global::System.EventHandler(this.OnAction8Activated);
		this.Action9.Activated += new global::System.EventHandler(this.OnAction9Activated);
		this.aboutAction.Activated += new global::System.EventHandler(this.OnAboutActionActivated);
		this.Action10.Activated += new global::System.EventHandler(this.OnAction10Activated);
		this.Action11.Activated += new global::System.EventHandler(this.OnAction11Activated);
		this.Action12.Activated += new global::System.EventHandler(this.OnAction12Activated);
		this.helpAction.Activated += new global::System.EventHandler(this.OnHelpActionActivated);
		this.ActionHistory.Activated += new global::System.EventHandler(this.OnActionHistoryActivated);
		this.ActionUpdate.Activated += new global::System.EventHandler(this.OnActionUpdateActivated);
		this.ActionSN.Activated += new global::System.EventHandler(this.OnActionSNActivated);
		this.ActionNorms.Activated += new global::System.EventHandler(this.OnActionNormsActivated);
		this.Action13.Activated += new global::System.EventHandler(this.OnAction13Activated);
		this.ActionRequestSheet.Activated += new global::System.EventHandler(this.OnAction21Activated);
		this.ActionAverageAnnualNeed.Activated += new global::System.EventHandler(this.OnActionYearRequestSheetActivated);
		this.Action22.Activated += new global::System.EventHandler(this.OnAction17Activated);
		this.ActionStockDocs.Activated += new global::System.EventHandler(this.OnActionStockDocsActivated);
		this.ActionStockBalance.Activated += new global::System.EventHandler(this.OnActionStockBalanceActivated);
		this.ActionObjects.Activated += new global::System.EventHandler(this.OnActionObjectsActivated);
		this.ActionEmployees.Activated += new global::System.EventHandler(this.OnActionEmployeesActivated);
		this.ActionBarObjects.Activated += new global::System.EventHandler(this.OnActionBarObjectsActivated);
		this.ActionBarEmployees.Activated += new global::System.EventHandler(this.OnActionBarEmployeesActivated);
		this.ActionBarStore.Activated += new global::System.EventHandler(this.OnActionBarStoreActivated);
		this.ActionBarStoreBalance.Activated += new global::System.EventHandler(this.OnActionBarStoreBalanceActivated);
		this.ActionShowBar.Toggled += new global::System.EventHandler(this.OnActionShowBarToggled);
		this.ActionToolBarTextOnly.Toggled += new global::System.EventHandler(this.OnActionToolBarTextOnlyToggled);
		this.ActionToolBarIconOnly.Toggled += new global::System.EventHandler(this.OnActionToolBarIconOnlyToggled);
		this.ActionToolBarTextAndIcon.Toggled += new global::System.EventHandler(this.OnActionToolBarTextAndIconToggled);
		this.ActionIconsExtraSmall.Toggled += new global::System.EventHandler(this.OnActionIconsExtraSmallToggled);
		this.ActionIconsSmall.Toggled += new global::System.EventHandler(this.OnActionIconsSmallToggled);
		this.ActionIconsMiddle.Toggled += new global::System.EventHandler(this.OnActionIconsMiddleToggled);
		this.ActionIconsLarge.Toggled += new global::System.EventHandler(this.OnActionIconsLargeToggled);
		this.ActionSite.Activated += new global::System.EventHandler(this.OnActionSiteActivated);
		this.ActionOpenReformal.Activated += new global::System.EventHandler(this.OnActionOpenReformalActivated);
		this.ActionVK.Activated += new global::System.EventHandler(this.OnActionVKActivated);
		this.ActionOdnoklasniki.Activated += new global::System.EventHandler(this.OnActionOdnoklasnikiActivated);
		this.ActionTwitter.Activated += new global::System.EventHandler(this.OnActionTwitterActivated);
		this.ActionYouTube.Activated += new global::System.EventHandler(this.OnActionYouTubeActivated);
		this.ActionRegulationDoc.Activated += new global::System.EventHandler(this.OnActionRegulationDocActivated);
		this.ActionBaseSettings.Activated += new global::System.EventHandler(this.OnActionBaseSettingsActivated);
		this.ActionVacationTypes.Activated += new global::System.EventHandler(this.OnActionVacationTypesActivated);
		this.ActionOrganizations.Activated += new global::System.EventHandler(this.OnActionOrganizationsActivated);
		this.ActionIssuanceSheets.Activated += new global::System.EventHandler(this.OnActionIssuanceSheetsActivated);
		this.ActionWarehouse.Activated += new global::System.EventHandler(this.OnActionWarehouseActivated);
		this.ActionDepartment.Activated += new global::System.EventHandler(this.OnActionDepartmentActivated);
		this.ActionProfession.Activated += new global::System.EventHandler(this.OnActionProfessionActivated);
		this.ActionProtectionTools.Activated += new global::System.EventHandler(this.OnActionProtectionToolsActivated);
		this.ActionAmountEmployeeGetWear.Activated += new global::System.EventHandler(this.OnActionAmountEmployeeGetWearActivated);
		this.ActionAmountIssuedWear.Activated += new global::System.EventHandler(this.OnActionAmountIssuedWearActivated);
		this.ActionUserSettings.Activated += new global::System.EventHandler(this.OnActionUserSettingsActivated);
		this.ActionCardIssuee.Activated += new global::System.EventHandler(this.OnActionCardIssueeActivated);
	}
}

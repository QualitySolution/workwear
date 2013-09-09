
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action Action;
	private global::Gtk.Action Action1;
	private global::Gtk.Action Action2;
	private global::Gtk.Action Action3;
	private global::Gtk.Action dialogAuthenticationAction;
	private global::Gtk.Action UsersAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action Action5;
	private global::Gtk.Action Action6;
	private global::Gtk.Action Action7;
	private global::Gtk.Action Action8;
	private global::Gtk.Action Action9;
	private global::Gtk.Action aboutAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.Notebook notebookMain;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label label4;
	private global::Gtk.Entry entryObjectSearch;
	private global::Gtk.Button buttonObjectSearchClean;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeviewObjects;
	private global::Gtk.Label label1;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label5;
	private global::Gtk.Entry entryCardsSearch;
	private global::Gtk.Button buttonCardsSearchClear;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TreeView treeviewCards;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button buttonAdd;
	private global::Gtk.Button buttonEdit;
	private global::Gtk.Button buttonDelete;
	private global::Gtk.Button buttonRefresh;
	private global::Gtk.Statusbar MainStatusBar;
	private global::Gtk.Label labelUser;
	private global::Gtk.Label labelStatus;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.Action = new global::Gtk.Action ("Action", global::Mono.Unix.Catalog.GetString ("Файл"), null, null);
		this.Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("Файл");
		w1.Add (this.Action, null);
		this.Action1 = new global::Gtk.Action ("Action1", global::Mono.Unix.Catalog.GetString ("Справочники"), null, null);
		this.Action1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Справочники");
		w1.Add (this.Action1, null);
		this.Action2 = new global::Gtk.Action ("Action2", global::Mono.Unix.Catalog.GetString ("Ведомости"), null, null);
		this.Action2.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ведомости");
		w1.Add (this.Action2, null);
		this.Action3 = new global::Gtk.Action ("Action3", global::Mono.Unix.Catalog.GetString ("Справка"), null, null);
		this.Action3.ShortLabel = global::Mono.Unix.Catalog.GetString ("Справка");
		w1.Add (this.Action3, null);
		this.dialogAuthenticationAction = new global::Gtk.Action ("dialogAuthenticationAction", global::Mono.Unix.Catalog.GetString ("Изменить пароль"), null, "gtk-dialog-authentication");
		this.dialogAuthenticationAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Изменить пароль");
		w1.Add (this.dialogAuthenticationAction, null);
		this.UsersAction = new global::Gtk.Action ("UsersAction", global::Mono.Unix.Catalog.GetString ("Пользователи"), null, null);
		this.UsersAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Пользователи");
		w1.Add (this.UsersAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Выход"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Выход");
		w1.Add (this.quitAction, null);
		this.Action5 = new global::Gtk.Action ("Action5", global::Mono.Unix.Catalog.GetString ("Типы номенклатуры"), null, null);
		this.Action5.ShortLabel = global::Mono.Unix.Catalog.GetString ("Типы номенклатуры");
		w1.Add (this.Action5, null);
		this.Action6 = new global::Gtk.Action ("Action6", global::Mono.Unix.Catalog.GetString ("Номенклатура"), null, null);
		this.Action6.ShortLabel = global::Mono.Unix.Catalog.GetString ("Номенклатура");
		w1.Add (this.Action6, null);
		this.Action7 = new global::Gtk.Action ("Action7", global::Mono.Unix.Catalog.GetString ("Единицы измерения"), null, null);
		this.Action7.ShortLabel = global::Mono.Unix.Catalog.GetString ("Единицы измерения");
		w1.Add (this.Action7, null);
		this.Action8 = new global::Gtk.Action ("Action8", global::Mono.Unix.Catalog.GetString ("Должности"), null, null);
		this.Action8.ShortLabel = global::Mono.Unix.Catalog.GetString ("Должности");
		w1.Add (this.Action8, null);
		this.Action9 = new global::Gtk.Action ("Action9", global::Mono.Unix.Catalog.GetString ("Руководители"), null, null);
		this.Action9.ShortLabel = global::Mono.Unix.Catalog.GetString ("Руководители");
		w1.Add (this.Action9, null);
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("_О программе"), null, "gtk-about");
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_О программе");
		w1.Add (this.aboutAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("QS: Учет спецодежды");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='Action' action='Action'><menuitem name='dialogAuthenticationAction' action='dialogAuthenticationAction'/><menuitem name='UsersAction' action='UsersAction'/><separator/><menuitem name='quitAction' action='quitAction'/></menu><menu name='Action1' action='Action1'><menuitem name='Action5' action='Action5'/><menuitem name='Action6' action='Action6'/><separator/><menuitem name='Action7' action='Action7'/><separator/><menuitem name='Action8' action='Action8'/><menuitem name='Action9' action='Action9'/></menu><menu name='Action2' action='Action2'/><menu name='Action3' action='Action3'><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebookMain = new global::Gtk.Notebook ();
		this.notebookMain.CanFocus = true;
		this.notebookMain.Name = "notebookMain";
		this.notebookMain.CurrentPage = 1;
		// Container child notebookMain.Gtk.Notebook+NotebookChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		this.vbox2.BorderWidth = ((uint)(3));
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Поиск по имени и адресу:");
		this.hbox2.Add (this.label4);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryObjectSearch = new global::Gtk.Entry ();
		this.entryObjectSearch.CanFocus = true;
		this.entryObjectSearch.Name = "entryObjectSearch";
		this.entryObjectSearch.IsEditable = true;
		this.entryObjectSearch.InvisibleChar = '●';
		this.hbox2.Add (this.entryObjectSearch);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryObjectSearch]));
		w4.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.buttonObjectSearchClean = new global::Gtk.Button ();
		this.buttonObjectSearchClean.CanFocus = true;
		this.buttonObjectSearchClean.Name = "buttonObjectSearchClean";
		this.buttonObjectSearchClean.UseUnderline = true;
		// Container child buttonObjectSearchClean.Gtk.Container+ContainerChild
		global::Gtk.Alignment w5 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w6 = new global::Gtk.HBox ();
		w6.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w7 = new global::Gtk.Image ();
		w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
		w6.Add (w7);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w9 = new global::Gtk.Label ();
		w6.Add (w9);
		w5.Add (w6);
		this.buttonObjectSearchClean.Add (w5);
		this.hbox2.Add (this.buttonObjectSearchClean);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonObjectSearchClean]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeviewObjects = new global::Gtk.TreeView ();
		this.treeviewObjects.CanFocus = true;
		this.treeviewObjects.Name = "treeviewObjects";
		this.GtkScrolledWindow.Add (this.treeviewObjects);
		this.vbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
		w16.Position = 1;
		this.notebookMain.Add (this.vbox2);
		// Notebook tab
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Объекты");
		this.notebookMain.SetTabLabel (this.vbox2, this.label1);
		this.label1.ShowAll ();
		// Container child notebookMain.Gtk.Notebook+NotebookChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		this.vbox3.BorderWidth = ((uint)(3));
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Поиск по имени:");
		this.hbox3.Add (this.label5);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label5]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryCardsSearch = new global::Gtk.Entry ();
		this.entryCardsSearch.CanFocus = true;
		this.entryCardsSearch.Name = "entryCardsSearch";
		this.entryCardsSearch.IsEditable = true;
		this.entryCardsSearch.InvisibleChar = '●';
		this.hbox3.Add (this.entryCardsSearch);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryCardsSearch]));
		w19.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonCardsSearchClear = new global::Gtk.Button ();
		this.buttonCardsSearchClear.CanFocus = true;
		this.buttonCardsSearchClear.Name = "buttonCardsSearchClear";
		this.buttonCardsSearchClear.UseUnderline = true;
		// Container child buttonCardsSearchClear.Gtk.Container+ContainerChild
		global::Gtk.Alignment w20 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w21 = new global::Gtk.HBox ();
		w21.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w22 = new global::Gtk.Image ();
		w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
		w21.Add (w22);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w24 = new global::Gtk.Label ();
		w21.Add (w24);
		w20.Add (w21);
		this.buttonCardsSearchClear.Add (w20);
		this.hbox3.Add (this.buttonCardsSearchClear);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonCardsSearchClear]));
		w28.Position = 2;
		w28.Expand = false;
		w28.Fill = false;
		this.vbox3.Add (this.hbox3);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.treeviewCards = new global::Gtk.TreeView ();
		this.treeviewCards.CanFocus = true;
		this.treeviewCards.Name = "treeviewCards";
		this.GtkScrolledWindow1.Add (this.treeviewCards);
		this.vbox3.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow1]));
		w31.Position = 1;
		this.notebookMain.Add (this.vbox3);
		global::Gtk.Notebook.NotebookChild w32 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMain [this.vbox3]));
		w32.Position = 1;
		// Notebook tab
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Карточки учета");
		this.notebookMain.SetTabLabel (this.vbox3, this.label2);
		this.label2.ShowAll ();
		// Notebook tab
		global::Gtk.Label w33 = new global::Gtk.Label ();
		w33.Visible = true;
		this.notebookMain.Add (w33);
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Склад");
		this.notebookMain.SetTabLabel (w33, this.label3);
		this.label3.ShowAll ();
		this.vbox1.Add (this.notebookMain);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebookMain]));
		w34.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		this.hbox1.BorderWidth = ((uint)(3));
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonAdd = new global::Gtk.Button ();
		this.buttonAdd.CanFocus = true;
		this.buttonAdd.Name = "buttonAdd";
		this.buttonAdd.UseUnderline = true;
		// Container child buttonAdd.Gtk.Container+ContainerChild
		global::Gtk.Alignment w35 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w36 = new global::Gtk.HBox ();
		w36.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w37 = new global::Gtk.Image ();
		w37.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
		w36.Add (w37);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w39 = new global::Gtk.Label ();
		w39.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавить");
		w39.UseUnderline = true;
		w36.Add (w39);
		w35.Add (w36);
		this.buttonAdd.Add (w35);
		this.hbox1.Add (this.buttonAdd);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonAdd]));
		w43.Position = 0;
		w43.Expand = false;
		w43.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonEdit = new global::Gtk.Button ();
		this.buttonEdit.CanFocus = true;
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.UseUnderline = true;
		// Container child buttonEdit.Gtk.Container+ContainerChild
		global::Gtk.Alignment w44 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w45 = new global::Gtk.HBox ();
		w45.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w46 = new global::Gtk.Image ();
		w46.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
		w45.Add (w46);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w48 = new global::Gtk.Label ();
		w48.LabelProp = global::Mono.Unix.Catalog.GetString ("Изменить");
		w48.UseUnderline = true;
		w45.Add (w48);
		w44.Add (w45);
		this.buttonEdit.Add (w44);
		this.hbox1.Add (this.buttonEdit);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonEdit]));
		w52.Position = 1;
		w52.Expand = false;
		w52.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonDelete = new global::Gtk.Button ();
		this.buttonDelete.CanFocus = true;
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.UseUnderline = true;
		// Container child buttonDelete.Gtk.Container+ContainerChild
		global::Gtk.Alignment w53 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w54 = new global::Gtk.HBox ();
		w54.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w55 = new global::Gtk.Image ();
		w55.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
		w54.Add (w55);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w57 = new global::Gtk.Label ();
		w57.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить");
		w57.UseUnderline = true;
		w54.Add (w57);
		w53.Add (w54);
		this.buttonDelete.Add (w53);
		this.hbox1.Add (this.buttonDelete);
		global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonDelete]));
		w61.Position = 2;
		w61.Expand = false;
		w61.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonRefresh = new global::Gtk.Button ();
		this.buttonRefresh.TooltipMarkup = "Обновить текущую таблицу.";
		this.buttonRefresh.CanFocus = true;
		this.buttonRefresh.Name = "buttonRefresh";
		this.buttonRefresh.UseUnderline = true;
		// Container child buttonRefresh.Gtk.Container+ContainerChild
		global::Gtk.Alignment w62 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w63 = new global::Gtk.HBox ();
		w63.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w64 = new global::Gtk.Image ();
		w64.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
		w63.Add (w64);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w66 = new global::Gtk.Label ();
		w66.LabelProp = global::Mono.Unix.Catalog.GetString ("Обновить");
		w66.UseUnderline = true;
		w63.Add (w66);
		w62.Add (w63);
		this.buttonRefresh.Add (w62);
		this.hbox1.Add (this.buttonRefresh);
		global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonRefresh]));
		w70.PackType = ((global::Gtk.PackType)(1));
		w70.Position = 3;
		w70.Expand = false;
		w70.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w71 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w71.Position = 2;
		w71.Expand = false;
		w71.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.MainStatusBar = new global::Gtk.Statusbar ();
		this.MainStatusBar.Name = "MainStatusBar";
		this.MainStatusBar.Spacing = 6;
		// Container child MainStatusBar.Gtk.Box+BoxChild
		this.labelUser = new global::Gtk.Label ();
		this.labelUser.Name = "labelUser";
		this.labelUser.LabelProp = global::Mono.Unix.Catalog.GetString ("Пользователь");
		this.MainStatusBar.Add (this.labelUser);
		global::Gtk.Box.BoxChild w72 = ((global::Gtk.Box.BoxChild)(this.MainStatusBar [this.labelUser]));
		w72.Position = 0;
		w72.Expand = false;
		w72.Fill = false;
		// Container child MainStatusBar.Gtk.Box+BoxChild
		this.labelStatus = new global::Gtk.Label ();
		this.labelStatus.Name = "labelStatus";
		this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString ("Ok");
		this.MainStatusBar.Add (this.labelStatus);
		global::Gtk.Box.BoxChild w73 = ((global::Gtk.Box.BoxChild)(this.MainStatusBar [this.labelStatus]));
		w73.Position = 2;
		w73.Expand = false;
		w73.Fill = false;
		this.vbox1.Add (this.MainStatusBar);
		global::Gtk.Box.BoxChild w74 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.MainStatusBar]));
		w74.Position = 3;
		w74.Expand = false;
		w74.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 709;
		this.DefaultHeight = 458;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.dialogAuthenticationAction.Activated += new global::System.EventHandler (this.OnDialogAuthenticationActionActivated);
		this.UsersAction.Activated += new global::System.EventHandler (this.OnAction10Activated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.Action5.Activated += new global::System.EventHandler (this.OnAction5Activated);
		this.Action6.Activated += new global::System.EventHandler (this.OnAction6Activated);
		this.Action7.Activated += new global::System.EventHandler (this.OnAction7Activated);
		this.Action8.Activated += new global::System.EventHandler (this.OnAction8Activated);
		this.Action9.Activated += new global::System.EventHandler (this.OnAction9Activated);
		this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.notebookMain.SwitchPage += new global::Gtk.SwitchPageHandler (this.OnNotebookMainSwitchPage);
		this.entryObjectSearch.Changed += new global::System.EventHandler (this.OnEntryObjectSearchChanged);
		this.buttonObjectSearchClean.Clicked += new global::System.EventHandler (this.OnButtonObjectSearchCleanClicked);
		this.treeviewObjects.CursorChanged += new global::System.EventHandler (this.OnTreeviewObjectsCursorChanged);
		this.treeviewObjects.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeviewObjectsRowActivated);
		this.entryCardsSearch.Changed += new global::System.EventHandler (this.OnEntryCardsSearchChanged);
		this.buttonCardsSearchClear.Clicked += new global::System.EventHandler (this.OnButtonCardsSearchClearClicked);
		this.treeviewCards.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeviewCardsRowActivated);
		this.treeviewCards.CursorChanged += new global::System.EventHandler (this.OnTreeviewCardsCursorChanged);
		this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
		this.buttonEdit.Clicked += new global::System.EventHandler (this.OnButtonEditClicked);
		this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
		this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
	}
}

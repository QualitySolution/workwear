
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
		this.notebookMain.CurrentPage = 0;
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
		// Notebook tab
		global::Gtk.Label w18 = new global::Gtk.Label ();
		w18.Visible = true;
		this.notebookMain.Add (w18);
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Карточки учета");
		this.notebookMain.SetTabLabel (w18, this.label2);
		this.label2.ShowAll ();
		// Notebook tab
		global::Gtk.Label w19 = new global::Gtk.Label ();
		w19.Visible = true;
		this.notebookMain.Add (w19);
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Склад");
		this.notebookMain.SetTabLabel (w19, this.label3);
		this.label3.ShowAll ();
		this.vbox1.Add (this.notebookMain);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebookMain]));
		w20.Position = 1;
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
		global::Gtk.Alignment w21 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w22 = new global::Gtk.HBox ();
		w22.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w23 = new global::Gtk.Image ();
		w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
		w22.Add (w23);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w25 = new global::Gtk.Label ();
		w25.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавить");
		w25.UseUnderline = true;
		w22.Add (w25);
		w21.Add (w22);
		this.buttonAdd.Add (w21);
		this.hbox1.Add (this.buttonAdd);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonAdd]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonEdit = new global::Gtk.Button ();
		this.buttonEdit.CanFocus = true;
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.UseUnderline = true;
		// Container child buttonEdit.Gtk.Container+ContainerChild
		global::Gtk.Alignment w30 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w31 = new global::Gtk.HBox ();
		w31.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w32 = new global::Gtk.Image ();
		w32.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
		w31.Add (w32);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w34 = new global::Gtk.Label ();
		w34.LabelProp = global::Mono.Unix.Catalog.GetString ("Изменить");
		w34.UseUnderline = true;
		w31.Add (w34);
		w30.Add (w31);
		this.buttonEdit.Add (w30);
		this.hbox1.Add (this.buttonEdit);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonEdit]));
		w38.Position = 1;
		w38.Expand = false;
		w38.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonDelete = new global::Gtk.Button ();
		this.buttonDelete.CanFocus = true;
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.UseUnderline = true;
		// Container child buttonDelete.Gtk.Container+ContainerChild
		global::Gtk.Alignment w39 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w40 = new global::Gtk.HBox ();
		w40.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w41 = new global::Gtk.Image ();
		w41.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
		w40.Add (w41);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w43 = new global::Gtk.Label ();
		w43.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить");
		w43.UseUnderline = true;
		w40.Add (w43);
		w39.Add (w40);
		this.buttonDelete.Add (w39);
		this.hbox1.Add (this.buttonDelete);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonDelete]));
		w47.Position = 2;
		w47.Expand = false;
		w47.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonRefresh = new global::Gtk.Button ();
		this.buttonRefresh.TooltipMarkup = "Обновить текущую таблицу.";
		this.buttonRefresh.CanFocus = true;
		this.buttonRefresh.Name = "buttonRefresh";
		this.buttonRefresh.UseUnderline = true;
		// Container child buttonRefresh.Gtk.Container+ContainerChild
		global::Gtk.Alignment w48 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w49 = new global::Gtk.HBox ();
		w49.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w50 = new global::Gtk.Image ();
		w50.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
		w49.Add (w50);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w52 = new global::Gtk.Label ();
		w52.LabelProp = global::Mono.Unix.Catalog.GetString ("Обновить");
		w52.UseUnderline = true;
		w49.Add (w52);
		w48.Add (w49);
		this.buttonRefresh.Add (w48);
		this.hbox1.Add (this.buttonRefresh);
		global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonRefresh]));
		w56.PackType = ((global::Gtk.PackType)(1));
		w56.Position = 3;
		w56.Expand = false;
		w56.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w57.Position = 2;
		w57.Expand = false;
		w57.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.MainStatusBar = new global::Gtk.Statusbar ();
		this.MainStatusBar.Name = "MainStatusBar";
		this.MainStatusBar.Spacing = 6;
		// Container child MainStatusBar.Gtk.Box+BoxChild
		this.labelUser = new global::Gtk.Label ();
		this.labelUser.Name = "labelUser";
		this.labelUser.LabelProp = global::Mono.Unix.Catalog.GetString ("Пользователь");
		this.MainStatusBar.Add (this.labelUser);
		global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.MainStatusBar [this.labelUser]));
		w58.Position = 0;
		w58.Expand = false;
		w58.Fill = false;
		// Container child MainStatusBar.Gtk.Box+BoxChild
		this.labelStatus = new global::Gtk.Label ();
		this.labelStatus.Name = "labelStatus";
		this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString ("Ok");
		this.MainStatusBar.Add (this.labelStatus);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.MainStatusBar [this.labelStatus]));
		w59.Position = 2;
		w59.Expand = false;
		w59.Fill = false;
		this.vbox1.Add (this.MainStatusBar);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.MainStatusBar]));
		w60.Position = 3;
		w60.Expand = false;
		w60.Fill = false;
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
		this.entryObjectSearch.Changed += new global::System.EventHandler (this.OnEntryObjectSearchChanged);
		this.buttonObjectSearchClean.Clicked += new global::System.EventHandler (this.OnButtonObjectSearchCleanClicked);
		this.treeviewObjects.CursorChanged += new global::System.EventHandler (this.OnTreeviewObjectsCursorChanged);
		this.treeviewObjects.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeviewObjectsRowActivated);
		this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
		this.buttonEdit.Clicked += new global::System.EventHandler (this.OnButtonEditClicked);
		this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
	}
}

using System;
using Gtk;
using workwear;
using QSProjectsLib;
using QSSupportLib;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow(): base (Gtk.WindowType.Toplevel)
	{
		Build();
		
		//Передаем лебл
		MainClass.StatusBarLabel = labelStatus;
		Reference.RunReferenceItemDlg += OnRunReferenceItemDialog;
		QSMain.ReferenceUpdated += OnReferenceUpdate;


		try
		{
			MainSupport.Param = new BaseParam(QSMain.connectionDB);
		}
		catch(MySqlException e)
		{
			Console.WriteLine(e.Message);
			MessageDialog BaseError = new MessageDialog ( this, DialogFlags.DestroyWithParent,
	                                      MessageType.Warning, 
	                                      ButtonsType.Close, 
	                                      "Не удалось получить информацию о базе данных.");
			BaseError.Run();
			BaseError.Destroy();
			Environment.Exit(0);
		}
		
		MainSupport.ProjectVerion = new AppVersion(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString(),
		 	"gpl",
		 	System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
		MainSupport.TestVersion(this);

		if(QSMain.User.Login == "root")
		{
			string Message = "Вы зашли в программу под администратором базы данных. У вас есть только возможность создавать других пользователей.";
			MessageDialog md = new MessageDialog ( this, DialogFlags.DestroyWithParent,
			                                      MessageType.Info, 
			                                      ButtonsType.Ok,
			                                      Message);
			md.Run ();
			md.Destroy();
			Users WinUser = new Users();
			WinUser.Show();
			WinUser.Run ();
			WinUser.Destroy ();
			return;
		}

		if(QSMain.connectionDB.DataSource == "demo.qsolution.ru")
		{
			string Message = "Вы подключились к демонстрационному серверу. Сервер предназначен для оценки " +
				"возможностей программы, не используйте его для работы, так как ваши данные будут доступны " +
				"любому пользователю через интернет.\n\nДля полноценного использования программы вам необходимо " +
				"установить собственный сервер. Для его установки обратитесь к документации.\n\nЕсли у вас возникнут " +
				"вопросы вы можете задать их на форуме программы: https://groups.google.com/forum/?fromgroups#!forum/bazarsoft " +
				"или обратится в нашу тех. поддержку.";
			MessageDialog md = new MessageDialog ( this, DialogFlags.DestroyWithParent,
			                                      MessageType.Info, 
			                                      ButtonsType.Ok,
			                                      Message);
			md.Run ();
			md.Destroy();
			dialogAuthenticationAction.Sensitive = false;
		}

		//Загружаем информацию о пользователе
		if(QSMain.User.TestUserExistByLogin (true))
			QSMain.User.UpdateUserInfoByLogin ();
		UsersAction.Sensitive = QSMain.User.admin;
		labelUser.LabelProp = QSMain.User.Name;

		PrepareObject();
		UpdateObject();
		notebookMain.CurrentPage = 0;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
	
	protected void OnDialogAuthenticationActionActivated(object sender, EventArgs e)
	{
		QSMain.User.ChangeUserPassword (this);
	}
	
	protected void OnAction10Activated(object sender, EventArgs e)
	{
		Users winUsers = new Users();
		winUsers.Show();
		winUsers.Run();
		winUsers.Destroy();
	}

	protected void OnQuitActionActivated(object sender, EventArgs e)
	{
		Application.Quit();
	}
	
	protected void OnReferenceUpdate(object sender, QSMain.ReferenceUpdatedEventArgs e)
	{
	/*	switch (e.ReferenceTable) {
		case "doc_types":
			ComboWorks.ComboFillReference (comboDocType, "doc_types", 0);
		break;
		} */
	}
	
	protected void OnRunReferenceItemDialog(object sender, Reference.RunReferenceItemDlgEventArgs e)
	{
		ResponseType Result;
		switch (e.TableName)
		{
		case "item_types":
			ItemType ItemTypeEdit = new ItemType();
			if(e.NewItem)
				ItemTypeEdit.NewItem = true;
			else 
				ItemTypeEdit.Fill(e.ItemId);
			ItemTypeEdit.Show();
			Result = (ResponseType)ItemTypeEdit.Run();
			ItemTypeEdit.Destroy();
			break;
		case "nomenclature":
			Nomenclature NomenclatureEdit = new Nomenclature();
			if(e.NewItem)
				NomenclatureEdit.NewItem = true;
			else 
				NomenclatureEdit.Fill(e.ItemId);
			NomenclatureEdit.Show();
			Result = (ResponseType)NomenclatureEdit.Run();
			NomenclatureEdit.Destroy();
			break;
		default:
			Result = ResponseType.None;
			break;
		}
		e.Result = Result;
	}
	
	protected void OnAction7Activated(object sender, EventArgs e)
	{
		Reference winref = new Reference();
		winref.SetMode(true,false,true,true,true);
		winref.FillList("units","Единица измерения", "Единицы измерения");
		winref.Show();
		winref.Run();
		winref.Destroy();
	}

	protected void OnAction8Activated(object sender, EventArgs e)
	{
		Reference winref = new Reference();
		winref.SetMode(true,false,true,true,true);
		winref.FillList("posts","Должность", "Должности");
		winref.Show();
		winref.Run();
		winref.Destroy();
	}
	
	protected void OnAction9Activated(object sender, EventArgs e)
	{
		Reference winref = new Reference();
		winref.SetMode(true,false,true,true,true);
		winref.FillList("leaders","Руководитель", "Руководители");
		winref.Show();
		winref.Run();
		winref.Destroy();
	}
	
	protected void OnAction5Activated(object sender, EventArgs e)
	{
		Reference winref = new Reference();
		winref.SetMode(false, false, true, true, true);
		winref.FillList("item_types","Тип номенклатуры", "Виды номенклатуры");
		winref.Show();
		winref.Run();
		winref.Destroy();
	}

	protected void OnAction6Activated(object sender, EventArgs e)
	{
		Reference winref = new Reference();
		winref.SetMode(false, false, true, true, true);
		winref.FillList("nomenclature","Номенклатура", "Номенклатуры");
		winref.Show();
		winref.Run();
		winref.Destroy();

	}

	protected void OnAboutActionActivated(object sender, EventArgs e)
	{
		AboutDialog dialog = new AboutDialog ();
		dialog.ProgramName = "QS:Учет спецодежды";

		Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
		dialog.Version = String.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);

		dialog.Logo = Gdk.Pixbuf.LoadFromResource ("workwear.icon.logo.png");

		dialog.Comments = "Программа позволяет вести учет спецодежды." +
			"\nРазработана на MonoDevelop с использованием открытых технологий Mono, GTK#, MySQL." +
			"\nТелефон тех. поддержки +7(812)575-79-44";

		dialog.Copyright = "Quality Solution 2013";

		dialog.Authors = new string [] {"Ганьков Андрей <gav@qsolution.ru>"};

		dialog.Website = "http://www.qsolution.ru/";

		dialog.Run ();
		dialog.Destroy();
	}
	
	protected void OnButtonRefreshClicked(object sender, EventArgs e)
	{
		switch (notebookMain.CurrentPage) {
			case 0:
				UpdateObject();
				break;
				case 1:
				//UpdateLessees();
				break;
				case 2:
				//UpdateContract();
				break;
				default:
				break;
		}
	}

	protected void OnButtonAddClicked(object sender, EventArgs e)
	{
		switch (notebookMain.CurrentPage) {
			case 0:
				ObjectDlg winObject = new ObjectDlg();
				winObject.NewItem = true;
				winObject.Show();
				winObject.Run();
				winObject.Destroy();
				UpdateObject();
				break;
				case 1:
	/*			lessee winLessee = new lessee();
				winLessee.NewLessee = true;
				winLessee.Show();
				winLessee.Run();
				winLessee.Destroy();
				UpdateLessees();
				break;
				case 2:
				Contract winContract = new Contract();
				winContract.NewContract = true;
				winContract.Show();
				winContract.Run();
				winContract.Destroy();
				UpdateContract();
				break; */
				default:
				break;
		}

	}

	protected void OnButtonEditClicked(object sender, EventArgs e)
	{
		TreeIter iter;
		int itemid;
		ResponseType result;

		switch (notebookMain.CurrentPage) {
			case 0:
				treeviewObjects.Selection.GetSelected(out iter);
				itemid = (int) ObjectFilter.GetValue(iter,0);
				ObjectDlg winObject = new ObjectDlg();
				winObject.Fill(itemid);
				winObject.Show();
				result = (ResponseType)winObject.Run();
				winObject.Destroy();
				if(result == ResponseType.Ok)
					UpdateObject();
				break;
	/*			case 1:
				treeviewLessees.Selection.GetSelected(out iter);
				itemid = Convert.ToInt32(Lesseesfilter.GetValue(iter,0));
				lessee winLessee = new lessee();
				winLessee.LesseeFill(itemid);
				winLessee.Show();
				result = (ResponseType)winLessee.Run();
				winLessee.Destroy();
				if(result == ResponseType.Ok)
					UpdateLessees();
				break;
				case 2:
				treeviewContract.Selection.GetSelected(out iter);
				itemid = (int) Contractfilter.GetValue(iter, 0);
				Contract winContract = new Contract();
				winContract.ContractFill(itemid);
				winContract.Show();
				result = (ResponseType)winContract.Run();
				winContract.Destroy();
				if(result == ResponseType.Ok)
					UpdateContract();
				break; */
				default:
				break;
		}

	}
}


// This file has been generated by the GUI designer. Do not modify.
namespace workwear.Views.Tools
{
	public partial class EmployeesLoadView
	{
		private global::Gtk.VBox vbox1;

		private global::Gamma.GtkWidgets.yNotebook notebookSteps;

		private global::Gtk.VBox vbox2;

		private global::Gamma.GtkWidgets.yFileChooserButton filechooser;

		private global::Gamma.GtkWidgets.yTable ytable2;

		private global::Gamma.Widgets.yListComboBox comboSheets;

		private global::Gamma.GtkWidgets.yLabel ylabel2;

		private global::Gamma.GtkWidgets.yButton buttonLoad;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Table tableColumns;

		private global::Gamma.GtkWidgets.ySpinButton spinTitleRow;

		private global::Gamma.GtkWidgets.yLabel ylabel1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Label label3;

		private global::Gtk.Label GtkLabel2;

		private global::Gamma.GtkWidgets.yButton buttonReadEmployees;

		private global::Gtk.Label label2;

		private global::Gtk.Label label4;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView treeviewRows;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.Views.Tools.EmployeesLoadView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.Views.Tools.EmployeesLoadView";
			// Container child workwear.Views.Tools.EmployeesLoadView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebookSteps = new global::Gamma.GtkWidgets.yNotebook();
			this.notebookSteps.CanFocus = true;
			this.notebookSteps.Name = "notebookSteps";
			this.notebookSteps.CurrentPage = 1;
			this.notebookSteps.ShowBorder = false;
			// Container child notebookSteps.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.filechooser = new global::Gamma.GtkWidgets.yFileChooserButton();
			this.filechooser.Name = "filechooser";
			this.filechooser.Title = global::Mono.Unix.Catalog.GetString("Выберите файл со списком сотрудников");
			this.vbox2.Add(this.filechooser);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.filechooser]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.ytable2 = new global::Gamma.GtkWidgets.yTable();
			this.ytable2.Name = "ytable2";
			this.ytable2.NColumns = ((uint)(3));
			this.ytable2.RowSpacing = ((uint)(6));
			this.ytable2.ColumnSpacing = ((uint)(6));
			// Container child ytable2.Gtk.Table+TableChild
			this.comboSheets = new global::Gamma.Widgets.yListComboBox();
			this.comboSheets.Name = "comboSheets";
			this.comboSheets.AddIfNotExist = false;
			this.comboSheets.DefaultFirst = true;
			this.ytable2.Add(this.comboSheets);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.ytable2[this.comboSheets]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child ytable2.Gtk.Table+TableChild
			this.ylabel2 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel2.Name = "ylabel2";
			this.ylabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Лист с данными:");
			this.ytable2.Add(this.ylabel2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.ytable2[this.ylabel2]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.ytable2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.ytable2]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonLoad = new global::Gamma.GtkWidgets.yButton();
			this.buttonLoad.CanFocus = true;
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.UseUnderline = true;
			this.buttonLoad.Label = global::Mono.Unix.Catalog.GetString("Разбор листа ⇨");
			this.vbox2.Add(this.buttonLoad);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.buttonLoad]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.notebookSteps.Add(this.vbox2);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Выбор файла [Шаг 1 ]");
			this.notebookSteps.SetTabLabel(this.vbox2, this.label1);
			this.label1.ShowAll();
			// Container child notebookSteps.Gtk.Notebook+NotebookChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.tableColumns = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.tableColumns.Name = "tableColumns";
			this.tableColumns.RowSpacing = ((uint)(6));
			this.tableColumns.ColumnSpacing = ((uint)(6));
			// Container child tableColumns.Gtk.Table+TableChild
			this.spinTitleRow = new global::Gamma.GtkWidgets.ySpinButton(0D, 100D, 1D);
			this.spinTitleRow.CanFocus = true;
			this.spinTitleRow.Name = "spinTitleRow";
			this.spinTitleRow.Adjustment.PageIncrement = 10D;
			this.spinTitleRow.ClimbRate = 1D;
			this.spinTitleRow.Numeric = true;
			this.spinTitleRow.ValueAsDecimal = 0m;
			this.spinTitleRow.ValueAsInt = 0;
			this.tableColumns.Add(this.spinTitleRow);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableColumns[this.spinTitleRow]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableColumns.Gtk.Table+TableChild
			this.ylabel1 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel1.Name = "ylabel1";
			this.ylabel1.LabelProp = global::Mono.Unix.Catalog.GetString("Номер строки с заголовками:");
			this.tableColumns.Add(this.ylabel1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableColumns[this.ylabel1]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.tableColumns);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.tableColumns]));
			w9.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString(@"Установите номер строки с заголовком данных, таким образом чтобы название колонок было корретно. Если в таблице заголовки отутствуют укажите 0.
Далее для каждой значимой колонки проставьте тип данных которых находится в таблице.
При загрузки листа программа автоматически пытается найти залоговок таблицы и выбрать тип данных.
Обязательными данными являются Фамилия и Имя или ФИО.");
			this.label3.Wrap = true;
			this.label3.Justify = ((global::Gtk.Justification)(3));
			this.GtkAlignment.Add(this.label3);
			this.frame1.Add(this.GtkAlignment);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Рекомендации");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox3.Add(this.frame1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.frame1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonReadEmployees = new global::Gamma.GtkWidgets.yButton();
			this.buttonReadEmployees.CanFocus = true;
			this.buttonReadEmployees.Name = "buttonReadEmployees";
			this.buttonReadEmployees.UseUnderline = true;
			this.buttonReadEmployees.Label = global::Mono.Unix.Catalog.GetString("Сопоставление с сотрудниками.");
			this.vbox3.Add(this.buttonReadEmployees);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.buttonReadEmployees]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox1.Add(this.vbox3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.notebookSteps.Add(this.hbox1);
			global::Gtk.Notebook.NotebookChild w15 = ((global::Gtk.Notebook.NotebookChild)(this.notebookSteps[this.hbox1]));
			w15.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Формат файла [Шаг 2]");
			this.notebookSteps.SetTabLabel(this.hbox1, this.label2);
			this.label2.ShowAll();
			// Notebook tab
			global::Gtk.Label w16 = new global::Gtk.Label();
			w16.Visible = true;
			this.notebookSteps.Add(w16);
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Обработка данных [Шаг 4]");
			this.notebookSteps.SetTabLabel(w16, this.label4);
			this.label4.ShowAll();
			this.vbox1.Add(this.notebookSteps);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebookSteps]));
			w17.Position = 0;
			w17.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewRows = new global::Gamma.GtkWidgets.yTreeView();
			this.treeviewRows.CanFocus = true;
			this.treeviewRows.Name = "treeviewRows";
			this.GtkScrolledWindow.Add(this.treeviewRows);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w19.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonLoad.Clicked += new global::System.EventHandler(this.OnButtonLoadClicked);
		}
	}
}

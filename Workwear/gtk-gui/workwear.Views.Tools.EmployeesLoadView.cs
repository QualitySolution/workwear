
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

		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Table table1;

		private global::Gamma.GtkWidgets.yCheckButton checkSaveChangedEmployees;

		private global::Gamma.GtkWidgets.yCheckButton checkSaveNewEmployees;

		private global::Gtk.Label label5;

		private global::Gamma.GtkWidgets.yLabel labelCountChangedEmployees;

		private global::Gamma.GtkWidgets.yLabel labelCountMultiMatch;

		private global::Gamma.GtkWidgets.yLabel labelCountNewEmployees;

		private global::Gamma.GtkWidgets.yLabel labelCountNoChangesEmployees;

		private global::Gamma.GtkWidgets.yLabel labelCountSkipRows;

		private global::Gamma.GtkWidgets.yLabel ylabel10;

		private global::Gamma.GtkWidgets.yLabel ylabel3;

		private global::Gamma.GtkWidgets.yLabel ylabel4;

		private global::Gamma.GtkWidgets.yLabel ylabel5;

		private global::QS.Widgets.ProgressWidget progressStep3;

		private global::Gamma.GtkWidgets.yButton buttonSave;

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
			this.notebookSteps.CurrentPage = 2;
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
			this.buttonReadEmployees.Label = global::Mono.Unix.Catalog.GetString("Сопоставление сотрудников ⇨");
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
			// Container child notebookSteps.Gtk.Notebook+NotebookChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(5)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkSaveChangedEmployees = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkSaveChangedEmployees.CanFocus = true;
			this.checkSaveChangedEmployees.Name = "checkSaveChangedEmployees";
			this.checkSaveChangedEmployees.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			this.checkSaveChangedEmployees.Active = true;
			this.checkSaveChangedEmployees.DrawIndicator = true;
			this.checkSaveChangedEmployees.UseUnderline = true;
			this.table1.Add(this.checkSaveChangedEmployees);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.checkSaveChangedEmployees]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkSaveNewEmployees = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkSaveNewEmployees.CanFocus = true;
			this.checkSaveNewEmployees.Name = "checkSaveNewEmployees";
			this.checkSaveNewEmployees.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			this.checkSaveNewEmployees.Active = true;
			this.checkSaveNewEmployees.DrawIndicator = true;
			this.checkSaveNewEmployees.UseUnderline = true;
			this.table1.Add(this.checkSaveNewEmployees);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.checkSaveNewEmployees]));
			w17.LeftAttach = ((uint)(2));
			w17.RightAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Несколько соответствий:");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCountChangedEmployees = new global::Gamma.GtkWidgets.yLabel();
			this.labelCountChangedEmployees.Name = "labelCountChangedEmployees";
			this.labelCountChangedEmployees.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel5");
			this.table1.Add(this.labelCountChangedEmployees);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.labelCountChangedEmployees]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCountMultiMatch = new global::Gamma.GtkWidgets.yLabel();
			this.labelCountMultiMatch.Name = "labelCountMultiMatch";
			this.labelCountMultiMatch.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel1");
			this.table1.Add(this.labelCountMultiMatch);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.labelCountMultiMatch]));
			w20.TopAttach = ((uint)(4));
			w20.BottomAttach = ((uint)(5));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCountNewEmployees = new global::Gamma.GtkWidgets.yLabel();
			this.labelCountNewEmployees.Name = "labelCountNewEmployees";
			this.labelCountNewEmployees.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel4");
			this.table1.Add(this.labelCountNewEmployees);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.labelCountNewEmployees]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCountNoChangesEmployees = new global::Gamma.GtkWidgets.yLabel();
			this.labelCountNoChangesEmployees.Name = "labelCountNoChangesEmployees";
			this.labelCountNoChangesEmployees.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel6");
			this.table1.Add(this.labelCountNoChangesEmployees);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.labelCountNoChangesEmployees]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCountSkipRows = new global::Gamma.GtkWidgets.yLabel();
			this.labelCountSkipRows.Name = "labelCountSkipRows";
			this.labelCountSkipRows.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel3");
			this.table1.Add(this.labelCountSkipRows);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.labelCountSkipRows]));
			w23.TopAttach = ((uint)(3));
			w23.BottomAttach = ((uint)(4));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabel10 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel10.Name = "ylabel10";
			this.ylabel10.Xalign = 1F;
			this.ylabel10.LabelProp = global::Mono.Unix.Catalog.GetString("Пропущеные строки:");
			this.table1.Add(this.ylabel10);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabel10]));
			w24.TopAttach = ((uint)(3));
			w24.BottomAttach = ((uint)(4));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabel3 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel3.Name = "ylabel3";
			this.ylabel3.Xalign = 1F;
			this.ylabel3.LabelProp = global::Mono.Unix.Catalog.GetString("Создать сотрудников:");
			this.table1.Add(this.ylabel3);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabel3]));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabel4 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel4.Name = "ylabel4";
			this.ylabel4.Xalign = 1F;
			this.ylabel4.LabelProp = global::Mono.Unix.Catalog.GetString("Обновить сотрудников:");
			this.table1.Add(this.ylabel4);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabel4]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabel5 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel5.Name = "ylabel5";
			this.ylabel5.Xalign = 1F;
			this.ylabel5.LabelProp = global::Mono.Unix.Catalog.GetString("Не изменилось  сотрудников:");
			this.table1.Add(this.ylabel5);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabel5]));
			w27.TopAttach = ((uint)(2));
			w27.BottomAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add(this.table1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.table1]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.progressStep3 = new global::QS.Widgets.ProgressWidget();
			this.progressStep3.Name = "progressStep3";
			this.vbox4.Add(this.progressStep3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.progressStep3]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gamma.GtkWidgets.yButton();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w30 = new global::Gtk.Image();
			w30.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w30;
			this.vbox4.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonSave]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			this.hbox2.Add(this.vbox4);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			this.notebookSteps.Add(this.hbox2);
			global::Gtk.Notebook.NotebookChild w33 = ((global::Gtk.Notebook.NotebookChild)(this.notebookSteps[this.hbox2]));
			w33.Position = 2;
			// Notebook tab
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Обработка данных [Шаг 3]");
			this.notebookSteps.SetTabLabel(this.hbox2, this.label4);
			this.label4.ShowAll();
			this.vbox1.Add(this.notebookSteps);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebookSteps]));
			w34.Position = 0;
			w34.Expand = false;
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
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w36.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonLoad.Clicked += new global::System.EventHandler(this.OnButtonLoadClicked);
			this.buttonReadEmployees.Clicked += new global::System.EventHandler(this.OnButtonReadEmployeesClicked);
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
		}
	}
}
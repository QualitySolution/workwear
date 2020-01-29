
// This file has been generated by the GUI designer. Do not modify.
namespace workwear.Views.Statements
{
	public partial class IssuanceSheetView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.Button buttonPrint;

		private global::Gtk.Table table1;

		private global::Gamma.Widgets.yDatePicker dateOfPreparation;

		private global::QS.Views.Control.EntityEntry entityentryHeadOfDivisionPerson;

		private global::QS.Views.Control.EntityEntry entityentryOrganization;

		private global::QS.Views.Control.EntityEntry entityentryResponsiblePerson;

		private global::QS.Views.Control.EntityEntry entityentrySubdivision;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gamma.GtkWidgets.yLabel ylabel2;

		private global::Gamma.GtkWidgets.yLabel ylabel3;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label4;

		private global::Gtk.HBox hboxExpense;

		private global::Gtk.Label labelExpense;

		private global::Gtk.Button buttonExpenseOpen;

		private global::Gamma.GtkWidgets.yButton buttonCloseFillBy;

		private global::Gtk.Button buttonFillBy;

		private global::Gtk.HBox hboxTable;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewItems;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Button buttonAdd;

		private global::Gtk.Button buttonDel;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Button buttonSetEmployee;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.Views.Statements.IssuanceSheetView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.Views.Statements.IssuanceSheetView";
			// Container child workwear.Views.Statements.IssuanceSheetView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox4.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox4.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.hbox4.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator2]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonPrint = new global::Gtk.Button();
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			this.buttonPrint.Label = global::Mono.Unix.Catalog.GetString("Печать");
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.buttonPrint.Image = w6;
			this.hbox4.Add(this.buttonPrint);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonPrint]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.dateOfPreparation = new global::Gamma.Widgets.yDatePicker();
			this.dateOfPreparation.Events = ((global::Gdk.EventMask)(256));
			this.dateOfPreparation.Name = "dateOfPreparation";
			this.dateOfPreparation.WithTime = false;
			this.dateOfPreparation.Date = new global::System.DateTime(0);
			this.dateOfPreparation.IsEditable = true;
			this.dateOfPreparation.AutoSeparation = true;
			this.table1.Add(this.dateOfPreparation);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.dateOfPreparation]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityentryHeadOfDivisionPerson = new global::QS.Views.Control.EntityEntry();
			this.entityentryHeadOfDivisionPerson.Events = ((global::Gdk.EventMask)(256));
			this.entityentryHeadOfDivisionPerson.Name = "entityentryHeadOfDivisionPerson";
			this.table1.Add(this.entityentryHeadOfDivisionPerson);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.entityentryHeadOfDivisionPerson]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(3));
			w10.RightAttach = ((uint)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityentryOrganization = new global::QS.Views.Control.EntityEntry();
			this.entityentryOrganization.Events = ((global::Gdk.EventMask)(256));
			this.entityentryOrganization.Name = "entityentryOrganization";
			this.table1.Add(this.entityentryOrganization);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.entityentryOrganization]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityentryResponsiblePerson = new global::QS.Views.Control.EntityEntry();
			this.entityentryResponsiblePerson.Events = ((global::Gdk.EventMask)(256));
			this.entityentryResponsiblePerson.Name = "entityentryResponsiblePerson";
			this.table1.Add(this.entityentryResponsiblePerson);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.entityentryResponsiblePerson]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(3));
			w12.RightAttach = ((uint)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityentrySubdivision = new global::QS.Views.Control.EntityEntry();
			this.entityentrySubdivision.Events = ((global::Gdk.EventMask)(256));
			this.entityentrySubdivision.Name = "entityentrySubdivision";
			this.table1.Add(this.entityentrySubdivision);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.entityentrySubdivision]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Дата составления:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Материально ответсвенное лицо:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Руководитель подразделения:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabel2 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel2.Name = "ylabel2";
			this.ylabel2.Xalign = 1F;
			this.ylabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Организация:");
			this.table1.Add(this.ylabel2);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabel2]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabel3 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel3.Name = "ylabel3";
			this.ylabel3.Xalign = 1F;
			this.ylabel3.LabelProp = global::Mono.Unix.Catalog.GetString("Подразделение:");
			this.table1.Add(this.ylabel3);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabel3]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Спецодежда:</b>");
			this.label4.UseMarkup = true;
			this.hbox7.Add(this.label4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label4]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.hboxExpense = new global::Gtk.HBox();
			this.hboxExpense.Name = "hboxExpense";
			this.hboxExpense.Spacing = 6;
			// Container child hboxExpense.Gtk.Box+BoxChild
			this.labelExpense = new global::Gtk.Label();
			this.labelExpense.Name = "labelExpense";
			this.labelExpense.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
			this.hboxExpense.Add(this.labelExpense);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hboxExpense[this.labelExpense]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hboxExpense.Gtk.Box+BoxChild
			this.buttonExpenseOpen = new global::Gtk.Button();
			this.buttonExpenseOpen.CanFocus = true;
			this.buttonExpenseOpen.Name = "buttonExpenseOpen";
			this.buttonExpenseOpen.UseUnderline = true;
			this.buttonExpenseOpen.Label = global::Mono.Unix.Catalog.GetString("Открыть выдачу");
			global::Gtk.Image w22 = new global::Gtk.Image();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.buttonExpenseOpen.Image = w22;
			this.hboxExpense.Add(this.buttonExpenseOpen);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hboxExpense[this.buttonExpenseOpen]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.hbox7.Add(this.hboxExpense);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hboxExpense]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonCloseFillBy = new global::Gamma.GtkWidgets.yButton();
			this.buttonCloseFillBy.CanFocus = true;
			this.buttonCloseFillBy.Name = "buttonCloseFillBy";
			this.buttonCloseFillBy.UseStock = true;
			this.buttonCloseFillBy.UseUnderline = true;
			this.buttonCloseFillBy.Label = "gtk-close";
			this.hbox7.Add(this.buttonCloseFillBy);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonCloseFillBy]));
			w25.PackType = ((global::Gtk.PackType)(1));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonFillBy = new global::Gtk.Button();
			this.buttonFillBy.CanFocus = true;
			this.buttonFillBy.Name = "buttonFillBy";
			this.buttonFillBy.UseUnderline = true;
			this.buttonFillBy.Label = global::Mono.Unix.Catalog.GetString("Заполнить...");
			global::Gtk.Image w26 = new global::Gtk.Image();
			w26.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-down", global::Gtk.IconSize.Menu);
			this.buttonFillBy.Image = w26;
			this.hbox7.Add(this.buttonFillBy);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonFillBy]));
			w27.PackType = ((global::Gtk.PackType)(1));
			w27.Position = 3;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox2.Add(this.hbox7);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox7]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hboxTable = new global::Gtk.HBox();
			this.hboxTable.Name = "hboxTable";
			this.hboxTable.Spacing = 6;
			// Container child hboxTable.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewItems = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewItems.CanFocus = true;
			this.ytreeviewItems.Name = "ytreeviewItems";
			this.GtkScrolledWindow.Add(this.ytreeviewItems);
			this.hboxTable.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hboxTable[this.GtkScrolledWindow]));
			w30.Position = 0;
			this.vbox2.Add(this.hboxTable);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hboxTable]));
			w31.Position = 3;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button();
			this.buttonAdd.TooltipMarkup = "Добавить услугу из начисления";
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			global::Gtk.Image w32 = new global::Gtk.Image();
			w32.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAdd.Image = w32;
			this.hbox8.Add(this.buttonAdd);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonAdd]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonDel = new global::Gtk.Button();
			this.buttonDel.Sensitive = false;
			this.buttonDel.CanFocus = true;
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.UseUnderline = true;
			this.buttonDel.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w34 = new global::Gtk.Image();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-remove", global::Gtk.IconSize.Menu);
			this.buttonDel.Image = w34;
			this.hbox8.Add(this.buttonDel);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonDel]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox8.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator1]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonSetEmployee = new global::Gtk.Button();
			this.buttonSetEmployee.CanFocus = true;
			this.buttonSetEmployee.Name = "buttonSetEmployee";
			this.buttonSetEmployee.UseUnderline = true;
			this.buttonSetEmployee.Label = global::Mono.Unix.Catalog.GetString("Изменить сотрудника");
			this.hbox8.Add(this.buttonSetEmployee);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.buttonSetEmployee]));
			w37.Position = 3;
			w37.Expand = false;
			w37.Fill = false;
			this.vbox2.Add(this.hbox8);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox8]));
			w38.Position = 4;
			w38.Expand = false;
			w38.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonPrint.Clicked += new global::System.EventHandler(this.OnButtonPrintClicked);
			this.buttonExpenseOpen.Clicked += new global::System.EventHandler(this.OnButtonExpenseOpenClicked);
			this.buttonFillBy.Clicked += new global::System.EventHandler(this.OnButtonFillByExpenseClicked);
			this.buttonCloseFillBy.Clicked += new global::System.EventHandler(this.OnButtonCloseFillByClicked);
			this.ytreeviewItems.RowActivated += new global::Gtk.RowActivatedHandler(this.OnYtreeviewItemsRowActivated);
			this.buttonAdd.Clicked += new global::System.EventHandler(this.OnButtonAddClicked);
			this.buttonDel.Clicked += new global::System.EventHandler(this.OnButtonDelClicked);
			this.buttonSetEmployee.Clicked += new global::System.EventHandler(this.OnButtonSetEmployeeClicked);
		}
	}
}

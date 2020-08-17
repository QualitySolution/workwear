
namespace workwear.Views.Company
{
	public partial class EmployeeView
	{
		private Gtk.VBox dialog1_VBox;

		private Gtk.HBox hbox4;

		private Gtk.Button buttonSave;

		private Gtk.Button buttonCancel;

		private Gtk.VSeparator vseparator1;

		private QSOrmProject.EnumMenuButton enumPrint;

		private Gtk.HBox hbox1;

		private Gtk.Table table1;

		private Gamma.GtkWidgets.yEntry yentryPersonnelNumber;

		private Gamma.Widgets.yEnumComboBox ycomboWinterShoesStd;

		private Gamma.GtkWidgets.yComboBox ycomboWinterShoesSize;

		private Gamma.Widgets.yEnumComboBox ycomboWearStd;

		private Gamma.GtkWidgets.yComboBox ycomboWearSize;

		private global::QS.Views.Control.EntityEntry entityPost;

		private Gamma.GtkWidgets.yComboBox ycomboShoesSize;

		private Gamma.GtkWidgets.yComboBox ycomboMittensSize;

		private Gamma.Widgets.yEnumComboBox ycomboHeaddressStd;

		private Gamma.GtkWidgets.yComboBox ycomboHeaddressSize;

		private Gamma.Widgets.yEnumComboBox ycomboGlovesStd;

		private Gamma.GtkWidgets.yComboBox ycomboGlovesSize;

		private Gamma.GtkWidgets.yLabel labelUser;

		private Gtk.Label label9;

		private Gtk.Label label8;

		private Gtk.Label label7;

		private Gtk.Label label6;

		private global::Gtk.Label label12;

		private Gtk.Label label3;

		private Gtk.Label label27;

		private Gtk.Label label26;

		private Gtk.Label label25;

		private Gtk.Label label24;

		private Gtk.Label label23;

		private Gtk.Label label20;

		private Gtk.Label label2;

		private Gtk.Label label19;

		private Gtk.Label label18;

		private Gtk.Label label17;

		private Gtk.Label label16;

		private Gtk.Label label14;

		private Gtk.Label label12;

		private Gtk.Label label11;

		private Gtk.Label label10;

		private Gtk.Label label1;

		private Gtk.HBox hbox7;

		private Gamma.GtkWidgets.yEntry entryId;

		private global::Gamma.GtkWidgets.yLabel labelHRInfo;

		private global::Gamma.GtkWidgets.yLabel labelUser;

		private Gtk.ScrolledWindow GtkScrolledWindowComments;

		private Gamma.GtkWidgets.yTextView ytextComment;

		private Gamma.GtkWidgets.yEntry entryPatronymic;

		private Gamma.GtkWidgets.yEntry entryLastName;

		private Gamma.GtkWidgets.yEntry entryFirstName;

		private QS.Views.Control.EntityEntry entitySubdivision;

		private QS.Views.Control.EntityEntry entityPost;

		private QS.Views.Control.EntityEntry entityLeader;

		private QS.Views.Control.EntityEntry entityDepartment;

		private QS.Widgets.GtkUI.DatePicker dateHire;

		private QS.Widgets.GtkUI.DatePicker dateDismiss;

		private QS.Widgets.GtkUI.DatePicker dateChangePosition;

		private Gamma.Widgets.yEnumComboBox comboSex;

		private Gtk.VBox vbox2;

		private Gtk.Frame frame1;

		private Gamma.Widgets.yImageViewer yimagePhoto;

		private Gtk.HBox hbox11;

		private Gtk.Button buttonLoadPhoto;

		private Gtk.Button buttonSavePhoto;

		private Gtk.Notebook notebook1;

		private workwear.Views.Company.EmployeeChilds.EmployeeNormsView employeenormsview1;

		private Gtk.Label label13;

		private workwear.Views.Company.EmployeeChilds.EmployeeWearItemsView employeewearitemsview1;

		private Gtk.Label label15;

		private Gtk.VBox vbox4;

		private workwear.Views.Company.EmployeeChilds.EmployeeListedItemsView employeecardlisteditemsview;

		private Gtk.Label label21;

		private Gtk.VBox vbox3;

		private workwear.Views.Company.EmployeeChilds.EmployeeMovementsView employeemovementsview1;

		private Gtk.Label label22;

		private workwear.Views.Company.EmployeeChilds.EmployeeVacationsView employeevacationsview1;

		private Gtk.Label label28;

		private void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.Views.Company.EmployeeView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.Views.Company.EmployeeView";
			// Container child workwear.Views.Company.EmployeeView.Gtk.Container+ContainerChild
			this.dialog1_VBox = new global::Gtk.VBox();
			this.dialog1_VBox.Name = "dialog1_VBox";
			this.dialog1_VBox.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
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
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox4.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator1]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.enumPrint = new global::QSOrmProject.EnumMenuButton();
			this.enumPrint.Sensitive = false;
			this.enumPrint.CanFocus = true;
			this.enumPrint.Name = "enumPrint";
			this.enumPrint.UseUnderline = true;
			this.enumPrint.UseMarkup = false;
			this.enumPrint.LabelXAlign = 0F;
			this.enumPrint.Label = global::Mono.Unix.Catalog.GetString("Печать");
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.enumPrint.Image = w6;
			this.hbox4.Add(this.enumPrint);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.enumPrint]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			this.dialog1_VBox.Add(this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.hbox4]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(9)), ((uint)(7)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboSex = new global::Gamma.Widgets.yEnumComboBox();
			this.comboSex.Name = "comboSex";
			this.comboSex.ShowSpecialStateAll = false;
			this.comboSex.ShowSpecialStateNot = false;
			this.comboSex.UseShortTitle = false;
			this.comboSex.DefaultFirst = false;
			this.table1.Add(this.comboSex);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.comboSex]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(5));
			w9.RightAttach = ((uint)(7));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateChangePosition = new global::QS.Widgets.GtkUI.DatePicker();
			this.dateChangePosition.TooltipMarkup = "Дата изменения профессии (должности) или переводе в другое структурное подразделе" +
				"ние";
			this.dateChangePosition.Sensitive = false;
			this.dateChangePosition.Events = ((global::Gdk.EventMask)(256));
			this.dateChangePosition.Name = "dateChangePosition";
			this.dateChangePosition.WithTime = false;
			this.dateChangePosition.HideCalendarButton = false;
			this.dateChangePosition.Date = new global::System.DateTime(0);
			this.dateChangePosition.IsEditable = true;
			this.dateChangePosition.AutoSeparation = true;
			this.table1.Add(this.dateChangePosition);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.dateChangePosition]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.LeftAttach = ((uint)(3));
			w10.RightAttach = ((uint)(4));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateDismiss = new global::QS.Widgets.GtkUI.DatePicker();
			this.dateDismiss.Sensitive = false;
			this.dateDismiss.Events = ((global::Gdk.EventMask)(256));
			this.dateDismiss.Name = "dateDismiss";
			this.dateDismiss.WithTime = false;
			this.dateDismiss.HideCalendarButton = false;
			this.dateDismiss.Date = new global::System.DateTime(0);
			this.dateDismiss.IsEditable = true;
			this.dateDismiss.AutoSeparation = true;
			this.table1.Add(this.dateDismiss);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.dateDismiss]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateHire = new global::QS.Widgets.GtkUI.DatePicker();
			this.dateHire.Sensitive = false;
			this.dateHire.Events = ((global::Gdk.EventMask)(256));
			this.dateHire.Name = "dateHire";
			this.dateHire.WithTime = false;
			this.dateHire.HideCalendarButton = false;
			this.dateHire.Date = new global::System.DateTime(0);
			this.dateHire.IsEditable = true;
			this.dateHire.AutoSeparation = true;
			this.table1.Add(this.dateHire);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.dateHire]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(3));
			w12.RightAttach = ((uint)(4));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityDepartment = new global::QS.Views.Control.EntityEntry();
			this.entityDepartment.Events = ((global::Gdk.EventMask)(256));
			this.entityDepartment.Name = "entityDepartment";
			this.table1.Add(this.entityDepartment);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.entityDepartment]));
			w13.TopAttach = ((uint)(5));
			w13.BottomAttach = ((uint)(6));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityPost = new global::QS.Views.Control.EntityEntry();
			this.entityPost.Events = ((global::Gdk.EventMask)(256));
			this.entityPost.Name = "entityPost";
			this.table1.Add(this.entityPost);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.entityPost]));
			w14.TopAttach = ((uint)(6));
			w14.BottomAttach = ((uint)(7));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entitySubdivision = new global::QS.Views.Control.EntityEntry();
			this.entitySubdivision.Events = ((global::Gdk.EventMask)(256));
			this.entitySubdivision.Name = "entitySubdivision";
			this.table1.Add(this.entitySubdivision);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.entitySubdivision]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryFirstName = new global::Gamma.GtkWidgets.yEntry();
			this.entryFirstName.CanFocus = true;
			this.entryFirstName.Name = "entryFirstName";
			this.entryFirstName.IsEditable = true;
			this.entryFirstName.MaxLength = 20;
			this.entryFirstName.InvisibleChar = '●';
			this.table1.Add(this.entryFirstName);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.entryFirstName]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryLastName = new global::Gamma.GtkWidgets.yEntry();
			this.entryLastName.CanFocus = true;
			this.entryLastName.Name = "entryLastName";
			this.entryLastName.IsEditable = true;
			this.entryLastName.MaxLength = 20;
			this.entryLastName.InvisibleChar = '●';
			this.table1.Add(this.entryLastName);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.entryLastName]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPatronymic = new global::Gamma.GtkWidgets.yEntry();
			this.entryPatronymic.CanFocus = true;
			this.entryPatronymic.Name = "entryPatronymic";
			this.entryPatronymic.IsEditable = true;
			this.entryPatronymic.MaxLength = 20;
			this.entryPatronymic.InvisibleChar = '●';
			this.table1.Add(this.entryPatronymic);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.entryPatronymic]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindowComments = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindowComments.Name = "GtkScrolledWindowComments";
			this.GtkScrolledWindowComments.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindowComments.Gtk.Container+ContainerChild
			this.ytextComment = new global::Gamma.GtkWidgets.yTextView();
			this.ytextComment.CanFocus = true;
			this.ytextComment.Name = "ytextComment";
			this.ytextComment.AcceptsTab = false;
			this.ytextComment.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindowComments.Add(this.ytextComment);
			this.table1.Add(this.GtkScrolledWindowComments);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindowComments]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(9));
			w20.LeftAttach = ((uint)(3));
			w20.RightAttach = ((uint)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entryId = new global::Gamma.GtkWidgets.yEntry();
			this.entryId.Sensitive = false;
			this.entryId.CanFocus = true;
			this.entryId.Name = "entryId";
			this.entryId.Text = global::Mono.Unix.Catalog.GetString("авто");
			this.entryId.IsEditable = true;
			this.entryId.WidthChars = 10;
			this.entryId.MaxLength = 15;
			this.entryId.InvisibleChar = '●';
			this.hbox7.Add(this.entryId);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.entryId]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.checkAuto = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkAuto.Sensitive = false;
			this.checkAuto.CanFocus = true;
			this.checkAuto.Name = "checkAuto";
			this.checkAuto.Label = global::Mono.Unix.Catalog.GetString("Автоматически");
			this.checkAuto.Active = true;
			this.checkAuto.DrawIndicator = true;
			this.checkAuto.UseUnderline = true;
			this.hbox7.Add(this.checkAuto);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.checkAuto]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.table1.Add(this.hbox7);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox7]));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Номер карточки:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Должность:");
			this.table1.Add(this.label10);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w25.TopAttach = ((uint)(6));
			w25.BottomAttach = ((uint)(7));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Подразделение:");
			this.table1.Add(this.label12);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.label12]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.Xalign = 1F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Отдел:");
			this.table1.Add(this.label14);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.label14]));
			w27.TopAttach = ((uint)(5));
			w27.BottomAttach = ((uint)(6));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Характеристики одежды</b>");
			this.label16.UseMarkup = true;
			this.table1.Add(this.label16);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1[this.label16]));
			w28.LeftAttach = ((uint)(4));
			w28.RightAttach = ((uint)(7));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.Xalign = 1F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("Карточку создал:");
			this.table1.Add(this.label17);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1[this.label17]));
			w29.LeftAttach = ((uint)(2));
			w29.RightAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.Xalign = 1F;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Размер обуви:");
			this.table1.Add(this.label18);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1[this.label18]));
			w30.TopAttach = ((uint)(4));
			w30.BottomAttach = ((uint)(5));
			w30.LeftAttach = ((uint)(4));
			w30.RightAttach = ((uint)(5));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.Xalign = 1F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Размер головного убора:");
			this.table1.Add(this.label19);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1[this.label19]));
			w31.TopAttach = ((uint)(6));
			w31.BottomAttach = ((uint)(7));
			w31.LeftAttach = ((uint)(4));
			w31.RightAttach = ((uint)(5));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Фамилия:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.Xalign = 1F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("Размер перчаток:");
			this.table1.Add(this.label20);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1[this.label20]));
			w33.TopAttach = ((uint)(7));
			w33.BottomAttach = ((uint)(8));
			w33.LeftAttach = ((uint)(4));
			w33.RightAttach = ((uint)(5));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label23 = new global::Gtk.Label();
			this.label23.Name = "label23";
			this.label23.Xalign = 1F;
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString("Табельный номер:");
			this.table1.Add(this.label23);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1[this.label23]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.LeftAttach = ((uint)(2));
			w34.RightAttach = ((uint)(3));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label24 = new global::Gtk.Label();
			this.label24.Name = "label24";
			this.label24.Xalign = 1F;
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString("Размер зимней обуви:");
			this.table1.Add(this.label24);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1[this.label24]));
			w35.TopAttach = ((uint)(5));
			w35.BottomAttach = ((uint)(6));
			w35.LeftAttach = ((uint)(4));
			w35.RightAttach = ((uint)(5));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label25 = new global::Gtk.Label();
			this.label25.Name = "label25";
			this.label25.Xalign = 1F;
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString("Размер рукавиц:");
			this.table1.Add(this.label25);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1[this.label25]));
			w36.TopAttach = ((uint)(8));
			w36.BottomAttach = ((uint)(9));
			w36.LeftAttach = ((uint)(4));
			w36.RightAttach = ((uint)(5));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label26 = new global::Gtk.Label();
			this.label26.Name = "label26";
			this.label26.Xalign = 1F;
			this.label26.Yalign = 0F;
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарий:");
			this.table1.Add(this.label26);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table1[this.label26]));
			w37.TopAttach = ((uint)(5));
			w37.BottomAttach = ((uint)(8));
			w37.LeftAttach = ((uint)(2));
			w37.RightAttach = ((uint)(3));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label27 = new global::Gtk.Label();
			this.label27.Name = "label27";
			this.label27.LabelProp = global::Mono.Unix.Catalog.GetString("Дата изменения должности:");
			this.table1.Add(this.label27);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1[this.label27]));
			w38.TopAttach = ((uint)(3));
			w38.BottomAttach = ((uint)(4));
			w38.LeftAttach = ((uint)(2));
			w38.RightAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Имя:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w39.TopAttach = ((uint)(2));
			w39.BottomAttach = ((uint)(3));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Отчество:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w40.TopAttach = ((uint)(3));
			w40.BottomAttach = ((uint)(4));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Дата поступления:");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w41.TopAttach = ((uint)(2));
			w41.BottomAttach = ((uint)(3));
			w41.LeftAttach = ((uint)(2));
			w41.RightAttach = ((uint)(3));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Дата увольнения:");
			this.table1.Add(this.label6);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w42.TopAttach = ((uint)(4));
			w42.BottomAttach = ((uint)(5));
			w42.LeftAttach = ((uint)(2));
			w42.RightAttach = ((uint)(3));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Пол:");
			this.table1.Add(this.label7);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w43.TopAttach = ((uint)(1));
			w43.BottomAttach = ((uint)(2));
			w43.LeftAttach = ((uint)(4));
			w43.RightAttach = ((uint)(5));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Рост:");
			this.table1.Add(this.label8);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w44.TopAttach = ((uint)(2));
			w44.BottomAttach = ((uint)(3));
			w44.LeftAttach = ((uint)(4));
			w44.RightAttach = ((uint)(5));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Размер одежды:");
			this.table1.Add(this.label9);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1[this.label9]));
			w45.TopAttach = ((uint)(3));
			w45.BottomAttach = ((uint)(4));
			w45.LeftAttach = ((uint)(4));
			w45.RightAttach = ((uint)(5));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelHRInfo = new global::Gamma.GtkWidgets.yLabel();
			this.labelHRInfo.Name = "labelHRInfo";
			this.labelHRInfo.Xalign = 0F;
			this.labelHRInfo.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel1");
			this.labelHRInfo.Selectable = true;
			this.table1.Add(this.labelHRInfo);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table1[this.labelHRInfo]));
			w46.TopAttach = ((uint)(7));
			w46.BottomAttach = ((uint)(9));
			w46.LeftAttach = ((uint)(1));
			w46.RightAttach = ((uint)(2));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelUser = new global::Gamma.GtkWidgets.yLabel();
			this.labelUser.Name = "labelUser";
			this.labelUser.LabelProp = global::Mono.Unix.Catalog.GetString("не указан");
			this.table1.Add(this.labelUser);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table1[this.labelUser]));
			w47.LeftAttach = ((uint)(3));
			w47.RightAttach = ((uint)(4));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboGlovesSize = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboGlovesSize.Name = "ycomboGlovesSize";
			this.table1.Add(this.ycomboGlovesSize);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboGlovesSize]));
			w48.TopAttach = ((uint)(7));
			w48.BottomAttach = ((uint)(8));
			w48.LeftAttach = ((uint)(6));
			w48.RightAttach = ((uint)(7));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboGlovesStd = new global::Gamma.Widgets.yEnumComboBox();
			this.ycomboGlovesStd.Name = "ycomboGlovesStd";
			this.ycomboGlovesStd.ShowSpecialStateAll = false;
			this.ycomboGlovesStd.ShowSpecialStateNot = false;
			this.ycomboGlovesStd.UseShortTitle = true;
			this.ycomboGlovesStd.DefaultFirst = false;
			this.table1.Add(this.ycomboGlovesStd);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboGlovesStd]));
			w49.TopAttach = ((uint)(7));
			w49.BottomAttach = ((uint)(8));
			w49.LeftAttach = ((uint)(5));
			w49.RightAttach = ((uint)(6));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboHeaddressSize = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboHeaddressSize.Name = "ycomboHeaddressSize";
			this.table1.Add(this.ycomboHeaddressSize);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboHeaddressSize]));
			w50.TopAttach = ((uint)(6));
			w50.BottomAttach = ((uint)(7));
			w50.LeftAttach = ((uint)(6));
			w50.RightAttach = ((uint)(7));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboHeaddressStd = new global::Gamma.Widgets.yEnumComboBox();
			this.ycomboHeaddressStd.Name = "ycomboHeaddressStd";
			this.ycomboHeaddressStd.ShowSpecialStateAll = false;
			this.ycomboHeaddressStd.ShowSpecialStateNot = false;
			this.ycomboHeaddressStd.UseShortTitle = true;
			this.ycomboHeaddressStd.DefaultFirst = false;
			this.table1.Add(this.ycomboHeaddressStd);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboHeaddressStd]));
			w51.TopAttach = ((uint)(6));
			w51.BottomAttach = ((uint)(7));
			w51.LeftAttach = ((uint)(5));
			w51.RightAttach = ((uint)(6));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboMittensSize = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboMittensSize.Name = "ycomboMittensSize";
			this.table1.Add(this.ycomboMittensSize);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboMittensSize]));
			w52.TopAttach = ((uint)(8));
			w52.BottomAttach = ((uint)(9));
			w52.LeftAttach = ((uint)(6));
			w52.RightAttach = ((uint)(7));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboShoesSize = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboShoesSize.Name = "ycomboShoesSize";
			this.table1.Add(this.ycomboShoesSize);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboShoesSize]));
			w53.TopAttach = ((uint)(4));
			w53.BottomAttach = ((uint)(5));
			w53.LeftAttach = ((uint)(6));
			w53.RightAttach = ((uint)(7));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboShoesStd = new global::Gamma.Widgets.yEnumComboBox();
			this.ycomboShoesStd.Name = "ycomboShoesStd";
			this.ycomboShoesStd.ShowSpecialStateAll = false;
			this.ycomboShoesStd.ShowSpecialStateNot = false;
			this.ycomboShoesStd.UseShortTitle = true;
			this.ycomboShoesStd.DefaultFirst = false;
			this.table1.Add(this.ycomboShoesStd);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboShoesStd]));
			w54.TopAttach = ((uint)(4));
			w54.BottomAttach = ((uint)(5));
			w54.LeftAttach = ((uint)(5));
			w54.RightAttach = ((uint)(6));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboWearGrowth = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboWearGrowth.Name = "ycomboWearGrowth";
			this.table1.Add(this.ycomboWearGrowth);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboWearGrowth]));
			w55.TopAttach = ((uint)(2));
			w55.BottomAttach = ((uint)(3));
			w55.LeftAttach = ((uint)(5));
			w55.RightAttach = ((uint)(7));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboWearSize = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboWearSize.Name = "ycomboWearSize";
			this.table1.Add(this.ycomboWearSize);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboWearSize]));
			w56.TopAttach = ((uint)(3));
			w56.BottomAttach = ((uint)(4));
			w56.LeftAttach = ((uint)(6));
			w56.RightAttach = ((uint)(7));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboWearStd = new global::Gamma.Widgets.yEnumComboBox();
			this.ycomboWearStd.Name = "ycomboWearStd";
			this.ycomboWearStd.ShowSpecialStateAll = false;
			this.ycomboWearStd.ShowSpecialStateNot = false;
			this.ycomboWearStd.UseShortTitle = true;
			this.ycomboWearStd.DefaultFirst = false;
			this.table1.Add(this.ycomboWearStd);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboWearStd]));
			w57.TopAttach = ((uint)(3));
			w57.BottomAttach = ((uint)(4));
			w57.LeftAttach = ((uint)(5));
			w57.RightAttach = ((uint)(6));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboWinterShoesSize = new global::Gamma.GtkWidgets.yComboBox();
			this.ycomboWinterShoesSize.Name = "ycomboWinterShoesSize";
			this.table1.Add(this.ycomboWinterShoesSize);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboWinterShoesSize]));
			w58.TopAttach = ((uint)(5));
			w58.BottomAttach = ((uint)(6));
			w58.LeftAttach = ((uint)(6));
			w58.RightAttach = ((uint)(7));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycomboWinterShoesStd = new global::Gamma.Widgets.yEnumComboBox();
			this.ycomboWinterShoesStd.Name = "ycomboWinterShoesStd";
			this.ycomboWinterShoesStd.ShowSpecialStateAll = false;
			this.ycomboWinterShoesStd.ShowSpecialStateNot = false;
			this.ycomboWinterShoesStd.UseShortTitle = true;
			this.ycomboWinterShoesStd.DefaultFirst = false;
			this.table1.Add(this.ycomboWinterShoesStd);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table1[this.ycomboWinterShoesStd]));
			w59.TopAttach = ((uint)(5));
			w59.BottomAttach = ((uint)(6));
			w59.LeftAttach = ((uint)(5));
			w59.RightAttach = ((uint)(6));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryPersonnelNumber = new global::Gamma.GtkWidgets.yEntry();
			this.yentryPersonnelNumber.Sensitive = false;
			this.yentryPersonnelNumber.CanFocus = true;
			this.yentryPersonnelNumber.Name = "yentryPersonnelNumber";
			this.yentryPersonnelNumber.IsEditable = false;
			this.yentryPersonnelNumber.MaxLength = 15;
			this.yentryPersonnelNumber.InvisibleChar = '●';
			this.table1.Add(this.yentryPersonnelNumber);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryPersonnelNumber]));
			w60.TopAttach = ((uint)(1));
			w60.BottomAttach = ((uint)(2));
			w60.LeftAttach = ((uint)(3));
			w60.RightAttach = ((uint)(4));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w61.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.yimagePhoto = new global::Gamma.Widgets.yImageViewer();
			this.yimagePhoto.Name = "yimagePhoto";
			this.yimagePhoto.VerticalFit = true;
			this.yimagePhoto.HorizontalFit = true;
			this.frame1.Add(this.yimagePhoto);
			this.vbox2.Add(this.frame1);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
			w63.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.buttonLoadPhoto = new global::Gtk.Button();
			this.buttonLoadPhoto.TooltipMarkup = "Загрузить фотографию с диска на компьютере.";
			this.buttonLoadPhoto.CanFocus = true;
			this.buttonLoadPhoto.Name = "buttonLoadPhoto";
			this.buttonLoadPhoto.UseUnderline = true;
			this.buttonLoadPhoto.Label = global::Mono.Unix.Catalog.GetString("Загрузить");
			global::Gtk.Image w64 = new global::Gtk.Image();
			w64.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-open", global::Gtk.IconSize.Menu);
			this.buttonLoadPhoto.Image = w64;
			this.hbox11.Add(this.buttonLoadPhoto);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.buttonLoadPhoto]));
			w65.Position = 0;
			w65.Expand = false;
			w65.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.buttonSavePhoto = new global::Gtk.Button();
			this.buttonSavePhoto.TooltipMarkup = "Сохранить фотографию на диск.";
			this.buttonSavePhoto.Sensitive = false;
			this.buttonSavePhoto.CanFocus = true;
			this.buttonSavePhoto.Name = "buttonSavePhoto";
			this.buttonSavePhoto.UseUnderline = true;
			this.buttonSavePhoto.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w66 = new global::Gtk.Image();
			w66.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSavePhoto.Image = w66;
			this.hbox11.Add(this.buttonSavePhoto);
			global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.buttonSavePhoto]));
			w67.Position = 1;
			w67.Expand = false;
			w67.Fill = false;
			this.vbox2.Add(this.hbox11);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox11]));
			w68.Position = 1;
			w68.Expand = false;
			w68.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w69.Position = 1;
			w69.Expand = false;
			w69.Fill = false;
			this.dialog1_VBox.Add(this.hbox1);
			global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.hbox1]));
			w70.Position = 1;
			w70.Expand = false;
			w70.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.employeenormsview1 = new global::workwear.Views.Company.EmployeeChilds.EmployeeNormsView();
			this.employeenormsview1.Events = ((global::Gdk.EventMask)(256));
			this.employeenormsview1.Name = "employeenormsview1";
			this.notebook1.Add(this.employeenormsview1);
			// Notebook tab
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Применённые нормы");
			this.notebook1.SetTabLabel(this.employeenormsview1, this.label13);
			this.label13.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.employeewearitemsview1 = new global::workwear.Views.Company.EmployeeChilds.EmployeeWearItemsView();
			this.employeewearitemsview1.Events = ((global::Gdk.EventMask)(256));
			this.employeewearitemsview1.Name = "employeewearitemsview1";
			this.notebook1.Add(this.employeewearitemsview1);
			global::Gtk.Notebook.NotebookChild w72 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.employeewearitemsview1]));
			w72.Position = 1;
			// Notebook tab
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Спецодежда по нормам");
			this.notebook1.SetTabLabel(this.employeewearitemsview1, this.label15);
			this.label15.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.employeecardlisteditemsview = new global::workwear.Views.Company.EmployeeChilds.EmployeeListedItemsView();
			this.employeecardlisteditemsview.Events = ((global::Gdk.EventMask)(256));
			this.employeecardlisteditemsview.Name = "employeecardlisteditemsview";
			this.vbox4.Add(this.employeecardlisteditemsview);
			global::Gtk.Box.BoxChild w73 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.employeecardlisteditemsview]));
			w73.Position = 0;
			this.notebook1.Add(this.vbox4);
			global::Gtk.Notebook.NotebookChild w74 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox4]));
			w74.Position = 2;
			// Notebook tab
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("Числится за сотрудником");
			this.notebook1.SetTabLabel(this.vbox4, this.label21);
			this.label21.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.employeemovementsview1 = new global::workwear.Views.Company.EmployeeChilds.EmployeeMovementsView();
			this.employeemovementsview1.Events = ((global::Gdk.EventMask)(256));
			this.employeemovementsview1.Name = "employeemovementsview1";
			this.vbox3.Add(this.employeemovementsview1);
			global::Gtk.Box.BoxChild w75 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.employeemovementsview1]));
			w75.Position = 0;
			this.notebook1.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w76 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox3]));
			w76.Position = 3;
			// Notebook tab
			this.label22 = new global::Gtk.Label();
			this.label22.Name = "label22";
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString("История выдач");
			this.notebook1.SetTabLabel(this.vbox3, this.label22);
			this.label22.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.employeevacationsview1 = new global::workwear.Views.Company.EmployeeChilds.EmployeeVacationsView();
			this.employeevacationsview1.Events = ((global::Gdk.EventMask)(256));
			this.employeevacationsview1.Name = "employeevacationsview1";
			this.notebook1.Add(this.employeevacationsview1);
			global::Gtk.Notebook.NotebookChild w77 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.employeevacationsview1]));
			w77.Position = 4;
			// Notebook tab
			this.label28 = new global::Gtk.Label();
			this.label28.Name = "label28";
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString("Отпуска");
			this.notebook1.SetTabLabel(this.employeevacationsview1, this.label28);
			this.label28.ShowAll();
			this.dialog1_VBox.Add(this.notebook1);
			global::Gtk.Box.BoxChild w78 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.notebook1]));
			w78.Position = 2;
			this.Add(this.dialog1_VBox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.yimagePhoto.Hide();
			this.buttonLoadPhoto.Hide();
			this.buttonSavePhoto.Hide();
			this.employeevacationsview1.Hide();
			this.Show();
			this.enumPrint.EnumItemClicked += new global::System.EventHandler<QSOrmProject.EnumItemClickedEventArgs>(this.OnEnumPrintEnumItemClicked);
			this.ycomboWinterShoesStd.Changed += new global::System.EventHandler(this.OnYcomboWinterShoesStdChanged);
			this.ycomboWearStd.Changed += new global::System.EventHandler(this.OnYcomboWearStdChanged);
			this.ycomboShoesStd.Changed += new global::System.EventHandler(this.OnYcomboShoesStdChanged);
			this.ycomboHeaddressStd.Changed += new global::System.EventHandler(this.OnYcomboHeaddressChanged);
			this.ycomboGlovesStd.Changed += new global::System.EventHandler(this.OnYcomboGlovesStdChanged);
			this.comboSex.Changed += new global::System.EventHandler(this.OnComboSexChanged);
			this.yimagePhoto.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.OnYimagePhotoButtonPressEvent);
			this.buttonLoadPhoto.Clicked += new global::System.EventHandler(this.OnButtonLoadPhotoClicked);
			this.buttonSavePhoto.Clicked += new global::System.EventHandler(this.OnButtonSavePhotoClicked);
			this.notebook1.SwitchPage += new global::Gtk.SwitchPageHandler(this.OnNotebook1SwitchPage);
		}
	}
}

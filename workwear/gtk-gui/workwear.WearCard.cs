
// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class WearCard
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBoxEntry comboentryWearSize;
		private global::Gtk.ComboBox comboPost;
		private global::Gtk.ComboBox comboSex;
		private global::QSWidgetLib.DatePicker dateDismiss;
		private global::QSWidgetLib.DatePicker dateHire;
		private global::Gtk.Entry entryFirstName;
		private global::Gtk.Entry entryLastName;
		private global::Gtk.Entry entryPatronymic;
		private global::Gtk.HBox hboxLeader;
		private global::Gtk.Entry entryLeader;
		private global::Gtk.Button buttonLeaderClear;
		private global::Gtk.Button buttonLeader;
		private global::Gtk.HBox hboxObject;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label labelObjectName;
		private global::Gtk.Label labelObjectAddress;
		private global::Gtk.Button buttonObjectClear;
		private global::Gtk.Button buttonObject;
		private global::Gtk.Label label1;
		private global::Gtk.Label label10;
		private global::Gtk.Label label11;
		private global::Gtk.Label label12;
		private global::Gtk.Label label17;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.Label labelId;
		private global::Gtk.Label labelUser;
		private global::Gtk.SpinButton spinGrowth;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Frame frame1;
		private global::Gtk.Image imagePhoto;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Button buttonLoadPhoto;
		private global::Gtk.Button buttonSavePhoto;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label label13;
		private global::Gtk.CheckButton checkShowHistory;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewWear;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Button buttonGiveWear;
		private global::Gtk.Button buttonReturnWear;
		private global::Gtk.Button buttonWriteOffWear;
		private global::Gtk.Button buttonPrint;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget workwear.WearCard
			this.Name = "workwear.WearCard";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child workwear.WearCard.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboentryWearSize = global::Gtk.ComboBoxEntry.NewText ();
			this.comboentryWearSize.WidthRequest = 5;
			this.comboentryWearSize.Name = "comboentryWearSize";
			this.table1.Add (this.comboentryWearSize);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboentryWearSize]));
			w2.TopAttach = ((uint)(5));
			w2.BottomAttach = ((uint)(6));
			w2.LeftAttach = ((uint)(3));
			w2.RightAttach = ((uint)(4));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboPost = global::Gtk.ComboBox.NewText ();
			this.comboPost.Name = "comboPost";
			this.table1.Add (this.comboPost);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboPost]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboSex = global::Gtk.ComboBox.NewText ();
			this.comboSex.AppendText (global::Mono.Unix.Catalog.GetString ("Мужской"));
			this.comboSex.AppendText (global::Mono.Unix.Catalog.GetString ("Женский"));
			this.comboSex.Name = "comboSex";
			this.table1.Add (this.comboSex);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboSex]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(3));
			w4.RightAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateDismiss = new global::QSWidgetLib.DatePicker ();
			this.dateDismiss.Events = ((global::Gdk.EventMask)(256));
			this.dateDismiss.Name = "dateDismiss";
			this.dateDismiss.Date = new global::System.DateTime (0);
			this.dateDismiss.IsEditable = true;
			this.dateDismiss.AutoSeparation = true;
			this.table1.Add (this.dateDismiss);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.dateDismiss]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(3));
			w5.RightAttach = ((uint)(4));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateHire = new global::QSWidgetLib.DatePicker ();
			this.dateHire.Events = ((global::Gdk.EventMask)(256));
			this.dateHire.Name = "dateHire";
			this.dateHire.Date = new global::System.DateTime (0);
			this.dateHire.IsEditable = true;
			this.dateHire.AutoSeparation = true;
			this.table1.Add (this.dateHire);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.dateHire]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryFirstName = new global::Gtk.Entry ();
			this.entryFirstName.CanFocus = true;
			this.entryFirstName.Name = "entryFirstName";
			this.entryFirstName.IsEditable = true;
			this.entryFirstName.InvisibleChar = '●';
			this.table1.Add (this.entryFirstName);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryFirstName]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryLastName = new global::Gtk.Entry ();
			this.entryLastName.CanFocus = true;
			this.entryLastName.Name = "entryLastName";
			this.entryLastName.IsEditable = true;
			this.entryLastName.InvisibleChar = '●';
			this.table1.Add (this.entryLastName);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryLastName]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPatronymic = new global::Gtk.Entry ();
			this.entryPatronymic.CanFocus = true;
			this.entryPatronymic.Name = "entryPatronymic";
			this.entryPatronymic.IsEditable = true;
			this.entryPatronymic.InvisibleChar = '●';
			this.table1.Add (this.entryPatronymic);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryPatronymic]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hboxLeader = new global::Gtk.HBox ();
			this.hboxLeader.Name = "hboxLeader";
			this.hboxLeader.Spacing = 6;
			// Container child hboxLeader.Gtk.Box+BoxChild
			this.entryLeader = new global::Gtk.Entry ();
			this.entryLeader.CanFocus = true;
			this.entryLeader.Name = "entryLeader";
			this.entryLeader.IsEditable = false;
			this.entryLeader.InvisibleChar = '●';
			this.hboxLeader.Add (this.entryLeader);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxLeader [this.entryLeader]));
			w10.Position = 0;
			// Container child hboxLeader.Gtk.Box+BoxChild
			this.buttonLeaderClear = new global::Gtk.Button ();
			this.buttonLeaderClear.CanFocus = true;
			this.buttonLeaderClear.Name = "buttonLeaderClear";
			this.buttonLeaderClear.UseUnderline = true;
			// Container child buttonLeaderClear.Gtk.Container+ContainerChild
			global::Gtk.Alignment w11 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w12 = new global::Gtk.HBox ();
			w12.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			w12.Add (w13);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w15 = new global::Gtk.Label ();
			w12.Add (w15);
			w11.Add (w12);
			this.buttonLeaderClear.Add (w11);
			this.hboxLeader.Add (this.buttonLeaderClear);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hboxLeader [this.buttonLeaderClear]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hboxLeader.Gtk.Box+BoxChild
			this.buttonLeader = new global::Gtk.Button ();
			this.buttonLeader.CanFocus = true;
			this.buttonLeader.Name = "buttonLeader";
			this.buttonLeader.UseUnderline = true;
			// Container child buttonLeader.Gtk.Container+ContainerChild
			global::Gtk.Alignment w20 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w21 = new global::Gtk.HBox ();
			w21.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w21.Add (w22);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w24 = new global::Gtk.Label ();
			w21.Add (w24);
			w20.Add (w21);
			this.buttonLeader.Add (w20);
			this.hboxLeader.Add (this.buttonLeader);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hboxLeader [this.buttonLeader]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.table1.Add (this.hboxLeader);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.hboxLeader]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hboxObject = new global::Gtk.HBox ();
			this.hboxObject.Name = "hboxObject";
			this.hboxObject.Spacing = 6;
			// Container child hboxObject.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelObjectName = new global::Gtk.Label ();
			this.labelObjectName.Name = "labelObjectName";
			this.labelObjectName.LabelProp = global::Mono.Unix.Catalog.GetString ("---");
			this.vbox3.Add (this.labelObjectName);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelObjectName]));
			w30.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelObjectAddress = new global::Gtk.Label ();
			this.labelObjectAddress.Name = "labelObjectAddress";
			this.labelObjectAddress.LabelProp = global::Mono.Unix.Catalog.GetString ("---");
			this.vbox3.Add (this.labelObjectAddress);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelObjectAddress]));
			w31.Position = 1;
			this.hboxObject.Add (this.vbox3);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hboxObject [this.vbox3]));
			w32.Position = 0;
			// Container child hboxObject.Gtk.Box+BoxChild
			this.buttonObjectClear = new global::Gtk.Button ();
			this.buttonObjectClear.CanFocus = true;
			this.buttonObjectClear.Name = "buttonObjectClear";
			this.buttonObjectClear.UseUnderline = true;
			// Container child buttonObjectClear.Gtk.Container+ContainerChild
			global::Gtk.Alignment w33 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w34 = new global::Gtk.HBox ();
			w34.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w35 = new global::Gtk.Image ();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			w34.Add (w35);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w37 = new global::Gtk.Label ();
			w34.Add (w37);
			w33.Add (w34);
			this.buttonObjectClear.Add (w33);
			this.hboxObject.Add (this.buttonObjectClear);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hboxObject [this.buttonObjectClear]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hboxObject.Gtk.Box+BoxChild
			this.buttonObject = new global::Gtk.Button ();
			this.buttonObject.CanFocus = true;
			this.buttonObject.Name = "buttonObject";
			this.buttonObject.UseUnderline = true;
			// Container child buttonObject.Gtk.Container+ContainerChild
			global::Gtk.Alignment w42 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w43 = new global::Gtk.HBox ();
			w43.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w44 = new global::Gtk.Image ();
			w44.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w43.Add (w44);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w46 = new global::Gtk.Label ();
			w43.Add (w46);
			w42.Add (w43);
			this.buttonObject.Add (w42);
			this.hboxObject.Add (this.buttonObject);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hboxObject [this.buttonObject]));
			w50.Position = 2;
			w50.Expand = false;
			w50.Fill = false;
			this.table1.Add (this.hboxObject);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table1 [this.hboxObject]));
			w51.TopAttach = ((uint)(6));
			w51.BottomAttach = ((uint)(7));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(4));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер карточки:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Должность:");
			this.table1.Add (this.label10);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1 [this.label10]));
			w53.TopAttach = ((uint)(4));
			w53.BottomAttach = ((uint)(5));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Руководитель:");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w54.TopAttach = ((uint)(5));
			w54.BottomAttach = ((uint)(6));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.Yalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Объект:");
			this.table1.Add (this.label12);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1 [this.label12]));
			w55.TopAttach = ((uint)(6));
			w55.BottomAttach = ((uint)(7));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xalign = 1F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Пользователь:");
			this.table1.Add (this.label17);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table1 [this.label17]));
			w56.LeftAttach = ((uint)(2));
			w56.RightAttach = ((uint)(3));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Фамилия:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w57.TopAttach = ((uint)(1));
			w57.BottomAttach = ((uint)(2));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Имя:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w58.TopAttach = ((uint)(2));
			w58.BottomAttach = ((uint)(3));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Отчество:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w59.TopAttach = ((uint)(3));
			w59.BottomAttach = ((uint)(4));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата поступления:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w60.TopAttach = ((uint)(1));
			w60.BottomAttach = ((uint)(2));
			w60.LeftAttach = ((uint)(2));
			w60.RightAttach = ((uint)(3));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата увольнения:");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w61 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w61.TopAttach = ((uint)(2));
			w61.BottomAttach = ((uint)(3));
			w61.LeftAttach = ((uint)(2));
			w61.RightAttach = ((uint)(3));
			w61.XOptions = ((global::Gtk.AttachOptions)(4));
			w61.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Пол:");
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w62 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w62.TopAttach = ((uint)(3));
			w62.BottomAttach = ((uint)(4));
			w62.LeftAttach = ((uint)(2));
			w62.RightAttach = ((uint)(3));
			w62.XOptions = ((global::Gtk.AttachOptions)(4));
			w62.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Рост:");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w63 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w63.TopAttach = ((uint)(4));
			w63.BottomAttach = ((uint)(5));
			w63.LeftAttach = ((uint)(2));
			w63.RightAttach = ((uint)(3));
			w63.XOptions = ((global::Gtk.AttachOptions)(4));
			w63.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Размер одежды:");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w64 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
			w64.TopAttach = ((uint)(5));
			w64.BottomAttach = ((uint)(6));
			w64.LeftAttach = ((uint)(2));
			w64.RightAttach = ((uint)(3));
			w64.XOptions = ((global::Gtk.AttachOptions)(4));
			w64.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelId = new global::Gtk.Label ();
			this.labelId.Name = "labelId";
			this.labelId.LabelProp = global::Mono.Unix.Catalog.GetString ("не указан");
			this.table1.Add (this.labelId);
			global::Gtk.Table.TableChild w65 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelId]));
			w65.LeftAttach = ((uint)(1));
			w65.RightAttach = ((uint)(2));
			w65.XOptions = ((global::Gtk.AttachOptions)(4));
			w65.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelUser = new global::Gtk.Label ();
			this.labelUser.Name = "labelUser";
			this.labelUser.LabelProp = global::Mono.Unix.Catalog.GetString ("не указан");
			this.table1.Add (this.labelUser);
			global::Gtk.Table.TableChild w66 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelUser]));
			w66.LeftAttach = ((uint)(3));
			w66.RightAttach = ((uint)(4));
			w66.XOptions = ((global::Gtk.AttachOptions)(4));
			w66.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinGrowth = new global::Gtk.SpinButton (0, 300, 1);
			this.spinGrowth.CanFocus = true;
			this.spinGrowth.Name = "spinGrowth";
			this.spinGrowth.Adjustment.PageIncrement = 10;
			this.spinGrowth.ClimbRate = 1;
			this.spinGrowth.Numeric = true;
			this.table1.Add (this.spinGrowth);
			global::Gtk.Table.TableChild w67 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinGrowth]));
			w67.TopAttach = ((uint)(4));
			w67.BottomAttach = ((uint)(5));
			w67.LeftAttach = ((uint)(3));
			w67.RightAttach = ((uint)(4));
			w67.XOptions = ((global::Gtk.AttachOptions)(4));
			w67.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table1]));
			w68.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.imagePhoto = new global::Gtk.Image ();
			this.imagePhoto.Name = "imagePhoto";
			this.frame1.Add (this.imagePhoto);
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w70.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonLoadPhoto = new global::Gtk.Button ();
			this.buttonLoadPhoto.CanFocus = true;
			this.buttonLoadPhoto.Name = "buttonLoadPhoto";
			this.buttonLoadPhoto.UseUnderline = true;
			// Container child buttonLoadPhoto.Gtk.Container+ContainerChild
			global::Gtk.Alignment w71 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w72 = new global::Gtk.HBox ();
			w72.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w73 = new global::Gtk.Image ();
			w73.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			w72.Add (w73);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w75 = new global::Gtk.Label ();
			w75.LabelProp = global::Mono.Unix.Catalog.GetString ("Загрузить");
			w75.UseUnderline = true;
			w72.Add (w75);
			w71.Add (w72);
			this.buttonLoadPhoto.Add (w71);
			this.hbox4.Add (this.buttonLoadPhoto);
			global::Gtk.Box.BoxChild w79 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonLoadPhoto]));
			w79.Position = 0;
			w79.Expand = false;
			w79.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSavePhoto = new global::Gtk.Button ();
			this.buttonSavePhoto.Sensitive = false;
			this.buttonSavePhoto.CanFocus = true;
			this.buttonSavePhoto.Name = "buttonSavePhoto";
			this.buttonSavePhoto.UseUnderline = true;
			// Container child buttonSavePhoto.Gtk.Container+ContainerChild
			global::Gtk.Alignment w80 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w81 = new global::Gtk.HBox ();
			w81.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w82 = new global::Gtk.Image ();
			w82.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			w81.Add (w82);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w84 = new global::Gtk.Label ();
			w84.LabelProp = global::Mono.Unix.Catalog.GetString ("Сохранить");
			w84.UseUnderline = true;
			w81.Add (w84);
			w80.Add (w81);
			this.buttonSavePhoto.Add (w80);
			this.hbox4.Add (this.buttonSavePhoto);
			global::Gtk.Box.BoxChild w88 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonSavePhoto]));
			w88.Position = 1;
			w88.Expand = false;
			w88.Fill = false;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w89 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w89.Position = 1;
			w89.Expand = false;
			w89.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w90 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w90.Position = 1;
			w90.Expand = false;
			w90.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w91 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w91.Position = 0;
			w91.Expand = false;
			w91.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			this.hbox5.BorderWidth = ((uint)(3));
			// Container child hbox5.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Выдача и возврат спецодежды");
			this.hbox5.Add (this.label13);
			global::Gtk.Box.BoxChild w92 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label13]));
			w92.Position = 0;
			w92.Expand = false;
			w92.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.checkShowHistory = new global::Gtk.CheckButton ();
			this.checkShowHistory.CanFocus = true;
			this.checkShowHistory.Name = "checkShowHistory";
			this.checkShowHistory.Label = global::Mono.Unix.Catalog.GetString ("Показывать историю выдач");
			this.checkShowHistory.DrawIndicator = true;
			this.checkShowHistory.UseUnderline = true;
			this.hbox5.Add (this.checkShowHistory);
			global::Gtk.Box.BoxChild w93 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.checkShowHistory]));
			w93.Position = 2;
			w1.Add (this.hbox5);
			global::Gtk.Box.BoxChild w94 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox5]));
			w94.Position = 1;
			w94.Expand = false;
			w94.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow.BorderWidth = ((uint)(3));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewWear = new global::Gtk.TreeView ();
			this.treeviewWear.CanFocus = true;
			this.treeviewWear.Name = "treeviewWear";
			this.GtkScrolledWindow.Add (this.treeviewWear);
			w1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w96 = ((global::Gtk.Box.BoxChild)(w1 [this.GtkScrolledWindow]));
			w96.Position = 2;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonGiveWear = new global::Gtk.Button ();
			this.buttonGiveWear.Sensitive = false;
			this.buttonGiveWear.CanFocus = true;
			this.buttonGiveWear.Name = "buttonGiveWear";
			this.buttonGiveWear.UseUnderline = true;
			// Container child buttonGiveWear.Gtk.Container+ContainerChild
			global::Gtk.Alignment w97 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w98 = new global::Gtk.HBox ();
			w98.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w99 = new global::Gtk.Image ();
			w99.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w98.Add (w99);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w101 = new global::Gtk.Label ();
			w101.LabelProp = global::Mono.Unix.Catalog.GetString ("Выдача спецодежды");
			w101.UseUnderline = true;
			w98.Add (w101);
			w97.Add (w98);
			this.buttonGiveWear.Add (w97);
			this.hbox6.Add (this.buttonGiveWear);
			global::Gtk.Box.BoxChild w105 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.buttonGiveWear]));
			w105.Position = 0;
			w105.Expand = false;
			w105.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonReturnWear = new global::Gtk.Button ();
			this.buttonReturnWear.Sensitive = false;
			this.buttonReturnWear.CanFocus = true;
			this.buttonReturnWear.Name = "buttonReturnWear";
			this.buttonReturnWear.UseUnderline = true;
			// Container child buttonReturnWear.Gtk.Container+ContainerChild
			global::Gtk.Alignment w106 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w107 = new global::Gtk.HBox ();
			w107.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w108 = new global::Gtk.Image ();
			w108.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-redo", global::Gtk.IconSize.Menu);
			w107.Add (w108);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w110 = new global::Gtk.Label ();
			w110.LabelProp = global::Mono.Unix.Catalog.GetString ("Возврат на склад");
			w110.UseUnderline = true;
			w107.Add (w110);
			w106.Add (w107);
			this.buttonReturnWear.Add (w106);
			this.hbox6.Add (this.buttonReturnWear);
			global::Gtk.Box.BoxChild w114 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.buttonReturnWear]));
			w114.Position = 1;
			w114.Expand = false;
			w114.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonWriteOffWear = new global::Gtk.Button ();
			this.buttonWriteOffWear.Sensitive = false;
			this.buttonWriteOffWear.CanFocus = true;
			this.buttonWriteOffWear.Name = "buttonWriteOffWear";
			this.buttonWriteOffWear.UseUnderline = true;
			// Container child buttonWriteOffWear.Gtk.Container+ContainerChild
			global::Gtk.Alignment w115 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w116 = new global::Gtk.HBox ();
			w116.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w117 = new global::Gtk.Image ();
			w117.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			w116.Add (w117);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w119 = new global::Gtk.Label ();
			w119.LabelProp = global::Mono.Unix.Catalog.GetString ("Списание");
			w119.UseUnderline = true;
			w116.Add (w119);
			w115.Add (w116);
			this.buttonWriteOffWear.Add (w115);
			this.hbox6.Add (this.buttonWriteOffWear);
			global::Gtk.Box.BoxChild w123 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.buttonWriteOffWear]));
			w123.Position = 2;
			w123.Expand = false;
			w123.Fill = false;
			w1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w124 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox6]));
			w124.Position = 3;
			w124.Expand = false;
			w124.Fill = false;
			// Internal child workwear.WearCard.ActionArea
			global::Gtk.HButtonBox w125 = this.ActionArea;
			w125.Name = "dialog1_ActionArea";
			w125.Spacing = 10;
			w125.BorderWidth = ((uint)(5));
			w125.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPrint = new global::Gtk.Button ();
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			// Container child buttonPrint.Gtk.Container+ContainerChild
			global::Gtk.Alignment w126 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w127 = new global::Gtk.HBox ();
			w127.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w128 = new global::Gtk.Image ();
			w128.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Menu);
			w127.Add (w128);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w130 = new global::Gtk.Label ();
			w130.LabelProp = global::Mono.Unix.Catalog.GetString ("Печать");
			w130.UseUnderline = true;
			w127.Add (w130);
			w126.Add (w127);
			this.buttonPrint.Add (w126);
			this.AddActionWidget (this.buttonPrint, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w134 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w125 [this.buttonPrint]));
			w134.Expand = false;
			w134.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w135 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w136 = new global::Gtk.HBox ();
			w136.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w137 = new global::Gtk.Image ();
			w137.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w136.Add (w137);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w139 = new global::Gtk.Label ();
			w139.LabelProp = global::Mono.Unix.Catalog.GetString ("О_тменить");
			w139.UseUnderline = true;
			w136.Add (w139);
			w135.Add (w136);
			this.buttonCancel.Add (w135);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w143 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w125 [this.buttonCancel]));
			w143.Position = 1;
			w143.Expand = false;
			w143.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w144 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w145 = new global::Gtk.HBox ();
			w145.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w146 = new global::Gtk.Image ();
			w146.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			w145.Add (w146);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w148 = new global::Gtk.Label ();
			w148.LabelProp = global::Mono.Unix.Catalog.GetString ("_OK");
			w148.UseUnderline = true;
			w145.Add (w148);
			w144.Add (w145);
			this.buttonOk.Add (w144);
			w125.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w152 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w125 [this.buttonOk]));
			w152.Position = 2;
			w152.Expand = false;
			w152.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 847;
			this.DefaultHeight = 569;
			this.Show ();
			this.buttonObjectClear.Clicked += new global::System.EventHandler (this.OnButtonObjectClearClicked);
			this.buttonObject.Clicked += new global::System.EventHandler (this.OnButtonObjectClicked);
			this.buttonLeaderClear.Clicked += new global::System.EventHandler (this.OnButtonLeaderClearClicked);
			this.buttonLeader.Clicked += new global::System.EventHandler (this.OnButtonLeaderClicked);
			this.buttonLoadPhoto.Clicked += new global::System.EventHandler (this.OnButtonLoadPhotoClicked);
			this.buttonSavePhoto.Clicked += new global::System.EventHandler (this.OnButtonSavePhotoClicked);
			this.checkShowHistory.Clicked += new global::System.EventHandler (this.OnCheckShowHistoryClicked);
			this.buttonGiveWear.Clicked += new global::System.EventHandler (this.OnButtonGiveWearClicked);
			this.buttonReturnWear.Clicked += new global::System.EventHandler (this.OnButtonReturnWearClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}

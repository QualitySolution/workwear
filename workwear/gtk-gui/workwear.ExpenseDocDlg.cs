
// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class ExpenseDocDlg
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label labelObject;
		
		private global::Gtk.Label labelWorker;
		
		private global::Gamma.Widgets.yEnumComboBox ycomboOperation;
		
		private global::Gamma.Widgets.yEntryReference yentryEmployee;
		
		private global::Gamma.Widgets.yEntryReference yentryObject;
		
		private global::Gtk.Table table3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gamma.Widgets.yDatePicker ydateDoc;
		
		private global::Gamma.GtkWidgets.yLabel ylabelCreatedBy;
		
		private global::Gamma.GtkWidgets.yLabel ylabelId;
		
		private global::workwear.ExpenseDocItemsView ItemsTable;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget workwear.ExpenseDocDlg
			this.Name = "workwear.ExpenseDocDlg";
			this.Title = global::Mono.Unix.Catalog.GetString ("Новая выдача");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child workwear.ExpenseDocDlg.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Операция<span foreground=\"red\">*</span>:");
			this.label2.UseMarkup = true;
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.label2]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelObject = new global::Gtk.Label ();
			this.labelObject.Name = "labelObject";
			this.labelObject.Xalign = 1F;
			this.labelObject.LabelProp = global::Mono.Unix.Catalog.GetString ("Объект<span foreground=\"red\">*</span>:");
			this.labelObject.UseMarkup = true;
			this.table2.Add (this.labelObject);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelObject]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelWorker = new global::Gtk.Label ();
			this.labelWorker.Name = "labelWorker";
			this.labelWorker.LabelProp = global::Mono.Unix.Catalog.GetString ("Работник<span foreground=\"red\">*</span>:");
			this.labelWorker.UseMarkup = true;
			this.table2.Add (this.labelWorker);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelWorker]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ycomboOperation = new global::Gamma.Widgets.yEnumComboBox ();
			this.ycomboOperation.Name = "ycomboOperation";
			this.ycomboOperation.ShowSpecialStateAll = false;
			this.ycomboOperation.ShowSpecialStateNot = false;
			this.ycomboOperation.UseShortTitle = false;
			this.table2.Add (this.ycomboOperation);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.ycomboOperation]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.yentryEmployee = new global::Gamma.Widgets.yEntryReference ();
			this.yentryEmployee.Events = ((global::Gdk.EventMask)(256));
			this.yentryEmployee.Name = "yentryEmployee";
			this.table2.Add (this.yentryEmployee);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.yentryEmployee]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.yentryObject = new global::Gamma.Widgets.yEntryReference ();
			this.yentryObject.Events = ((global::Gdk.EventMask)(256));
			this.yentryObject.Name = "yentryObject";
			this.table2.Add (this.yentryObject);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.yentryObject]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table2]));
			w8.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер:");
			this.table3.Add (this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.label4]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Пользователь:");
			this.table3.Add (this.label5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3 [this.label5]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата<span foreground=\"red\">*</span>:");
			this.label6.UseMarkup = true;
			this.table3.Add (this.label6);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3 [this.label6]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ydateDoc = new global::Gamma.Widgets.yDatePicker ();
			this.ydateDoc.Events = ((global::Gdk.EventMask)(256));
			this.ydateDoc.Name = "ydateDoc";
			this.ydateDoc.Date = new global::System.DateTime (0);
			this.ydateDoc.IsEditable = false;
			this.ydateDoc.AutoSeparation = false;
			this.table3.Add (this.ydateDoc);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3 [this.ydateDoc]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ylabelCreatedBy = new global::Gamma.GtkWidgets.yLabel ();
			this.ylabelCreatedBy.Name = "ylabelCreatedBy";
			this.ylabelCreatedBy.LabelProp = global::Mono.Unix.Catalog.GetString ("ylabel1");
			this.table3.Add (this.ylabelCreatedBy);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3 [this.ylabelCreatedBy]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ylabelId = new global::Gamma.GtkWidgets.yLabel ();
			this.ylabelId.Name = "ylabelId";
			this.ylabelId.LabelProp = global::Mono.Unix.Catalog.GetString ("ylabel3");
			this.table3.Add (this.ylabelId);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3 [this.ylabelId]));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table3]));
			w15.Position = 1;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.ItemsTable = new global::workwear.ExpenseDocItemsView ();
			this.ItemsTable.Events = ((global::Gdk.EventMask)(256));
			this.ItemsTable.Name = "ItemsTable";
			w1.Add (this.ItemsTable);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(w1 [this.ItemsTable]));
			w17.Position = 1;
			// Internal child workwear.ExpenseDocDlg.ActionArea
			global::Gtk.HButtonBox w18 = this.ActionArea;
			w18.Name = "dialog1_ActionArea";
			w18.Spacing = 10;
			w18.BorderWidth = ((uint)(5));
			w18.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("О_тменить");
			global::Gtk.Image w19 = new global::Gtk.Image ();
			w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w19;
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w18 [this.buttonCancel]));
			w20.Expand = false;
			w20.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString ("_OK");
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.buttonOk.Image = w21;
			w18.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w18 [this.buttonOk]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 614;
			this.DefaultHeight = 392;
			this.Show ();
			this.ycomboOperation.Changed += new global::System.EventHandler (this.OnYcomboOperationChanged);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}

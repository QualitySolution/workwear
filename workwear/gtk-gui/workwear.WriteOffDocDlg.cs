
// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class WriteOffDocDlg
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Label label4;
		
		private global::Gamma.GtkWidgets.yLabel ylabelId;
		
		private global::Gtk.Table table3;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gamma.Widgets.yDatePicker ydateDoc;
		
		private global::Gamma.GtkWidgets.yLabel ylabelCreatedBy;
		
		private global::workwear.WriteOffItemsView ItemsTable;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget workwear.WriteOffDocDlg
			this.Name = "workwear.WriteOffDocDlg";
			this.Title = global::Mono.Unix.Catalog.GetString ("Новое списание");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child workwear.WriteOffDocDlg.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер:");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ylabelId = new global::Gamma.GtkWidgets.yLabel ();
			this.ylabelId.Name = "ylabelId";
			this.ylabelId.LabelProp = global::Mono.Unix.Catalog.GetString ("ylabel3");
			this.table2.Add (this.ylabelId);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.ylabelId]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table2]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Пользователь:");
			this.table3.Add (this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3 [this.label5]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата<span foreground=\"red\">*</span>:");
			this.label6.UseMarkup = true;
			this.table3.Add (this.label6);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.label6]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ydateDoc = new global::Gamma.Widgets.yDatePicker ();
			this.ydateDoc.Events = ((global::Gdk.EventMask)(256));
			this.ydateDoc.Name = "ydateDoc";
			this.ydateDoc.WithTime = false;
			this.ydateDoc.Date = new global::System.DateTime (0);
			this.ydateDoc.IsEditable = true;
			this.ydateDoc.AutoSeparation = true;
			this.table3.Add (this.ydateDoc);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3 [this.ydateDoc]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ylabelCreatedBy = new global::Gamma.GtkWidgets.yLabel ();
			this.ylabelCreatedBy.Name = "ylabelCreatedBy";
			this.ylabelCreatedBy.LabelProp = global::Mono.Unix.Catalog.GetString ("ylabel1");
			this.table3.Add (this.ylabelCreatedBy);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3 [this.ylabelCreatedBy]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table3]));
			w9.Position = 1;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.ItemsTable = new global::workwear.WriteOffItemsView ();
			this.ItemsTable.Events = ((global::Gdk.EventMask)(256));
			this.ItemsTable.Name = "ItemsTable";
			w1.Add (this.ItemsTable);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.ItemsTable]));
			w11.Position = 1;
			// Internal child workwear.WriteOffDocDlg.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("О_тменить");
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w13;
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonCancel]));
			w14.Expand = false;
			w14.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString ("_OK");
			global::Gtk.Image w15 = new global::Gtk.Image ();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.buttonOk.Image = w15;
			w12.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonOk]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 721;
			this.DefaultHeight = 496;
			this.Show ();
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}

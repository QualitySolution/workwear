
// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class ObjectDlg
	{
		private global::Gtk.Table table1;
		private global::Gtk.Entry entryName;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textviewAddress;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label labelID;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget workwear.ObjectDlg
			this.Name = "workwear.ObjectDlg";
			this.Title = global::Mono.Unix.Catalog.GetString ("Новый объект");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child workwear.ObjectDlg.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add (this.entryName);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryName]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewAddress = new global::Gtk.TextView ();
			this.textviewAddress.CanFocus = true;
			this.textviewAddress.Name = "textviewAddress";
			this.GtkScrolledWindow.Add (this.textviewAddress);
			this.table1.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Код:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Название<span foreground=\"red\">*</span>:");
			this.label3.UseMarkup = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Адрес:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelID = new global::Gtk.Label ();
			this.labelID.Name = "labelID";
			this.labelID.LabelProp = global::Mono.Unix.Catalog.GetString ("не определен");
			this.table1.Add (this.labelID);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelID]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(w1 [this.table1]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Internal child workwear.ObjectDlg.ActionArea
			global::Gtk.HButtonBox w10 = this.ActionArea;
			w10.Name = "dialog1_ActionArea";
			w10.Spacing = 10;
			w10.BorderWidth = ((uint)(5));
			w10.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w11 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w12 = new global::Gtk.HBox ();
			w12.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w12.Add (w13);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w15 = new global::Gtk.Label ();
			w15.LabelProp = global::Mono.Unix.Catalog.GetString ("О_тменить");
			w15.UseUnderline = true;
			w12.Add (w15);
			w11.Add (w12);
			this.buttonCancel.Add (w11);
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10 [this.buttonCancel]));
			w19.Expand = false;
			w19.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w20 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w21 = new global::Gtk.HBox ();
			w21.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			w21.Add (w22);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w24 = new global::Gtk.Label ();
			w24.LabelProp = global::Mono.Unix.Catalog.GetString ("_OK");
			w24.UseUnderline = true;
			w21.Add (w24);
			w20.Add (w21);
			this.buttonOk.Add (w20);
			w10.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10 [this.buttonOk]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 441;
			this.DefaultHeight = 187;
			this.Show ();
			this.entryName.Changed += new global::System.EventHandler (this.OnEntryNameChanged);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}

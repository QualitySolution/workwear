
// This file has been generated by the GUI designer. Do not modify.
namespace workwear.ReportsDlg
{
	public partial class StockAllWearDlg
	{
		private global::Gtk.VBox dialog1_VBox;

		private global::Gtk.Table table1;

		private global::Gtk.ComboBox comboObject;

		private global::Gtk.Label label1;

		private global::Gtk.Button buttonRun;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.ReportsDlg.StockAllWearDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.ReportsDlg.StockAllWearDlg";
			// Container child workwear.ReportsDlg.StockAllWearDlg.Gtk.Container+ContainerChild
			this.dialog1_VBox = new global::Gtk.VBox();
			this.dialog1_VBox.Name = "dialog1_VBox";
			this.dialog1_VBox.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), false);
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboObject = new global::Gtk.ComboBox();
			this.comboObject.Name = "comboObject";
			this.table1.Add(this.comboObject);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.comboObject]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Склад:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.dialog1_VBox.Add(this.table1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.table1]));
			w3.Position = 0;
			w3.Expand = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.buttonRun = new global::Gtk.Button();
			this.buttonRun.Sensitive = false;
			this.buttonRun.CanFocus = true;
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.UseUnderline = true;
			this.buttonRun.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.dialog1_VBox.Add(this.buttonRun);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.buttonRun]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.dialog1_VBox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.comboObject.Changed += new global::System.EventHandler(this.OnComboObjectChanged);
			this.buttonRun.Clicked += new global::System.EventHandler(this.OnButtonRunClicked);
		}
	}
}

// This file has been generated by the GUI designer. Do not modify.
namespace workwear.Views.Stock.Widgets
{
	public partial class SizeWidgetView
	{
		private global::Gtk.Table table1;

		private global::Gamma.GtkWidgets.yButton AddButton;

		private global::Gtk.Table CheckBoxPlace;

		private global::Gtk.HBox GrowthInfoBox;

		private global::Gtk.Label GrowthInfoLabel;

		private global::Gamma.Widgets.yListComboBox GrowthBox;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label3;

		private global::Gtk.Button selectAllButton;

		private global::Gtk.Label label2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.Views.Stock.Widgets.SizeWidgetView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.Views.Stock.Widgets.SizeWidgetView";
			// Container child workwear.Views.Stock.Widgets.SizeWidgetView.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.AddButton = new global::Gamma.GtkWidgets.yButton();
			this.AddButton.CanFocus = true;
			this.AddButton.Name = "AddButton";
			this.AddButton.UseUnderline = true;
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.AddButton.Image = w1;
			this.table1.Add(this.AddButton);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.AddButton]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(0));
			w2.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table1.Gtk.Table+TableChild
			this.CheckBoxPlace = new global::Gtk.Table(((uint)(1)), ((uint)(4)), false);
			this.CheckBoxPlace.Name = "CheckBoxPlace";
			this.CheckBoxPlace.RowSpacing = ((uint)(6));
			this.CheckBoxPlace.ColumnSpacing = ((uint)(6));
			this.table1.Add(this.CheckBoxPlace);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.CheckBoxPlace]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.RightAttach = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.GrowthInfoBox = new global::Gtk.HBox();
			this.GrowthInfoBox.Name = "GrowthInfoBox";
			this.GrowthInfoBox.Spacing = 6;
			// Container child GrowthInfoBox.Gtk.Box+BoxChild
			this.GrowthInfoLabel = new global::Gtk.Label();
			this.GrowthInfoLabel.Name = "GrowthInfoLabel";
			this.GrowthInfoLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Рост:");
			this.GrowthInfoBox.Add(this.GrowthInfoLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.GrowthInfoBox[this.GrowthInfoLabel]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child GrowthInfoBox.Gtk.Box+BoxChild
			this.GrowthBox = new global::Gamma.Widgets.yListComboBox();
			this.GrowthBox.Name = "GrowthBox";
			this.GrowthBox.AddIfNotExist = false;
			this.GrowthBox.DefaultFirst = false;
			this.GrowthInfoBox.Add(this.GrowthBox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.GrowthInfoBox[this.GrowthBox]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.table1.Add(this.GrowthInfoBox);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.GrowthInfoBox]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Выбрать всё:");
			this.hbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.selectAllButton = new global::Gtk.Button();
			this.selectAllButton.CanFocus = true;
			this.selectAllButton.Name = "selectAllButton";
			this.selectAllButton.UseUnderline = true;
			this.selectAllButton.Label = global::Mono.Unix.Catalog.GetString("Выбрать все");
			this.hbox2.Add(this.selectAllButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.selectAllButton]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.table1.Add(this.hbox2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox2]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Выберите размеры:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w10.RightAttach = ((uint)(3));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.selectAllButton.Clicked += new global::System.EventHandler(this.selectAllButton_Clicked);
			this.AddButton.Clicked += new global::System.EventHandler(this.OnAddButtonClicked);
		}
	}
}

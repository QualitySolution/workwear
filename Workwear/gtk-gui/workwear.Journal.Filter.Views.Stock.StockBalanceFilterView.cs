
// This file has been generated by the GUI designer. Do not modify.
namespace workwear.Journal.Filter.Views.Stock
{
	public partial class StockBalanceFilterView
	{
		private global::Gtk.Table table1;

		private global::Gamma.GtkWidgets.yCheckButton chShowNegative;

		private global::QS.Views.Control.EntityEntry entityWarehouse;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.Journal.Filter.Views.Stock.StockBalanceFilterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.Journal.Filter.Views.Stock.StockBalanceFilterView";
			// Container child workwear.Journal.Filter.Views.Stock.StockBalanceFilterView.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.chShowNegative = new global::Gamma.GtkWidgets.yCheckButton();
			this.chShowNegative.CanFocus = true;
			this.chShowNegative.Name = "chShowNegative";
			this.chShowNegative.Label = global::Mono.Unix.Catalog.GetString("Показать отрицательный баланс");
			this.chShowNegative.DrawIndicator = true;
			this.chShowNegative.UseUnderline = true;
			this.chShowNegative.Xalign = 1F;
			this.table1.Add(this.chShowNegative);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.chShowNegative]));
			w1.LeftAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entityWarehouse = new global::QS.Views.Control.EntityEntry();
			this.entityWarehouse.Events = ((global::Gdk.EventMask)(256));
			this.entityWarehouse.Name = "entityWarehouse";
			this.table1.Add(this.entityWarehouse);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.entityWarehouse]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Склад:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}

// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class EmployeeBalanceFilter
	{
		private global::Gtk.Table table1;

		private global::Gtk.Label label1;

		private global::QS.Views.Control.EntityEntry yentryEmployee;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.EmployeeBalanceFilter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.EmployeeBalanceFilter";
			// Container child workwear.EmployeeBalanceFilter.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Сотрудник:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryEmployee = new global::QS.Views.Control.EntityEntry();
			this.yentryEmployee.Events = ((global::Gdk.EventMask)(256));
			this.yentryEmployee.Name = "yentryEmployee";
			this.table1.Add(this.yentryEmployee);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryEmployee]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}

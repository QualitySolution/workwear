
// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class OnIssueStatement
	{
		private global::Gtk.VBox dialog1_VBox;

		private global::Gtk.Table table1;

		private global::QS.Views.Control.EntityEntry entityEmployee;

		private global::QS.Views.Control.EntityEntry entitySubdivision;

		private global::Gtk.HBox hbox1;

		private global::Gamma.Widgets.yListComboBox ylistcomboMonth;

		private global::Gamma.Widgets.yListComboBox ylistcomboYear;

		private global::Gtk.HBox hbox2;

		private global::Gamma.Widgets.yListComboBox ylistcomboMonth1;

		private global::Gamma.Widgets.yListComboBox ylistcomboYear1;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.yListComboBox ylistcomboMonth2;

		private global::Gamma.Widgets.yListComboBox ylistcomboYear2;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gtk.RadioButton radioPeriodMonth;

		private global::Gtk.RadioButton radioPeriodMultiMonth;

		private global::Gtk.Button buttonRun;

		private global::Gtk.Label labelError;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.OnIssueStatement
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.OnIssueStatement";
			// Container child workwear.OnIssueStatement.Gtk.Container+ContainerChild
			this.dialog1_VBox = new global::Gtk.VBox();
			this.dialog1_VBox.Name = "dialog1_VBox";
			this.dialog1_VBox.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entityEmployee = new global::QS.Views.Control.EntityEntry();
			this.entityEmployee.Events = ((global::Gdk.EventMask)(256));
			this.entityEmployee.Name = "entityEmployee";
			this.table1.Add(this.entityEmployee);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.entityEmployee]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entitySubdivision = new global::QS.Views.Control.EntityEntry();
			this.entitySubdivision.Events = ((global::Gdk.EventMask)(256));
			this.entitySubdivision.Name = "entitySubdivision";
			this.table1.Add(this.entitySubdivision);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.entitySubdivision]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylistcomboMonth = new global::Gamma.Widgets.yListComboBox();
			this.ylistcomboMonth.Name = "ylistcomboMonth";
			this.ylistcomboMonth.AddIfNotExist = false;
			this.ylistcomboMonth.DefaultFirst = false;
			this.hbox1.Add(this.ylistcomboMonth);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylistcomboMonth]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylistcomboYear = new global::Gamma.Widgets.yListComboBox();
			this.ylistcomboYear.Name = "ylistcomboYear";
			this.ylistcomboYear.AddIfNotExist = false;
			this.ylistcomboYear.DefaultFirst = true;
			this.hbox1.Add(this.ylistcomboYear);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylistcomboYear]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.table1.Add(this.hbox1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox1]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ylistcomboMonth1 = new global::Gamma.Widgets.yListComboBox();
			this.ylistcomboMonth1.Sensitive = false;
			this.ylistcomboMonth1.Name = "ylistcomboMonth1";
			this.ylistcomboMonth1.AddIfNotExist = false;
			this.ylistcomboMonth1.DefaultFirst = false;
			this.hbox2.Add(this.ylistcomboMonth1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ylistcomboMonth1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ylistcomboYear1 = new global::Gamma.Widgets.yListComboBox();
			this.ylistcomboYear1.Sensitive = false;
			this.ylistcomboYear1.Name = "ylistcomboYear1";
			this.ylistcomboYear1.AddIfNotExist = false;
			this.ylistcomboYear1.DefaultFirst = true;
			this.hbox2.Add(this.ylistcomboYear1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ylistcomboYear1]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("—");
			this.hbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ylistcomboMonth2 = new global::Gamma.Widgets.yListComboBox();
			this.ylistcomboMonth2.Sensitive = false;
			this.ylistcomboMonth2.Name = "ylistcomboMonth2";
			this.ylistcomboMonth2.AddIfNotExist = false;
			this.ylistcomboMonth2.DefaultFirst = false;
			this.hbox2.Add(this.ylistcomboMonth2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ylistcomboMonth2]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ylistcomboYear2 = new global::Gamma.Widgets.yListComboBox();
			this.ylistcomboYear2.Sensitive = false;
			this.ylistcomboYear2.Name = "ylistcomboYear2";
			this.ylistcomboYear2.AddIfNotExist = false;
			this.ylistcomboYear2.DefaultFirst = true;
			this.hbox2.Add(this.ylistcomboYear2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ylistcomboYear2]));
			w10.Position = 4;
			w10.Expand = false;
			w10.Fill = false;
			this.table1.Add(this.hbox2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox2]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Подразделение:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Сотрудник:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radioPeriodMonth = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("на месяц"));
			this.radioPeriodMonth.CanFocus = true;
			this.radioPeriodMonth.Name = "radioPeriodMonth";
			this.radioPeriodMonth.DrawIndicator = true;
			this.radioPeriodMonth.UseUnderline = true;
			this.radioPeriodMonth.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.radioPeriodMonth);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.radioPeriodMonth]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radioPeriodMultiMonth = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("за период"));
			this.radioPeriodMultiMonth.CanFocus = true;
			this.radioPeriodMultiMonth.Name = "radioPeriodMultiMonth";
			this.radioPeriodMultiMonth.DrawIndicator = true;
			this.radioPeriodMultiMonth.UseUnderline = true;
			this.radioPeriodMultiMonth.Group = this.radioPeriodMonth.Group;
			this.table1.Add(this.radioPeriodMultiMonth);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.radioPeriodMultiMonth]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.dialog1_VBox.Add(this.table1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.table1]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.buttonRun = new global::Gtk.Button();
			this.buttonRun.Sensitive = false;
			this.buttonRun.CanFocus = true;
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.UseUnderline = true;
			this.buttonRun.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.dialog1_VBox.Add(this.buttonRun);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.buttonRun]));
			w17.PackType = ((global::Gtk.PackType)(1));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.labelError = new global::Gtk.Label();
			this.labelError.Name = "labelError";
			this.labelError.UseMarkup = true;
			this.labelError.Wrap = true;
			this.labelError.Justify = ((global::Gtk.Justification)(3));
			this.dialog1_VBox.Add(this.labelError);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.labelError]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.Add(this.dialog1_VBox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.radioPeriodMultiMonth.Toggled += new global::System.EventHandler(this.OnRadioPeriodMultiMonthToggled);
			this.radioPeriodMonth.Toggled += new global::System.EventHandler(this.OnRadioPeriodMonthToggled);
			this.ylistcomboMonth1.Changed += new global::System.EventHandler(this.OnYlistcomboMonth1Changed);
			this.ylistcomboYear1.Changed += new global::System.EventHandler(this.OnYlistcomboMonth1Changed);
			this.ylistcomboMonth2.Changed += new global::System.EventHandler(this.OnYlistcomboMonth1Changed);
			this.ylistcomboYear2.Changed += new global::System.EventHandler(this.OnYlistcomboMonth1Changed);
			this.buttonRun.Clicked += new global::System.EventHandler(this.OnButtonRunClicked);
		}
	}
}


// This file has been generated by the GUI designer. Do not modify.
namespace workwear.ReportParameters.Views
{
	public partial class AmountIssuedWearView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label1;

		private global::Gamma.Widgets.yDatePeriodPicker ydateperiodpicker;

		private global::Gamma.GtkWidgets.yCheckButton ycheckSummry;

		private global::Gamma.GtkWidgets.yCheckButton ycheckAll;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeSubdivisions;

		private global::Gamma.GtkWidgets.yButton buttonPrintReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.ReportParameters.Views.AmountIssuedWearView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.ReportParameters.Views.AmountIssuedWearView";
			// Container child workwear.ReportParameters.Views.AmountIssuedWearView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.hbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ydateperiodpicker = new global::Gamma.Widgets.yDatePeriodPicker();
			this.ydateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.ydateperiodpicker.Name = "ydateperiodpicker";
			this.ydateperiodpicker.StartDate = new global::System.DateTime(0);
			this.ydateperiodpicker.EndDate = new global::System.DateTime(0);
			this.hbox2.Add(this.ydateperiodpicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ydateperiodpicker]));
			w2.Position = 1;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.ycheckSummry = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckSummry.CanFocus = true;
			this.ycheckSummry.Name = "ycheckSummry";
			this.ycheckSummry.Label = global::Mono.Unix.Catalog.GetString("Суммарно по организаци");
			this.ycheckSummry.DrawIndicator = true;
			this.ycheckSummry.UseUnderline = true;
			this.vbox2.Add(this.ycheckSummry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.ycheckSummry]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.ycheckAll = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckAll.CanFocus = true;
			this.ycheckAll.Name = "ycheckAll";
			this.ycheckAll.Label = global::Mono.Unix.Catalog.GetString("Все подразделения");
			this.ycheckAll.DrawIndicator = true;
			this.ycheckAll.UseUnderline = true;
			this.vbox2.Add(this.ycheckAll);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.ycheckAll]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeSubdivisions = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeSubdivisions.CanFocus = true;
			this.ytreeSubdivisions.Name = "ytreeSubdivisions";
			this.GtkScrolledWindow.Add(this.ytreeSubdivisions);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w7.Position = 3;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonPrintReport = new global::Gamma.GtkWidgets.yButton();
			this.buttonPrintReport.Sensitive = false;
			this.buttonPrintReport.CanFocus = true;
			this.buttonPrintReport.Name = "buttonPrintReport";
			this.buttonPrintReport.UseUnderline = true;
			this.buttonPrintReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox2.Add(this.buttonPrintReport);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.buttonPrintReport]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonPrintReport.Clicked += new global::System.EventHandler(this.OnButtonPrintReportClicked);
		}
	}
}

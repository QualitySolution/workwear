
// This file has been generated by the GUI designer. Do not modify.
namespace workwear.ReportsDlg
{
	public partial class AmountIssuedWearDlg
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label1;

		private global::Gamma.Widgets.yDatePeriodPicker ydateperiodpicker;

		private global::Gtk.Button buttonPrintReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.ReportsDlg.AmountIssuedWearDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.ReportsDlg.AmountIssuedWearDlg";
			// Container child workwear.ReportsDlg.AmountIssuedWearDlg.Gtk.Container+ContainerChild
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
			this.buttonPrintReport = new global::Gtk.Button();
			this.buttonPrintReport.Sensitive = false;
			this.buttonPrintReport.CanFocus = true;
			this.buttonPrintReport.Name = "buttonPrintReport";
			this.buttonPrintReport.UseUnderline = true;
			this.buttonPrintReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox2.Add(this.buttonPrintReport);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.buttonPrintReport]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.ydateperiodpicker.PeriodChanged += new global::System.EventHandler(this.OnYdateperiodpickerPeriodChanged);
			this.buttonPrintReport.Clicked += new global::System.EventHandler(this.OnButtonPrintReportClicked);
		}
	}
}
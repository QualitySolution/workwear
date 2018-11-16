
// This file has been generated by the GUI designer. Do not modify.
namespace workwear
{
	public partial class NotIssuedSheetReportDlg
	{
		private global::Gtk.VBox dialog1_VBox;

		private global::Gtk.Table table1;

		private global::Gtk.CheckButton checkOnlyMissing;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.yDatePicker ydateReport;

		private global::Gtk.Button buttonRun;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget workwear.NotIssuedSheetReportDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "workwear.NotIssuedSheetReportDlg";
			// Container child workwear.NotIssuedSheetReportDlg.Gtk.Container+ContainerChild
			this.dialog1_VBox = new global::Gtk.VBox();
			this.dialog1_VBox.Name = "dialog1_VBox";
			this.dialog1_VBox.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkOnlyMissing = new global::Gtk.CheckButton();
			this.checkOnlyMissing.CanFocus = true;
			this.checkOnlyMissing.Name = "checkOnlyMissing";
			this.checkOnlyMissing.Label = global::Mono.Unix.Catalog.GetString("Только полностью невыданное");
			this.checkOnlyMissing.DrawIndicator = true;
			this.checkOnlyMissing.UseUnderline = true;
			this.table1.Add(this.checkOnlyMissing);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.checkOnlyMissing]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Дата отчета:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.WidthRequest = 250;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<i>Обратите внимание:</i> Отчет показывает недополученное по текущим потребностям" +
					". То есть при значительном удалении даты отчет от сегодняшнего дня, данные будут" +
					" некорретны.");
			this.label2.UseMarkup = true;
			this.label2.Wrap = true;
			this.label2.Justify = ((global::Gtk.Justification)(3));
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ydateReport = new global::Gamma.Widgets.yDatePicker();
			this.ydateReport.Events = ((global::Gdk.EventMask)(256));
			this.ydateReport.Name = "ydateReport";
			this.ydateReport.WithTime = false;
			this.ydateReport.Date = new global::System.DateTime(0);
			this.ydateReport.IsEditable = true;
			this.ydateReport.AutoSeparation = true;
			this.table1.Add(this.ydateReport);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.ydateReport]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.dialog1_VBox.Add(this.table1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.table1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.buttonRun = new global::Gtk.Button();
			this.buttonRun.Sensitive = false;
			this.buttonRun.CanFocus = true;
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.UseUnderline = true;
			this.buttonRun.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.dialog1_VBox.Add(this.buttonRun);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.buttonRun]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.dialog1_VBox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.ydateReport.DateChanged += new global::System.EventHandler(this.OnYdateReportDateChanged);
			this.buttonRun.Clicked += new global::System.EventHandler(this.OnButtonRunClicked);
		}
	}
}

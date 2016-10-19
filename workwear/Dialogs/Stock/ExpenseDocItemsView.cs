using System;
using System.Collections.Generic;
using System.Linq;
using Gamma.ColumnConfig;
using Gamma.Utilities;
using Gtk;
using NLog;
using QSOrmProject;
using workwear.Domain;
using workwear.Domain.Stock;

namespace workwear
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ExpenseDocItemsView : WidgetOnDialogBase
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		private Expense expenceDoc;

		public Expense ExpenceDoc {
			get {return expenceDoc;}
			set {
				if (expenceDoc == value)
					return;
				if(expenceDoc != null)
				{
					expenceDoc.PropertyChanged -= ExpenceDoc_PropertyChanged;
				}
				expenceDoc = value;
				if(expenceDoc != null)
				{
					expenceDoc.PropertyChanged += ExpenceDoc_PropertyChanged;
				}
				ytreeItems.ItemsDataSource = expenceDoc.ObservableItems;
				ExpenceDoc_PropertyChanged(expenceDoc, new System.ComponentModel.PropertyChangedEventArgs(expenceDoc.GetPropertyName(x => x.Operation)));
				if(ExpenceDoc.Operation == ExpenseOperations.Object)
					ExpenceDoc_PropertyChanged(expenceDoc, new System.ComponentModel.PropertyChangedEventArgs(expenceDoc.GetPropertyName(x => x.Facility)));
			}
		}

		void ExpenceDoc_PropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == ExpenceDoc.GetPropertyName(x => x.Facility))
			{
				var placeColumn = ytreeItems.ColumnsConfig.ConfiguredColumns.FirstOrDefault(x => x.Title == "Расположение");
				var placeRenderer = placeColumn.ConfiguredRenderers.First() as ComboRendererMapping<ExpenseItem>;
				if(ExpenceDoc.Facility != null)
				{
					placeRenderer.FillItems(ExpenceDoc.Facility.Places);
				}
				else
				{
					placeRenderer.FillItems(new List<FacilityPlace> ());
				}
			}

			if(e.PropertyName == ExpenceDoc.GetPropertyName(x => x.Operation))
			{
				var placeColumn = ytreeItems.Columns.FirstOrDefault(x => x.Title == "Расположение");
				placeColumn.Visible = ExpenceDoc.Operation == ExpenseOperations.Object;
			}
		}

		public ExpenseDocItemsView()
		{
			this.Build();

			ytreeItems.ColumnsConfig = Gamma.GtkWidgets.ColumnsConfigFactory.Create<ExpenseItem> ()
				.AddColumn ("Наименование").AddTextRenderer (e => e.Nomenclature.Name)
				.AddColumn ("Размер").AddTextRenderer (e => e.Nomenclature.Size)
				.AddColumn ("Рост").AddTextRenderer (e => e.Nomenclature.WearGrowth)
				.AddColumn ("Состояние").AddTextRenderer (e => (e.IncomeOn.LifePercent).ToString ("P0"))
				.AddColumn ("Количество").AddNumericRenderer (e => e.Amount).Editing (new Adjustment(0, 0, 100000, 1, 10, 1))
					.AddTextRenderer (e => e.Nomenclature.Type.Units.Name)
				.AddColumn ("Расположение").AddComboRenderer (e => e.FacilityPlace).Editing()
					.SetDisplayFunc(x => (x as FacilityPlace) != null ? (x as FacilityPlace).Name : String.Empty)
				.Finish ();
			ytreeItems.Selection.Changed += YtreeItems_Selection_Changed;
		}

		void YtreeItems_Selection_Changed (object sender, EventArgs e)
		{
			buttonDel.Sensitive = ytreeItems.Selection.CountSelectedRows () > 0;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			var selectDlg = new ReferenceRepresentation (new ViewModel.StockBalanceVM (MyOrmDialog.UoW,
				ExpenceDoc.Operation == ExpenseOperations.Employee ? ViewModel.StockBalanceVMMode.DisplayAll : ViewModel.StockBalanceVMMode.OnlyProperties
			));
			selectDlg.Mode = OrmReferenceMode.MultiSelect;
			selectDlg.ObjectSelected += SelectDlg_ObjectSelected;

			var dialog = new OneWidgetDialog (selectDlg);
			dialog.Show ();
			dialog.Run ();
			dialog.Destroy ();
		}

		void SelectDlg_ObjectSelected (object sender, ReferenceRepresentationSelectedEventArgs e)
		{
			foreach(var node in e.GetNodes<ViewModel.StockBalanceVMNode> ())
			{
				ExpenceDoc.AddItem (MyOrmDialog.UoW.GetById<IncomeItem> (node.Id));
			}
			CalculateTotal();
		}

		protected void OnButtonDelClicked (object sender, EventArgs e)
		{
			ExpenceDoc.RemoveItem (ytreeItems.GetSelectedObject<ExpenseItem> ());
			CalculateTotal();
		}

		private void CalculateTotal()
		{
			labelSum.Text = String.Format ("Количество: {0}", ExpenceDoc.Items.Count);
		} 
	}
}


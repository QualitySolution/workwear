﻿using System;
using System.Data.Bindings.Utilities;
using System.Linq;
using Gtk;
using QSWidgetLib;
using workwear.Domain.Stock;
using workwear.Measurements;
using workwear.ViewModels.Stock;

namespace workwear.Views.Stock
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ExpenseDocItemEmployeeView : Gtk.Bin
	{
		private enum ColumnTags
		{
			FacilityPlace,
			BuhDoc
		}

		public ExpenseDocItemEmployeeView()
		{
			this.Build();
		}

		private ExpenseDocItemsEmployeeViewModel viewModel;

		public ExpenseDocItemsEmployeeViewModel ViewModel {
			get => viewModel;
			set {
				viewModel = value;
				Configure();
			}
		}

		public void Configure()
		{
			CreateTable();
			ytreeItems.ItemsDataSource = ViewModel.ObservableItems;
			ytreeItems.Selection.Changed += YtreeItems_Selection_Changed;
			ytreeItems.ButtonReleaseEvent += YtreeItems_ButtonReleaseEvent;

			ExpenseDoc_PropertyChanged(ViewModel.expenseEmployeeViewModel.Entity, new System.ComponentModel.PropertyChangedEventArgs(ViewModel.expenseEmployeeViewModel.Entity.GetPropertyName(x => x.Operation)));

			buttonAdd.Sensitive = ViewModel.Warehouse != null;

			ViewModel.expenseEmployeeViewModel.Entity.PropertyChanged += ExpenseDoc_PropertyChanged;

			ViewModel.PropertyChanged += PropertyChanged;
			ViewModel.CalculateTotal();
		}

		void CreateTable()
		{
			ytreeItems.ColumnsConfig = Gamma.GtkWidgets.ColumnsConfigFactory.Create<ExpenseItem>()
				.AddColumn("Номенаклатуры ТОН").AddTextRenderer(node => node.ProtectionTools != null ? node.ProtectionTools.Name : "")
				.AddColumn("Номенклатура").AddComboRenderer(x => x.StockBalanceSetter)
				.SetDisplayFunc(x => x.Nomenclature?.Name)
					.SetDisplayListFunc(x => x.StockPosition.Title + " - " + x.Nomenclature.GetAmountAndUnitsText(x.Amount))
					.DynamicFillListFunc(x => x.EmployeeCardItem.BestChoiceInStock.ToList())
					.AddSetter((c, n) => c.Editable = n.EmployeeCardItem != null)
				.AddColumn("Размер")
					.AddComboRenderer(x => x.Size)
					.DynamicFillListFunc(x => SizeHelper.GetSizesListByStdCode(x.Nomenclature.SizeStd, SizeUse.HumanOnly))
					.AddSetter((c, n) => c.Editable = n.Nomenclature?.SizeStd != null && n.EmployeeCardItem == null)
				.AddColumn("Рост")
					.AddComboRenderer(x => x.WearGrowth)
					.DynamicFillListFunc(x => SizeHelper.GetSizesListByStdCode(x.Nomenclature.WearGrowthStd, SizeUse.HumanOnly))
					.AddSetter((c, n) => c.Editable = n.Nomenclature?.WearGrowthStd != null && n.EmployeeCardItem == null)
				.AddColumn("Процент износа").AddTextRenderer(e => (e.WearPercent).ToString("P0"))
				.AddColumn("Количество").AddNumericRenderer(e => e.Amount).Editing(new Adjustment(0, 0, 100000, 1, 10, 1))
					.AddTextRenderer(e => e.Nomenclature != null && e.Nomenclature.Type != null && e.Nomenclature.Type.Units != null ? e.Nomenclature.Type.Units.Name : null)
				.AddColumn("Списание").AddToggleRenderer(e => e.IsWriteOff).Editing()
				.AddSetter((c, e) => c.Visible = e.IsEnableWriteOff)
				.AddColumn("Номер акта").AddTextRenderer(e => e.AktNumber).Editable().AddSetter((c, e) => c.Visible = e.IsWriteOff)
				.AddColumn("Бухгалтерский документ").Tag(ColumnTags.BuhDoc).AddTextRenderer(e => e.BuhDocument).Editable()
				.AddColumn("")
				.RowCells().AddSetter<CellRendererText>((c, n) => c.Foreground = GetRowColor(n))
				.Finish();
		}

		#region PopupMenu
		void YtreeItems_ButtonReleaseEvent(object o, ButtonReleaseEventArgs args)
		{
			if(args.Event.Button == 3) {
				var menu = new Menu();
				var selected = ytreeItems.GetSelectedObject<ExpenseItem>();
				var item = new MenuItemId<ExpenseItem>("Открыть номеклатуру");
				item.ID = selected;
				item.Activated += Item_Activated;
				menu.Add(item);
				menu.ShowAll();
				menu.Popup();
			}
		}

		void Item_Activated(object sender, EventArgs e)
		{
			var item = (sender as MenuItemId<ExpenseItem>).ID;
			viewModel.OpenNomenclature(item.Nomenclature);
		}
		#endregion

		#region private

		private string GetRowColor(ExpenseItem item)
		{
			if(item.EmployeeCardItem?.NeededAmount > 0 && item.Nomenclature == null)
				return item.Amount == 0 ? "red" : "Dark red";
			if(item.EmployeeCardItem?.NeededAmount > 0 && item.Amount == 0)
				return "blue";
			if(item.EmployeeCardItem?.NeededAmount <= 0 && item.Amount == 0)
				return "gray";
			return null;
		}

		void SetSum()
		{
			labelSum.Markup = viewModel.Sum;
			buttonFillBuhDoc.Sensitive = ViewModel.SensetiveFillBuhDoc;
		}

		#endregion

		#region События
		void ExpenseDoc_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == ViewModel.GetPropertyName(x => x.Operation)) {

				var buhDocColumn = ytreeItems.ColumnsConfig.GetColumnsByTag(ColumnTags.BuhDoc).First();
				buhDocColumn.Visible = ViewModel.Operation == ExpenseOperations.Employee;

				buttonFillBuhDoc.Visible = ViewModel.Operation == ExpenseOperations.Employee;
			}
			if(e.PropertyName == nameof(ViewModel.Warehouse))
				buttonAdd.Sensitive = ViewModel.Warehouse != null;
		}

		void PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			SetSum();
		}
		#endregion

		#region Кнопки
		protected void OnButtonFillBuhDocClicked(object sender, EventArgs e)
		{
			ViewModel.FillBuhDoc();
		}

		protected void OnButtonDelClicked(object sender, EventArgs e)
		{
			viewModel.Delete(ytreeItems.GetSelectedObject<ExpenseItem>());
		}

		void YtreeItems_Selection_Changed(object sender, EventArgs e)
		{
			buttonDel.Sensitive = buttonShowAllSize.Sensitive = ytreeItems.Selection.CountSelectedRows() > 0;
		}

		protected void OnButtonAddClicked(object sender, EventArgs e)
		{
			ViewModel.AddItem();
		}

		protected void OnButtonShowAllSizeClicked(object sender, EventArgs e)
		{
			viewModel.ShowAllSize(ytreeItems.GetSelectedObject<ExpenseItem>());
		}
		#endregion
	}

}

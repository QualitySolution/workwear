﻿using System;
using System.Linq;
using Gamma.Utilities;
using QS.Utilities;
using workwear.Domain.Company;
using workwear.ViewModels.Company.EmployeeChilds;

namespace workwear.Views.Company.EmployeeChilds
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class EmployeeWearItemsView : Gtk.Bin
	{
		public EmployeeWearItemsView()
		{
			this.Build();

			ytreeWorkwear.ColumnsConfig = Gamma.GtkWidgets.ColumnsConfigFactory.Create<EmployeeCardItem>()
				.AddColumn("ТОН").AddTextRenderer(node => node.ActiveNormItem.Norm.TONParagraph)
				.AddColumn("Наименование").AddTextRenderer(node => node.Item.Name)
				.AddColumn("По норме").AddTextRenderer(node => node.Item.Units.MakeAmountShortStr(node.ActiveNormItem.Amount))
				.AddColumn("Срок службы").AddTextRenderer(node => node.ActiveNormItem.LifeText)
				.AddColumn("Дата получения").AddTextRenderer(node => String.Format("{0:d}", node.LastIssue))
				.AddColumn("Получено").AddTextRenderer(node => node.Item.Units.MakeAmountShortStr(node.Amount))
					.AddSetter((w, node) => w.Foreground = node.AmountColor)
				.AddColumn("След. получение").AddTextRenderer(node => String.Format("{0:d}", node.NextIssue))
				.AddColumn("Просрочка").AddTextRenderer(
					node => node.NextIssue.HasValue && node.NextIssue.Value < DateTime.Today
					? NumberToTextRus.FormatCase((int)(DateTime.Today - node.NextIssue.Value).TotalDays, "{0} день", "{0} дня", "{0} дней")
					: String.Empty)
				.AddColumn("На складе").AddTextRenderer(node => node.InStock != null ? node.Item.Units.MakeAmountShortStr(node.InStock.Sum(x => x.Amount)) : null)
				 .AddSetter((w, node) => w.Foreground = node.InStockState.GetEnumColor())
				.AddColumn("Подходящая номенклатура").AddTextRenderer(node => node.MatchedNomenclatureShortText)
				.AddSetter((w, node) => w.Foreground = node.InStockState.GetEnumColor())
				.Finish();
			ytreeWorkwear.Selection.Changed += ytreeWorkwear_Selection_Changed;
		}

		private EmployeeWearItemsViewModel viewModel;

		public EmployeeWearItemsViewModel ViewModel {
			get => viewModel;
			set {
				viewModel = value;
				viewModel.PropertyChanged += ViewModel_PropertyChanged;
			}
		}

		void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(ViewModel.ObservableWorkwearItems)) {
				ytreeWorkwear.ItemsDataSource = ViewModel.ObservableWorkwearItems;
			}
		}

		protected void OnButtonGiveWearByNormClicked(object sender, EventArgs e)
		{
			ViewModel.GiveWearByNorm();
		}

		void ytreeWorkwear_Selection_Changed(object sender, EventArgs e)
		{
			buttonTimeLine.Sensitive = ytreeWorkwear.Selection.CountSelectedRows() > 0;
		}

		protected void OnButtonReturnWearClicked(object sender, EventArgs e)
		{
			viewModel.ReturnWear();
		}

		protected void OnButtonTimeLineClicked(object sender, EventArgs e)
		{
			ViewModel.OpenTimeLine(ytreeWorkwear.GetSelectedObject<EmployeeCardItem>());
		}

		protected void OnButtonWriteOffWearClicked(object sender, EventArgs e)
		{
			ViewModel.WriteOffWear();
		}
	}
}
﻿using System;
using Gamma.Binding.Converters;
using QS.Dialog.GtkUI;
using QS.Project.Domain;
using QS.Views.Dialog;
using workwear.Domain.Stock;
using workwear.ViewModels.Statements;
using workwear.ViewModels.Stock;

namespace workwear.Views.Stock
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ExpenseObjectView : EntityDialogViewBase<ExpenseObjectViewModel, Expense>
	{
		public ExpenseObjectView(ExpenseObjectViewModel viewModel) : base(viewModel)
		{
			this.Build();
			ConfigureDlg();
			IssuanceSheetSensetive();
		}

		private void ConfigureDlg()
		{
			expensedocitemobjectview1.ViewModel = ViewModel.DocItemsObjectViewModel;

			ylabelId.Binding.AddBinding(Entity, e => e.Id, w => w.LabelProp, new IdToStringConverter()).InitializeFromSource();

			ylabelCreatedBy.Binding.AddFuncBinding(Entity, e => e.CreatedbyUser.Name, w => w.LabelProp).InitializeFromSource();

			ydateDoc.Binding.AddBinding(Entity, e => e.Date, w => w.Date).InitializeFromSource();

			ycomboOperation.ItemsEnum = typeof(ExpenseOperations);
			ycomboOperation.SelectedItem = ExpenseOperations.Object;
			ycomboOperation.Sensitive = false;

			ytextComment.Binding.AddBinding(Entity, e => e.Comment, w => w.Buffer.Text).InitializeFromSource();

			entityWarehouseExpense.ViewModel = ViewModel.WarehouseExpenceViewModel;
			entitySubdivision.ViewModel = ViewModel.SubdivisionViewModel;

			IssuanceSheetSensetive();
		}

		private void IssuanceSheetSensetive()
		{
			buttonIssuanceSheetCreate.Visible = Entity.IssuanceSheet == null;
			buttonIssuanceSheetOpen.Visible = buttonIssuanceSheetPrint.Visible = Entity.IssuanceSheet != null;
		}
		protected void OnButtonIssuanceSheetCreateClicked(object sender, EventArgs e)
		{
			ViewModel.CreateIssuenceSheet();
			IssuanceSheetSensetive();
		}
		protected void OnButtonIssuanceSheetOpenClicked(object sender, EventArgs e)
		{
			ViewModel.OpenIssuenceSheet();
		}
		protected void OnButtonIssuanceSheetPrintClicked(object sender, EventArgs e)
		{
			ViewModel.PrintIssuenceSheet();
		}
	}
}
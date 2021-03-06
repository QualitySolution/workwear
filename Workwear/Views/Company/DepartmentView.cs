﻿using System;
using QS.Views.Dialog;
using workwear.Domain.Company;
using workwear.ViewModels.Company;

namespace workwear.Views.Company
{

	public partial class DepartmentView : EntityDialogViewBase<DepartmentViewModel, Department>
	{
		public DepartmentView(DepartmentViewModel viewModel) : base(viewModel)
		{
			this.Build();
			ConfigureDlg();
			CommonButtonSubscription();
		}

		void ConfigureDlg()
		{
			entryName.Binding.AddBinding(Entity, e => e.Name, w => w.Text).InitializeFromSource();
			entitySubdivision.ViewModel = ViewModel.EntrySubdivision;
			ytextComments.Binding.AddBinding(Entity, e => e.Comments, w => w.Buffer.Text).InitializeFromSource();
		}

	}
}

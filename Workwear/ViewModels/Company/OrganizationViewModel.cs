﻿using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Domain;
using QS.Validation;
using QS.ViewModels.Dialog;
using workwear.Domain.Company;

namespace workwear.ViewModels.Company
{
	public class OrganizationViewModel : EntityDialogViewModelBase<Organization>
	{
		public OrganizationViewModel(IEntityUoWBuilder uowBuilder, IUnitOfWorkFactory unitOfWorkFactory, INavigationManager navigation, IValidator validator) : base(uowBuilder, unitOfWorkFactory, navigation, validator)
		{
		}
	}
}

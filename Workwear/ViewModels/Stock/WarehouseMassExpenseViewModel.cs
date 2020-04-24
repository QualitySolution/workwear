﻿using System;
using System.Linq;
using Autofac;
using QS.Dialog;
using QS.DomainModel.NotifyChange;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Domain;
using QS.Services;
using QS.Tdi;
using QS.Validation;
using QS.ViewModels.Control.EEVM;
using QS.ViewModels.Dialog;
using QSOrmProject;
using workwear.Domain.Company;
using workwear.Domain.Stock;
using workwear.Journal.ViewModels.Stock;

namespace workwear.ViewModels.Stock
{
	public class WarehouseMassExpenseViewModel : LegacyEntityDialogViewModelBase<MassExpense>
	{
		public EntityEntryViewModel<Warehouse> WarehouseFromEntryViewModel;
		public ILifetimeScope AutofacScope;
		private readonly IInteractiveMessage interactive;
		public ITdiCompatibilityNavigation tdiNavigationManager;

		private string displayMessage;
		public virtual string DisplayMessage {
			get { return displayMessage; }
			set { SetField(ref displayMessage, value); }
		}

		public WarehouseMassExpenseViewModel(IEntityUoWBuilder uowBuilder, IUnitOfWorkFactory unitOfWorkFactory, ITdiTab myTab, ITdiCompatibilityNavigation navigationManager, ILifetimeScope autofacScope, IInteractiveMessage interactive, IUserService userService, IValidator validator = null) : base(uowBuilder, unitOfWorkFactory, myTab, navigationManager, validator)
		{
			this.tdiNavigationManager = navigationManager ?? throw new ArgumentNullException(nameof(navigationManager));
			this.AutofacScope = autofacScope ?? throw new ArgumentNullException(nameof(autofacScope));
			this.interactive = interactive ?? throw new ArgumentNullException(nameof(interactive));
			if(UoW.IsNew)
				Entity.CreatedbyUser = userService.GetCurrentUser(UoW);

			var entryBuilder = new LegacyEEVMBuilderFactory<MassExpense>(this, TdiTab, Entity, UoW, navigationManager) {
				AutofacScope = AutofacScope
			};

			WarehouseFromEntryViewModel = entryBuilder.ForProperty(x => x.WarehouseFrom)
										 .UseViewModelJournalAndAutocompleter<WarehouseJournalViewModel>()
										 .UseViewModelDialog<WarehouseViewModel>()
										 .Finish();

			Entity.ObservableItemsNomenclature.ListContentChanged += ObservableItemsNomenclature_ListContentChanged;
			Entity.ObservableEmployeeCard.ListContentChanged += ObservableItemsNomenclature_ListContentChanged;
		}

		void ObservableItemsNomenclature_ListContentChanged(object sender, EventArgs e)
		{
			ValidateNomenclature();
		}

		void ValidateNomenclature()
		{
			DisplayMessage = $"<span foreground=\"red\">{Entity.ValidateNomenclature(UoW)}</span>";
		}

		#region Nomenclature
		public void AddNomenclature()
		{
			var selectPage = tdiNavigationManager.OpenTdiTab<OrmReference, Type>(TdiTab, typeof(Nomenclature), OpenPageOptions.AsSlave);

			var selectDialog = selectPage.TdiTab as OrmReference;
			selectDialog.Mode = OrmReferenceMode.MultiSelect;
			selectDialog.ObjectSelected += Nomenclature_ObjectSelected;
		}
		void Nomenclature_ObjectSelected(object sender, OrmReferenceObjectSectedEventArgs e)
		{
			foreach(var nomenclature in e.GetEntities<Nomenclature>()) {
				Entity.AddItemNomenclature(nomenclature, interactive, UoW);
			}
		}

		public void RemoveNomenclature(MassExpenseNomenclature[] noms)
		{
			foreach(var nom in noms) {
				Entity.ObservableItemsNomenclature.Remove(nom);
			}
		}

		#endregion

		#region Employee
		public void AddEmployee()
		{
			var selectPage = tdiNavigationManager.OpenTdiTab<OrmReference, Type>(TdiTab, typeof(EmployeeCard), OpenPageOptions.AsSlave);

			var selectDialog = selectPage.TdiTab as OrmReference;
			selectDialog.Mode = OrmReferenceMode.MultiSelect;
			selectDialog.ObjectSelected += Employee_ObjectSelected;
		}
		void Employee_ObjectSelected(object sender, OrmReferenceObjectSectedEventArgs e)
		{
			foreach(var emp in e.GetEntities<EmployeeCard>()) {
				Entity.AddEmployee(emp, interactive);
			}
		}

		public void AddNewEmployee()
		{
			var newEmployee = new EmployeeCard();
			newEmployee.FirstName = "-";
			newEmployee.LastName = "-";
			newEmployee.Patronymic = "-";
			if (!Entity.Employees.Any(x=> x.EmployeeCard.FirstName == "-" && x.EmployeeCard.LastName == "-"))
				Entity.AddEmployee(newEmployee, interactive);
		}

		public void RemoveEmployee(MassExpenseEmployee[] employees)
		{
			foreach(var emp in employees) {
				Entity.ObservableEmployeeCard.Remove(Entity.Employees.First(x => x == emp));
			}
		}

		#endregion

		protected override bool Validate()
		{
			foreach(var emp in Entity.Employees) {
				emp.EmployeeCard.FirstName.Replace("-", "");
				emp.EmployeeCard.LastName.Replace("-", "");
				emp.EmployeeCard.Patronymic.Replace("-", "");
			}

			var valid = base.Validate();
			if(!valid)
				return valid;


			Entity.UpdateOperations(UoW, null);
			return true;
		}

		public override void Dispose()
		{
			base.Dispose();
			NotifyConfiguration.Instance.UnsubscribeAll(this);
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using NHibernate;
using QS.DomainModel.Entity;
using QS.DomainModel.NotifyChange;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Domain;
using QS.ViewModels;
using workwear.Dialogs.Issuance;
using workwear.Domain.Company;
using workwear.Domain.Regulations;
using workwear.ViewModels.Stock;

namespace workwear.ViewModels.Company.EmployeeChilds
{
	public class EmployeeWearItemsViewModel : ViewModelBase, IDisposable
	{
		private readonly EmployeeViewModel employeeViewModel;
		private readonly ITdiCompatibilityNavigation navigation;

		public EmployeeWearItemsViewModel(EmployeeViewModel employeeViewModel, ITdiCompatibilityNavigation navigation)
		{
			this.employeeViewModel = employeeViewModel ?? throw new ArgumentNullException(nameof(employeeViewModel));
			this.navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
			NotifyConfiguration.Instance.BatchSubscribeOnEntity<EmployeeCardItem>(HandleEntityChangeEvent);
		}

		#region Хелперы

		private IUnitOfWork UoW => employeeViewModel.UoW;
		private EmployeeCard Entity => employeeViewModel.Entity;

		#endregion

		#region Показ
		private bool isConfigured = false;

		public void OnShow()
		{
			if(!isConfigured) {
				isConfigured = true;
				Entity.FillWearInStockInfo(UoW, Entity.Subdivision?.Warehouse, DateTime.Now);
				Entity.FillWearRecivedInfo(UoW);
				OnPropertyChanged(nameof(ObservableWorkwearItems));
			}
		}

		#endregion

		#region Свойства

		public GenericObservableList<EmployeeCardItem> ObservableWorkwearItems => Entity.ObservableWorkwearItems;

		#endregion

		#region Внутренне
		void HandleEntityChangeEvent(EntityChangeEvent[] changeEvents)
		{
			if(changeEvents.Select(e => e.Entity).OfType<EmployeeCardItem>().Any(x => x.EmployeeCard.IsSame(Entity)))
				RefreshWorkItems();
		}

		#endregion

		#region Действия View

		public void GiveWearByNorm()
		{
			if(!employeeViewModel.Save())
				return;
			navigation.OpenViewModel<ExpenseEmployeeViewModel, IEntityUoWBuilder, EmployeeCard>(employeeViewModel, EntityUoWBuilder.ForCreate(), Entity);
		}

		public void ReturnWear()
		{
			navigation.OpenTdiTab<IncomeDocDlg, EmployeeCard>(employeeViewModel, Entity);
		}

		public void OpenTimeLine(EmployeeCardItem item)
		{
			navigation.OpenTdiTab<EmployeeIssueGraphDlg, EmployeeCard, ProtectionTools>(employeeViewModel, Entity, item.ProtectionTools);
		}

		public void WriteOffWear()
		{
			navigation.OpenTdiTab<WriteOffDocDlg, EmployeeCard>(employeeViewModel, Entity);
		}

		public void UpdateWorkwearItems()
		{
			Entity.UpdateWorkwearItems();
		}

		#endregion
		protected void RefreshWorkItems()
		{
			if(!NHibernateUtil.IsInitialized(Entity.WorkwearItems))
				return;

			foreach(var item in Entity.WorkwearItems) {
				UoW.Session.Refresh(item);
			}
			Entity.FillWearInStockInfo(UoW, Entity.Subdivision?.Warehouse, DateTime.Now);
			Entity.FillWearRecivedInfo(UoW);
		}

		public void Dispose()
		{
			NotifyConfiguration.Instance.UnsubscribeAll(this);
		}
	}
}

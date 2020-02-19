﻿using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using QS.Utilities.Numeric;

namespace workwear.Domain.Stock
{
	public class WarehouseOperation : PropertyChangedBase, IDomainObject
	{

		public virtual int Id { get; set; }

		DateTime operationTime;


		public virtual DateTime OperationTime {
			get { return operationTime; }
			set { SetField(ref operationTime, value); }
		}

		Warehouse receiptWarehouse;

		[Display(Name = "Склад прихода")]
		public virtual Warehouse ReceiptWarehouse {
			get { return receiptWarehouse; }
			set { SetField(ref receiptWarehouse, value); }
		}

		Warehouse expenseWarehouse;

		[Display(Name = "Склад расхода")]
		public virtual Warehouse ExpenseWarehouse {
			get { return expenseWarehouse; }
			set { SetField(ref expenseWarehouse, value); }
		}


		Nomenclature nomenclature;

		[Display(Name = "Номеклатура")]
		public virtual Nomenclature Nomenclature {
			get { return nomenclature; }
			set { SetField(ref nomenclature, value); }
		}


		string size;

		[Display(Name ="Размер")]
		public virtual string Size {
			get { return size; }
			set { SetField(ref size, value); }
		}


		string growth;

		[Display(Name = "Рост")]
		public virtual string Growth {
			get { return growth; }
			set { SetField(ref growth, value); }
		}


		int amount;

		[Display(Name = "Количество")]
		public virtual int Amount {
			get { return amount; }
			set { SetField(ref amount, value); }
		}

		private decimal wearPercent;

		[Display(Name = "Процент износа")]
		public virtual decimal WearPercent {
			get { return wearPercent; }
			set { SetField(ref wearPercent, value.Clamp(0m, 9.99m)); }
		}


		#region Методы обновления операций

		public virtual void Update(IUnitOfWork uow, ExpenseItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if(item.ExpenseDoc.Date.Date != OperationTime.Date)
				OperationTime = item.ExpenseDoc.Date;

			expenseWarehouse = item.ExpenseDoc.Warehouse;
			nomenclature = item.Nomenclature;
			size = item.Nomenclature.Size;
			growth = item.Nomenclature.WearGrowth;
			amount = item.Amount;
		}

		public virtual void Update(IUnitOfWork uow, IncomeItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if(item.Document.Date.Date != OperationTime.Date)
				OperationTime = item.Document.Date;

			receiptWarehouse = item.Document.Warehouse;
			nomenclature = item.Nomenclature;
			size = item.Nomenclature.Size;
			growth =item.Nomenclature.WearGrowth;
			amount = item.Amount;
		}

		public virtual void Update(IUnitOfWork uow, WriteoffItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if(item.Document.Date.Date != OperationTime.Date)
				OperationTime = item.Document.Date;

			receiptWarehouse = item.Document.Warehouse;
			nomenclature = item.Nomenclature;
			size = item.Nomenclature.Size;
			growth = item.Nomenclature.WearGrowth;
			amount = item.Amount;
		}

		public virtual void Update(IUnitOfWork uow, TransferItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if(item.Document.Date.Date != OperationTime.Date)
				OperationTime = item.Document.Date;

			receiptWarehouse = item.Document.WarehouseFrom;
			expenseWarehouse = item.Document.WarehouseTo;
			nomenclature = item.Nomenclature;
			size = item.Nomenclature.Size;
			growth = item.Nomenclature.WearGrowth;
			amount = item.Amount;
		}

		#endregion
	}
}
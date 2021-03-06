﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.Dialog;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using workwear.Domain.Company;
using workwear.Domain.Operations;
using workwear.Domain.Operations.Graph;
using workwear.Domain.Regulations;
using workwear.Domain.Statements;
using workwear.Repository.Stock;
using workwear.Tools;

namespace workwear.Domain.Stock
{
	[Appellative (Gender = GrammaticalGender.Feminine,
		NominativePlural = "строки выдачи",
		Nominative = "строка выдачи")]
	public class ExpenseItem : PropertyChangedBase, IDomainObject
	{
		#region Сохраняемые свойства

		public virtual int Id { get; set; }

		Expense expenseDoc;

		[Display (Name = "Документ")]
		public virtual Expense ExpenseDoc {
			get { return expenseDoc; }
			set { SetField (ref expenseDoc, value, () => ExpenseDoc); }
		}

		ProtectionTools protectionTools;

		[Display(Name = "Номенклатура ТОН")]
		public virtual ProtectionTools ProtectionTools {
			get { return protectionTools; }
			set { SetField(ref protectionTools, value, () => ProtectionTools); }
		}

		Nomenclature nomenclature;

		[Display (Name = "Номеклатура")]
		public virtual Nomenclature Nomenclature {
			get { return nomenclature; }
			set { SetField (ref nomenclature, value, () => Nomenclature); }
		}

		private IssuanceSheetItem issuanceSheetItem;
		[Display(Name = "Строка ведомости")]
		public virtual IssuanceSheetItem IssuanceSheetItem {
			get => issuanceSheetItem;
			set => SetField(ref issuanceSheetItem, value);
		}

		int amount;

		[Display (Name = "Количество")]
		public virtual int Amount {
			get { return amount; }
			set { SetField (ref amount, value, () => Amount); }
		}

		SubdivisionPlace subdivisionPlace;

		[Display (Name = "Размещение в подразделении")]
		public virtual SubdivisionPlace SubdivisionPlace {
			get { return subdivisionPlace; }
			set { SetField (ref subdivisionPlace, value, () => SubdivisionPlace); }
		}

		private EmployeeIssueOperation employeeIssueOperation;

		[Display(Name = "Операция выдачи сотруднику")]
		public virtual EmployeeIssueOperation EmployeeIssueOperation
		{
			get { return employeeIssueOperation; }
			set { SetField(ref employeeIssueOperation, value); }
		}

		private SubdivisionIssueOperation subdivisionIssueOperation;

		[Display(Name = "Операция выдачи на подразделение")]
		public virtual SubdivisionIssueOperation SubdivisionIssueOperation {
			get { return subdivisionIssueOperation; }
			set { SetField(ref subdivisionIssueOperation, value); }
		}

		private WarehouseOperation warehouseOperation = new WarehouseOperation();
		[Display(Name = "Операция на складе")]
		public virtual WarehouseOperation WarehouseOperation {
			get { return warehouseOperation; }
			set { SetField(ref warehouseOperation, value);}
		}

		string size;

		[Display(Name = "Размер")]
		public virtual string Size {
			get { return size; }
			set { SetField(ref size, value, () => Size); }
		}

		string wearGrowth;

		[Display(Name = "Рост одежды")]
		public virtual string WearGrowth {
			get { return wearGrowth; }
			set { SetField(ref wearGrowth, value, () => WearGrowth); }
		}

		#endregion

		#region Не сохраняемые в базу свойства

		private bool isWriteOff;
		[Display(Name = "Выдача по списанию")]
		public virtual bool IsWriteOff {
			get => isWriteOff;
			set => isWriteOff = value;
		}

		string aktNumber;
		[Display(Name = "Номер акта")]
		public virtual string AktNumber {
			get => IsWriteOff ? aktNumber : null;
			set => SetField(ref aktNumber, value);
		}

		public virtual bool IsEnableWriteOff { get; set; }

		private string buhDocument;

		[Display(Name = "Документ бухгалтерского учета")]
		//В этом классе используется только для рантайма, в базу не сохраняется, сохраняется внутри операции.
		public virtual string BuhDocument
		{
			get { return buhDocument ?? EmployeeIssueOperation?.BuhDocument; }
			set { SetField(ref buhDocument, value); }
		}

		[Display(Name = "Процент износа")]
		public virtual decimal WearPercent {
			get => WarehouseOperation.WearPercent;
			set => WarehouseOperation.WearPercent = value;
		}

		private EmployeeCardItem employeeCardItem;

		[Display(Name = "Процент износа")]
		public virtual EmployeeCardItem EmployeeCardItem {
			get => employeeCardItem;
			set => employeeCardItem = value;
		}

		public virtual StockPosition StockPosition {
			get {
				return new StockPosition(Nomenclature, Size, WearGrowth, WearPercent);
			}
			set {
				Nomenclature = value.Nomenclature;
				Size = value.Size;
				WearGrowth = value.Growth;
				WearPercent = value.WearPercent;
			}
		}

		StockBalanceDTO stockBalanceSetter;
		public virtual StockBalanceDTO StockBalanceSetter {
			get {
				return stockBalanceSetter ?? new StockBalanceDTO {Nomenclature = Nomenclature, Growth = WearGrowth, Size = Size, WearPercent = WearPercent } ;
			}
			set {
				stockBalanceSetter = value;
				Nomenclature = value.Nomenclature;
				Size = value.Size;
				WearGrowth = value.Growth;
				WearPercent = value.WearPercent;
			}
		}
		#endregion

		#region Расчетные свойства
		public virtual string Title {
			get { return String.Format ("Выдача со склада {0} в количестве {1} {2}",
				Nomenclature.Name,
				Amount,
				Nomenclature.Type.Units.Name
			);}
		}

		#endregion

		public ExpenseItem ()
		{
		}

		#region Функции

		public virtual void UpdateOperations(IUnitOfWork uow, BaseParameters baseParameters, IInteractiveQuestion askUser, string signCardUid = null)
		{
			WarehouseOperation.Update(uow, this);
			uow.Save(WarehouseOperation);

			//Выдача сотруднику
			if(expenseDoc.Operation == ExpenseOperations.Employee)
			{
				if (EmployeeIssueOperation == null) {
					EmployeeIssueOperation = new EmployeeIssueOperation();
				}

				EmployeeIssueOperation.Update(uow, baseParameters, askUser, this, signCardUid);

				UpdateIssuedWriteOffOperation(uow);
									
				uow.Save(EmployeeIssueOperation);
			}
			else if(EmployeeIssueOperation != null)
			{
				uow.Delete(EmployeeIssueOperation);
				EmployeeIssueOperation = null;
			}

			//Выдача на подразделение
			if(expenseDoc.Operation == ExpenseOperations.Object) {
				if(SubdivisionIssueOperation == null)
					SubdivisionIssueOperation = new SubdivisionIssueOperation(baseParameters);

				SubdivisionIssueOperation.Update(uow, askUser, this);
				uow.Save(SubdivisionIssueOperation);
			}
			else if(SubdivisionIssueOperation != null) {
				uow.Delete(SubdivisionIssueOperation);
				SubdivisionIssueOperation = null;
			}
		}

		public virtual void UpdateIssuedWriteOffOperation(IUnitOfWork uow)
		{
			if(this.ExpenseDoc.WriteOffDoc == null)
				return;

			WriteoffItem relatedWriteoffItem = null;
			if(EmployeeIssueOperation.EmployeeOperationIssueOnWriteOff != null) 
				relatedWriteoffItem = this.ExpenseDoc.WriteOffDoc.Items
					.FirstOrDefault(x => EmployeeIssueOperation.EmployeeOperationIssueOnWriteOff.IsSame(x.EmployeeWriteoffOperation));

			if(IsWriteOff) {
				if(relatedWriteoffItem == null) {
					var graph = IssueGraph.MakeIssueGraph(uow, expenseDoc.Employee, ProtectionTools);
					var interval = graph.IntervalOfDate(ExpenseDoc.Date);
					var toWriteoff = interval.ActiveItems.First(x => x.IssueOperation != EmployeeIssueOperation);
					relatedWriteoffItem = ExpenseDoc.WriteOffDoc.AddItem(toWriteoff.IssueOperation, toWriteoff.AmountAtEndOfDay(ExpenseDoc.Date));
					EmployeeIssueOperation.EmployeeOperationIssueOnWriteOff = relatedWriteoffItem.EmployeeWriteoffOperation;
				}
				relatedWriteoffItem.AktNumber = this.AktNumber;
				relatedWriteoffItem.UpdateOperations(uow);

			}
			else if(EmployeeIssueOperation.EmployeeOperationIssueOnWriteOff != null && relatedWriteoffItem != null) {
					uow.Delete(EmployeeIssueOperation.EmployeeOperationIssueOnWriteOff);
					ExpenseDoc.WriteOffDoc.Items.Remove(relatedWriteoffItem);
					EmployeeIssueOperation.EmployeeOperationIssueOnWriteOff = null;
			}
		}

		#endregion

	}
}


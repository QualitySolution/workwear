﻿using System;
using System.ComponentModel.DataAnnotations;
using QS.Dialog;
using QS.Dialog.GtkUI;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using workwear.Domain.Operations;
using workwear.Domain.Organization;

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

		Nomenclature nomenclature;

		[Display (Name = "Номеклатура")]
		public virtual Nomenclature Nomenclature {
			get { return nomenclature; }
			set { SetField (ref nomenclature, value, () => Nomenclature); }
		}

		IncomeItem incomeOn;

		[Display (Name = "Операция прихода")]
		public virtual IncomeItem IncomeOn {
			get { return incomeOn; }
			set { SetField (ref incomeOn, value, () => IncomeOn); }
		}
			
		int amount;

		[Display (Name = "Количество")]
		public virtual int Amount {
			get { return amount; }
			set { SetField (ref amount, value, () => Amount); }
		}

		FacilityPlace facilityPlace;

		[Display (Name = "Размещение на объекте")]
		public virtual FacilityPlace FacilityPlace {
			get { return facilityPlace; }
			set { SetField (ref facilityPlace, value, () => FacilityPlace); }
		}

		DateTime? autoWriteoffDate;

		[Display (Name = "День автосписания")]
		[Obsolete("Переходите на использование операций EmployeeIssueOperation, это поле в будущих релизах будет удалено.")]
		public virtual DateTime? AutoWriteoffDate {
			get { return autoWriteoffDate; }
			set { SetField (ref autoWriteoffDate, value, () => AutoWriteoffDate); }
		}

		private EmployeeIssueOperation employeeIssueOperation;

		[Display(Name = "Операция выдачи сотруднику")]
		public virtual EmployeeIssueOperation EmployeeIssueOperation
		{
			get { return employeeIssueOperation; }
			set { SetField(ref employeeIssueOperation, value); }
		}

		#endregion

		#region Не сохраняемые в базу свойства

		private string buhDocument;

		[Display(Name = "Документ бухгалтерского учета")]
		//В этом классе используется только для рантайма, в базу не сохраняется, сохраняется внутри операции.
		public virtual string BuhDocument
		{
			get { return buhDocument ?? EmployeeIssueOperation?.BuhDocument; }
			set { SetField(ref buhDocument, value); }
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

		public virtual void UpdateOperations(IUnitOfWork uow, IInteractiveQuestion askUser)
		{
			if(expenseDoc.Operation == ExpenseOperations.Employee)
			{
				if (EmployeeIssueOperation == null)
					EmployeeIssueOperation = new EmployeeIssueOperation();

				EmployeeIssueOperation.Update(uow, askUser, this);
				AutoWriteoffDate = EmployeeIssueOperation.AutoWriteoffDate;
			}
			else if(EmployeeIssueOperation != null)
			{
				uow.Delete(EmployeeIssueOperation);
				EmployeeIssueOperation = null;
			}
		}

		#endregion

	}
}


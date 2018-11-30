﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using workwear.Domain.Operations.Graph;
using workwear.Domain.Organization;
using workwear.Domain.Regulations;
using workwear.Domain.Stock;
using workwear.Tools;

namespace workwear.Domain.Operations
{
	[Appellative(Gender = GrammaticalGender.Feminine,
		NominativePlural = "операции выдачи сотруднику",
		Nominative = "операция выдачи сотруднику"
	)]
	public class EmployeeIssueOperation : PropertyChangedBase, IDomainObject
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public virtual int Id { get; set; }

		DateTime operationTime = DateTime.Now;

		public virtual DateTime OperationTime
		{
			get { return operationTime; }
			set { SetField(ref operationTime, value); }
		}

		private EmployeeCard employee;

		[Display(Name = "Сотрудник")]
		public virtual EmployeeCard Employee
		{
			get { return employee; }
			set { SetField(ref employee, value); }
		}

		private Nomenclature nomenclature;

		[Display(Name = "Номенклатура")]
		public virtual Nomenclature Nomenclature
		{
			get { return nomenclature; }
			set { SetField(ref nomenclature, value); }
		}

		private decimal wearPercent;

		[Display(Name = "Процент износа")]
		public virtual decimal WearPercent
		{
			get { return wearPercent; }
			set { SetField(ref wearPercent, value); }
		}

		private int issued;

		[Display(Name = "Выдано")]
		public virtual int Issued
		{
			get { return issued; }
			set { SetField(ref issued, value); }
		}

		private int returned;

		[Display(Name = "Возвращено")]
		public virtual int Returned
		{
			get { return returned; }
			set { SetField(ref returned, value); }
		}

		private bool useAutoWriteoff = true;

		[Display(Name = "Использовать автосписание")]
		public virtual bool UseAutoWriteoff
		{
			get { return useAutoWriteoff; }
			set { 
				if(SetField(ref useAutoWriteoff, value)) {
					if(value)
						AutoWriteoffDate = ExpenseByNorm;
					else
						AutoWriteoffDate = null;
				}
			}
		}

		private DateTime? startOfUse;

		[Display(Name = "Начало использования")]
		public virtual DateTime? StartOfUse {
			get { return startOfUse; }
			set { SetField(ref startOfUse, value); }
		}

		private DateTime? expenseByNorm;

		[Display(Name = "Износ по норме")]
		public virtual DateTime? ExpenseByNorm
		{
			get { return expenseByNorm; }
			set { SetField(ref expenseByNorm, value); }
		}

		private DateTime? autoWriteoffDate;

		[Display(Name = "Дата автосписания")]
		public virtual DateTime? AutoWriteoffDate
		{
			get { return autoWriteoffDate; }
			set { SetField(ref autoWriteoffDate, value); }
		}

		private EmployeeIssueOperation issuedOperation;

		[Display(Name = "Операция выдачи")]
		public virtual EmployeeIssueOperation IssuedOperation
		{
			get { return issuedOperation; }
			set { SetField(ref issuedOperation, value); }
		}

		private IncomeItem incomeOnStock;

		[Display(Name = "Строка поступление на склад")]
		public virtual IncomeItem IncomeOnStock
		{
			get { return incomeOnStock; }
			set { SetField(ref incomeOnStock, value); }
		}

		private NormItem normItem;

		[Display(Name = "Строка нормы")]
		public virtual NormItem NormItem
		{
			get { return normItem; }
			set { SetField(ref normItem, value); }
		}

		private string buhDocument;

		[Display(Name = "Документ бухгалтерского учета")]
		public virtual string BuhDocument
		{
			get { return buhDocument; }
			set { SetField(ref buhDocument, value); }
		}

		public EmployeeIssueOperation()
		{
			useAutoWriteoff = BaseParameters.DefaultAutoWriteoff;
		}

		#region Расчетные

		public virtual string Title => Issued > Returned
			? $"Выдача {Employee.ShortName} <= {Issued} х {Nomenclature.Name}"
			: $"Списание {Employee.ShortName} => {Returned} х {Nomenclature.Name}";

		#endregion

		#region Методы

		public virtual decimal CalculatePercentWear(DateTime atDate)
		{
			if(StartOfUse == null || ExpenseByNorm == null)
				return 0;

			return WearPercent + (decimal)((atDate - StartOfUse.Value).TotalDays / (ExpenseByNorm.Value - StartOfUse.Value).TotalDays);
		}

		#endregion

		#region Методы обновленя операций

		public virtual void Update(IUnitOfWork uow, Func<string, bool> askUser, ExpenseItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if (item.ExpenseDoc.Date.Date != OperationTime.Date)
				OperationTime = item.ExpenseDoc.Date;

			Employee = item.ExpenseDoc.EmployeeCard;
			Nomenclature = item.Nomenclature;
			WearPercent = 1 - item.IncomeOn.LifePercent;
			Issued = item.Amount;
			Returned = 0;
			IssuedOperation = null;
			IncomeOnStock = item.IncomeOn;
			BuhDocument = item.BuhDocument;

			if (NormItem == null)
				NormItem = Employee.WorkwearItems.FirstOrDefault(x => x.Item == Nomenclature.Type)?.ActiveNormItem;

			var graph = IssueGraph.MakeIssueGraph(uow, Employee, Nomenclature.Type);
			RecalculateDatesOfIssueOperation(graph, askUser);
		}

		public virtual void RecalculateDatesOfIssueOperation(IssueGraph graph, Func<string, bool> askUser)
		{
			if (NormItem == null)
			{
				logger.Error($"Для операциия id:{Id} выдачи {Nomenclature.Name} от {OperationTime} не установлена норма поэтому прерасчет даты выдачи и использования не возможен.");
				return;
			}
			StartOfUse = operationTime;

			var amountAtBegin = graph.AmountAtBeginOfDay(OperationTime.Date, this);
			var amountByNorm = NormItem.Amount;
			if (amountAtBegin >= amountByNorm)
			{
				//Ищем первый интервал где числящееся меньше нормы.
				DateTime moveTo;
				var firstLessNorm = graph.Intervals
					.Where(x => x.StartDate.Date >= OperationTime.Date)
					.OrderBy(x => x.StartDate)
					.FirstOrDefault(x => graph.AmountAtEndOfDay(x.StartDate, this) < NormItem.Amount);
				if (firstLessNorm == null)
				{
					var lastInterval = graph.Intervals
											.OrderBy(x => x.StartDate)
											.LastOrDefault();
					moveTo = lastInterval.ActiveItems.Where(x => x.IssueOperation.ExpenseByNorm.HasValue).Max(x => x.IssueOperation.ExpenseByNorm.Value);
				}
				else
					moveTo = firstLessNorm.StartDate;

				if (askUser($"На {operationTime:d} за сотрудником уже числится {amountAtBegin} x {Nomenclature.TypeName}, при этом по нормам положено {amountByNorm}. Передвинуть начало экспуатации вновь выданных {Issued} на {moveTo}?")){
					startOfUse = moveTo;
				}
			}

			ExpenseByNorm = NormItem.CalculateExpireDate(StartOfUse.Value);

			if (Issued > amountByNorm)
			{
				if(askUser($"За раз выдается {Issued} x {Nomenclature.Type.Name} это больше чем положено по норме {amountByNorm}. Увеличить период эксплуатации выданного пропорционально количеству?"))
				{
					ExpenseByNorm = NormItem.CalculateExpireDate(StartOfUse.Value, Issued);
				}
			}

			if (UseAutoWriteoff)
				AutoWriteoffDate = ExpenseByNorm;
			else
				AutoWriteoffDate = null;
		}

		public virtual void Update(IUnitOfWork uow, Func<string, bool> askUser, IncomeItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if(item.Document.Date.Date != OperationTime.Date)
				OperationTime = item.Document.Date;

			Employee = item.Document.EmployeeCard;
			Nomenclature = item.Nomenclature;
			WearPercent = 1 - item.LifePercent;
			Issued = 0;
			Returned = item.Amount;
			IssuedOperation = item.IssuedOn.EmployeeIssueOperation;
			IncomeOnStock = null;
			BuhDocument = item.BuhDocument;
			NormItem = null;
			ExpenseByNorm = null;
			AutoWriteoffDate = null;
		}

		public virtual void Update(IUnitOfWork uow, Func<string, bool> askUser, WriteoffItem item)
		{
			//Внимание здесь сравниваются даты без времени.
			if(item.Document.Date.Date != OperationTime.Date)
				OperationTime = item.Document.Date;

			IssuedOperation = item.IssuedOn.EmployeeIssueOperation;
			Employee = item.IssuedOn.ExpenseDoc.EmployeeCard;
			Nomenclature = item.Nomenclature;
			WearPercent = IssuedOperation.CalculatePercentWear(OperationTime);
			Issued = 0;
			Returned = item.Amount;
			IncomeOnStock = null;
			BuhDocument = item.BuhDocument;
			NormItem = null;
			ExpenseByNorm = null;
			AutoWriteoffDate = null;
		}

		#endregion
	}
}

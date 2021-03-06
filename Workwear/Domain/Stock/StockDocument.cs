﻿using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using QS.Project.Domain;

namespace workwear.Domain.Stock
{
	public class StockDocument : BusinessObjectBase<StockDocument>, IDomainObject
	{
		public virtual int Id { get; set; }

		DateTime date = DateTime.Now;

		[Display(Name = "Дата")]
		public virtual DateTime Date
		{
			get { return date; }
			set { SetField(ref date, value, () => Date); }
		}

		UserBase createdbyUser;

		[Display(Name = "Документ создал")]
		public virtual UserBase CreatedbyUser
		{
			get { return createdbyUser; }
			set { SetField(ref createdbyUser, value, () => CreatedbyUser); }
		}

		private string comment;

		[Display(Name = "Комментарий")]
		public virtual string Comment
		{
			get { return comment; }
			set { SetField(ref comment, value, () => Comment); }
		}

		public StockDocument()
		{
		}

		public static Type GetDocClass(StokDocumentType docType)
		{
			switch (docType)
			{
				case StokDocumentType.IncomeDoc:
					return typeof(Income);
				case StokDocumentType.ExpenseEmployeeDoc:
				case StokDocumentType.ExpenseObjectDoc:
					return typeof(Expense);
				case StokDocumentType.WriteoffDoc:
					return typeof(Writeoff);
				case StokDocumentType.TransferDoc:
					return typeof(Transfer);
				case StokDocumentType.MassExpense:
					return typeof(MassExpense);
			}
			throw new NotSupportedException();
		}
	}

	public enum StokDocumentType
	{
		[Display(Name = "Поступление на склад")]
		IncomeDoc,
		[Display(Name = "Выдача сотруднику")]
		ExpenseEmployeeDoc,
		[Display(Name = "Выдача на подразделение")]
		ExpenseObjectDoc,
		[Display(Name = "Списание")]
		WriteoffDoc,
		[Display(Name = "Перемещение")]
		TransferDoc,
		[Display(Name = "Массовая выдача")]
		MassExpense
	}
}

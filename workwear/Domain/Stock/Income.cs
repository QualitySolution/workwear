﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using QSOrmProject;

namespace workwear.Domain.Stock
{
	[OrmSubject (Gender = QSProjectsLib.GrammaticalGender.Masculine,
		NominativePlural = "приходные документы",
		Nominative = "приходный документ")]
	public class Income : PropertyChangedBase, IDomainObject, IValidatableObject
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger ();

		#region Свойства

		public virtual int Id { get; set; }

		IncomeOperations operation;

		[Display (Name = "Тип операции")]
		public virtual IncomeOperations Operation {
			get { return operation; }
			set { SetField (ref operation, value, () => Operation); }
		}

		string number;

		[Display (Name = "Вх. номер")]
		public virtual string Number {
			get { return number; }
			set { SetField (ref number, value, () => Number); }
		}

		EmployeeCard employeeCard;

		[Display (Name = "Сотрудник")]
		public virtual EmployeeCard EmployeeCard {
			get { return employeeCard; }
			set { SetField (ref employeeCard, value, () => EmployeeCard); }
		}

		Facility facility;

		[Display (Name = "Объект")]
		public virtual Facility Facility {
			get { return facility; }
			set { SetField (ref facility, value, () => Facility); }
		}

		DateTime date;

		[Display (Name = "Дата")]
		public virtual DateTime Date {
			get { return date; }
			set { SetField (ref date, value, () => Date); }
		}

		User createdbyUser;

		[Display (Name = "Карточку создал")]
		public virtual User CreatedbyUser {
			get { return createdbyUser; }
			set { SetField (ref createdbyUser, value, () => CreatedbyUser); }
		}

		private IList<IncomeItem> items = new List<IncomeItem>();

		[Display (Name = "Строки документа")]
		public virtual IList<IncomeItem> Items {
			get { return items; }
			set { SetField (ref items, value, () => Items); }
		}

		GenericObservableList<IncomeItem> observableItems;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<IncomeItem> ObservableItems {
			get {
				if (observableItems == null)
					observableItems = new GenericObservableList<IncomeItem> (Items);
				return observableItems;
			}
		}
			
		#endregion

		public virtual string Title{
			get{
				switch (Operation) {
				case IncomeOperations.Enter:
					return String.Format ("Приходная накладная №{0} от {1:d}", Id, Date);
				case IncomeOperations.Return:
					return String.Format ("Возврат от работника №{0} от {1:d}", Id, Date);
				case IncomeOperations.Object:
					return String.Format ("Возврат c объекта №{0} от {1:d}", Id, Date);
				default:
					return null;
				}
			}
		}

		#region IValidatableObject implementation

		public virtual IEnumerable<ValidationResult> Validate (ValidationContext validationContext)
		{
			if (Date < new DateTime(2008, 1, 1))
				yield return new ValidationResult ("Дата должны указана (не ранее 2008-го)", 
					new[] { this.GetPropertyName (o => o.Date)});

			if(Operation == IncomeOperations.Object && Facility == null)
				yield return new ValidationResult ("Объект должен быть указан", 
					new[] { this.GetPropertyName (o => o.Date)});

			if(Operation == IncomeOperations.Return && EmployeeCard == null)
				yield return new ValidationResult ("Сотрудник должен быть указан", 
					new[] { this.GetPropertyName (o => o.Date)});

			if(Items.Count == 0)
				yield return new ValidationResult ("Документ должен содержать хотя бы одну строку.", 
					new[] { this.GetPropertyName (o => o.Items)});

			if(Items.Any (i => i.Amount <= 0))
				yield return new ValidationResult ("Документ не должен содержать строк с нулевым количеством.", 
					new[] { this.GetPropertyName (o => o.Items)});
		}

		#endregion


		public Income ()
		{
		}

		public virtual void AddItem(ExpenseItem expenseFromItem, int count)
		{
			if(Items.Any (p => DomainHelper.EqualDomainObjects (p.IssuedOn, expenseFromItem)))
			{
				logger.Warn ("Номенклатура из этой выдачи уже добавлена. Пропускаем...");
				return;
			}
			decimal life = expenseFromItem.IncomeOn.LifePercent;
			decimal cost = expenseFromItem.IncomeOn.Cost;
			if(expenseFromItem.AutoWriteoffDate.HasValue)
			{
				double multiplier = (expenseFromItem.AutoWriteoffDate.Value - DateTime.Today).TotalDays / (expenseFromItem.AutoWriteoffDate.Value - expenseFromItem.ExpenseDoc.Date).TotalDays;
				life = (life * (decimal)multiplier);
				cost = (cost * (decimal)multiplier);
			}
				
			var newItem = new IncomeItem () {
				Amount = count,
				Nomenclature = expenseFromItem.Nomenclature,
				IssuedOn = expenseFromItem,
				Cost = cost,
				LifePercent = life
			};

			ObservableItems.Add (newItem);
		}

		public virtual void AddItem(Nomenclature nomenclature)
		{
			if (Operation != IncomeOperations.Enter)
				throw new InvalidOperationException ("Добавление номенклатуры возможно только во входящую накладную. Возвраты должны добавляться с указанием строки выдачи.");

			if(Items.Any (p => DomainHelper.EqualDomainObjects (p.Nomenclature, nomenclature)))
			{
				logger.Warn ("Номенклатура из уже добавлена. Пропускаем...");
				return;
			}

			var newItem = new IncomeItem () {
				Amount = 1,
				Nomenclature = nomenclature,
				Cost = 0,
				LifePercent = 1,
			};

			ObservableItems.Add (newItem);
		}

		public virtual void RemoveItem(IncomeItem item)
		{
			ObservableItems.Remove (item);
		}

	}

	public enum IncomeOperations {
		[Display(Name = "Приходная накладная")]
		Enter,
		[Display(Name = "Возврат от работника")]
		Return,
		[Display(Name = "Возврат с объекта")]
		Object
	}

	public class IncomeOperationsType : NHibernate.Type.EnumStringType
	{
		public IncomeOperationsType () : base (typeof(IncomeOperations))
		{
		}
	}
}

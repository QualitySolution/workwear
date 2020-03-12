﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;

namespace workwear.Domain.Stock
{
	[Appellative(Gender = GrammaticalGender.Masculine,
		NominativePlural = "документы перемещения",
		Nominative = "документ перемещения")]
	public class Transfer : StockDocument, IValidatableObject
	{
		public Transfer()
		{ }
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		#region Свойства

		private Warehouse warehouseFrom;

		[Display(Name = "Склад отправитель")]
		[Required(ErrorMessage = "Склад отправитель должен быть указан.")]
		public virtual Warehouse WarehouseFrom {
			get { return warehouseFrom; }
			set { SetField(ref warehouseFrom, value, () => WarehouseFrom); }
		}

		private Warehouse warehouseTo;

		[Display(Name = "Склад получатель")]
		[Required(ErrorMessage = "Склад получатель должен быть указан.")]
		public virtual Warehouse WarehouseTo {
			get { return warehouseTo; }
			set { SetField(ref warehouseTo, value, () => WarehouseTo); }
		}


		private IList<TransferItem> items = new List<TransferItem>();

		[Display(Name = "Строки документа")]
		public virtual IList<TransferItem> Items {
			get { return items; }
			set { SetField(ref items, value, () => Items); }
		}

		GenericObservableList<TransferItem> observableItems;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<TransferItem> ObservableItems {
			get {
				if(observableItems == null)
					observableItems = new GenericObservableList<TransferItem>(Items);
				return observableItems;
			}
		}

		#endregion

		#region Расчетные

		public virtual string Title => $"Перемещение №{Id} от {Date:d}";

		#endregion

		#region IValidatableObject implementation

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if(Date < new DateTime(1990, 1, 1))
				yield return new ValidationResult("Дата должна быть указана",
					new[] { this.GetPropertyName(o => o.Date) });

			if(Items.Count == 0)
				yield return new ValidationResult("Документ должен содержать хотя бы одну строку.",
					new[] { this.GetPropertyName(o => o.Items) });

			if(Items.Any(i => i.Amount <= 0))
				yield return new ValidationResult("Документ не должен содержать строк с нулевым количеством.",
					new[] { this.GetPropertyName(o => o.Items) });

			if (warehouseTo == null)
				yield return new ValidationResult("Склад добавления должен быть указан",
				new[] { this.GetPropertyName(o => o.Items) });

			if(warehouseFrom == null)
				yield return new ValidationResult("Склад списания должен быть указан",
				new[] { this.GetPropertyName(o => o.Items) });

			if (WarehouseTo == WarehouseFrom)
				yield return new ValidationResult("Склад добавления должен отличаться от склада списания",
				new[] { this.GetPropertyName(o => o.Items) });
		}

		#endregion

		public virtual TransferItem AddItem(StockPosition position, int amount)
		{

			if(Items.Any(p => position.Equals(p.StockPosition))) {
				logger.Warn($"Складская позици {position.Title} из уже добавлена. Пропускаем...");
				return null;
			}

			var newItem = new TransferItem(this, position, amount);
			ObservableItems.Add(newItem);
			return newItem;
		}

		public virtual void RemoveItem(TransferItem item)
		{
			ObservableItems.Remove(item);
		}

		public virtual void UpdateOperations(IUnitOfWork uow, Func<string, bool> askUser)
		{
			Items.ToList().ForEach(x => x.UpdateOperations(uow, askUser));
		}
	}

}

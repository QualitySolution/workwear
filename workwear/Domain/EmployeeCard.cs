﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using QSOrmProject;
using QSProjectsLib;
using workwear.Measurements;

namespace workwear.Domain
{

	[OrmSubject (Gender = QSProjectsLib.GrammaticalGender.Feminine,
		NominativePlural = "карточки сотрудников",
		Nominative = "карточка сотрудника",
		PrepositionalPlural = "карточках сотрудников"
	)]
	public class EmployeeCard: PropertyChangedBase, IDomainObject, IValidatableObject
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger ();

		#region Свойства

		public virtual int Id { get; set; }

		string cardNumber;

		[Display (Name = "Номер карточки")]
		public virtual string CardNumber {
			get { return cardNumber; }
			set { SetField (ref cardNumber, value, () => CardNumber); }
		}

		string personnelNumber;

		[Display (Name = "Табельный номер")]
		public virtual string PersonnelNumber {
			get { return personnelNumber; }
			set { SetField (ref personnelNumber, value, () => PersonnelNumber); }
		}

		string name;

		[Display (Name = "Имя")]
		public virtual string FirstName {
			get { return name; }
			set { SetField (ref name, value, () => FirstName); }
		}

		string lastName;

		[Display (Name = "Фамилия")]
		public virtual string LastName {
			get { return lastName; }
			set { SetField (ref lastName, value, () => LastName); }
		}

		string patronymic;

		[Display (Name = "Отчество")]
		public virtual string Patronymic {
			get { return patronymic; }
			set { SetField (ref patronymic, value, () => Patronymic); }
		}

		Post post;

		[Display (Name = "Должность")]
		public virtual Post Post {
			get { return post; }
			set { SetField (ref post, value, () => Post); }
		}

		Leader leader;

		[Display (Name = "Руководитель")]
		public virtual Leader Leader {
			get { return leader; }
			set { SetField (ref leader, value, () => Leader); }
		}

		DateTime? hireDate;

		[Display (Name = "Дата поступления")]
		public virtual DateTime? HireDate {
			get { return hireDate; }
			set { SetField (ref hireDate, value, () => HireDate); }
		}

		DateTime? dismissDate;

		[Display (Name = "Дата увольнения")]
		public virtual DateTime? DismissDate {
			get { return dismissDate; }
			set { SetField (ref dismissDate, value, () => DismissDate); }
		}

		Sex sex;

		[Display (Name = "Пол")]
		public virtual Sex Sex {
			get { return sex; }
			set { SetField (ref sex, value, () => Sex); }
		}

		User createdbyUser;

		[Display (Name = "Карточку создал")]
		public virtual User CreatedbyUser {
			get { return createdbyUser; }
			set { SetField (ref createdbyUser, value, () => CreatedbyUser); }
		}
			
		Facility facility;

		[Display (Name = "Объект")]
		public virtual Facility Facility {
			get { return facility; }
			set { SetField (ref facility, value, () => Facility); }
		}

		byte[] photo;

		[Display (Name = "Фотография")]
		public virtual byte[] Photo {
			get { return photo; }
			set { SetField (ref photo, value, () => Photo); }
		}
			
		#endregion

		#region Размеры одежды

		string wearGrowth;

		[Display (Name = "Рост одежды")]
		public virtual string WearGrowth { 
			get { return wearGrowth; } 
			set	{ SetField (ref wearGrowth, value, () => WearGrowth); }
		}

		string wearSizeStd;

		[Display (Name = "Стандарт размера одежды")]
		public virtual string WearSizeStd {
			get { return wearSizeStd; }
			set { SetField (ref wearSizeStd, value, () => WearSizeStd); }
		}

		string wearSize;

		[Display (Name = "Размер одежды")]
		public virtual string WearSize { 
			get { return wearSize; } 
			set	{ SetField (ref wearSize, value, () => WearSize); }
		}

		string shoesSizeStd;

		[Display (Name = "Стандарт размера обуви")]
		public virtual string ShoesSizeStd {
			get { return shoesSizeStd; }
			set { SetField (ref shoesSizeStd, value, () => ShoesSizeStd); }
		}

		string shoesSize;

		[Display (Name = "Размер обуви")]
		public virtual string ShoesSize { 
			get { return shoesSize; } 
			set	{ SetField (ref shoesSize, value, () => ShoesSize); }
		}

		string headdressSizeStd;

		[Display (Name = "Стандарт размера головного убора")]
		public virtual string HeaddressSizeStd {
			get { return headdressSizeStd; }
			set { SetField (ref headdressSizeStd, value, () => HeaddressSizeStd); }
		}

		string headdressSize;

		[Display (Name = "Размер головного убора")]
		public virtual string HeaddressSize { 
			get { return headdressSize; } 
			set	{ SetField (ref headdressSize, value, () => HeaddressSize); }
		}

		string glovesSizeStd;

		[Display (Name = "Стандарт размера одежды")]
		public virtual string GlovesSizeStd {
			get { return glovesSizeStd; }
			set { SetField (ref glovesSizeStd, value, () => GlovesSizeStd); }
		}

		string glovesSize;

		[Display (Name = "Размер одежды")]
		public virtual string GlovesSize { 
			get { return glovesSize; } 
			set	{ SetField (ref glovesSize, value, () => GlovesSize); }
		}

		private IList<Norm> usedNorms = new List<Norm>();

		[Display (Name = "Примененные нормы")]
		public virtual IList<Norm> UsedNorms {
			get { return usedNorms; }
			set { SetField (ref usedNorms, value, () => UsedNorms); }
		}

		GenericObservableList<Norm> observableUsedNorms;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<Norm> ObservableUsedNorms {
			get {
				if (observableUsedNorms == null)
					observableUsedNorms = new GenericObservableList<Norm> (UsedNorms);
				return observableUsedNorms;
			}
		}

		private IList<EmployeeCardItem> workwearItems = new List<EmployeeCardItem>();

		[Display (Name = "Спецодежда")]
		public virtual IList<EmployeeCardItem> WorkwearItems {
			get { return workwearItems; }
			set { SetField (ref workwearItems, value, () => WorkwearItems); }
		}

		GenericObservableList<EmployeeCardItem> observableWorkwearItems;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<EmployeeCardItem> ObservableWorkwearItems {
			get {
				if (observableWorkwearItems == null)
					observableWorkwearItems = new GenericObservableList<EmployeeCardItem> (WorkwearItems);
				return observableWorkwearItems;
			}
		}

		#endregion

		public virtual string Title {
			get{ return StringWorks.PersonNameWithInitials (LastName, FirstName, Patronymic);
			}
		}

		public virtual string FullName {
			get { return String.Format ("{0} {1} {2}", LastName, FirstName, Patronymic).Trim (); }
		}

		public virtual string ShortName {
			get { return StringWorks.PersonNameWithInitials (LastName, FirstName, Patronymic); }
		}

		public EmployeeCard ()
		{
		}

		#region IValidatableObject implementation

		public virtual IEnumerable<ValidationResult> Validate (ValidationContext validationContext)
		{
			if (String.IsNullOrEmpty (FirstName) && String.IsNullOrEmpty (LastName) && String.IsNullOrEmpty (Patronymic))
				yield return new ValidationResult ("Должно быть заполнено хотя бы одно из следующих полей: " +
					"Фамилия, Имя, Отчество)", 
					new[] { this.GetPropertyName (o => o.FirstName), this.GetPropertyName (o => o.LastName), this.GetPropertyName (o => o.Patronymic) });

			if (Sex == Sex.None)
				yield return new ValidationResult ("Пол должен быть указан.", new[] { this.GetPropertyName (o => o.Sex) });
			
		}

		#endregion

		public virtual SizePair GetSize(СlothesType wearCategory)
		{
			switch(wearCategory)
			{
			case СlothesType.Wear:
				return new SizePair (WearSizeStd, WearSize);
			case СlothesType.Shoes:
				return new SizePair (ShoesSizeStd, ShoesSize);
			case СlothesType.Gloves:
				return new SizePair (GlovesSizeStd, GlovesSize);
			case СlothesType.Headgear:
				return new SizePair (HeaddressSizeStd, HeaddressSize);
			default:
				return null;
			}
		}

		public virtual void AddUsedNorm(Norm norm)
		{
			if(UsedNorms.Any (p => DomainHelper.EqualDomainObjects (p, norm)))
			{
				logger.Warn ("Такая норма уже добавлена. Пропускаем...");
				return;
			}
			ObservableUsedNorms.Add (norm);
			UpdateWorkwearItems ();
		}

		public virtual void RemoveUsedNorm(Norm norm)
		{
			ObservableUsedNorms.Remove (norm);
			UpdateWorkwearItems ();
		}

		public virtual void UpdateWorkwearItems()
		{
			//Проверяем нужно ли добавлять
			var processed = new List<EmployeeCardItem>();
			foreach(var norm in UsedNorms)
			{
				foreach (var normItem in norm.Items)
				{
					var currentItem = WorkwearItems.FirstOrDefault (i => i.Item == normItem.Item);
					if (currentItem == null)
					{
						//FIXME Возможно нужно проверять если что-то подходящее уже выдавалось то пересчитывать.
						currentItem = new EmployeeCardItem (this, normItem);

						ObservableWorkwearItems.Add (currentItem);
					}

					if(processed.Contains (currentItem))
					{
						if (normItem.AmountPerYear > currentItem.ActiveNormItem.AmountPerYear)
							currentItem.ActiveNormItem = normItem;
					}
					else
					{
						processed.Add (currentItem);
						currentItem.ActiveNormItem = normItem;
					}
				}
			}

			// Удаляем больше ненужные
			var needRemove = WorkwearItems.Where (i => !processed.Contains (i));

			needRemove.ToList ().ForEach (i => ObservableWorkwearItems.Remove (i));
		}

		public virtual void FillWearRecivedInfo(IUnitOfWork uow)
		{
			if (Id == 0) // Не надо проверять выдачи, так как сотрудник еще не сохранен.
				return; 
			var receiveds = Repository.EmployeeRepository.ItemsBalance (uow, this);
			var summary = receiveds.GroupBy (r => r.ItemsTypeId).Select (gr => new {
				ItemsTypeId = gr.Key,
				Amount = gr.Sum (r => r.Amount),
				LastReceive = gr.Max (r => r.LastReceive)
			}).ToArray ();
			foreach(var item in WorkwearItems)
			{
				var receive = summary.FirstOrDefault (dto => dto.ItemsTypeId == item.Item.Id);
				item.Amount = receive != null ? receive.Amount : 0;
				item.LastIssue = receive != null ? receive.LastReceive : (DateTime?)null;
			}
		}

		public virtual void FillWearInStockInfo(IUnitOfWork uow)
		{
			var nomenclatures = WorkwearItems.Where (i => i.MatchedNomenclature != null).Select (i => i.MatchedNomenclature).ToList ();
			if (nomenclatures.Count == 0)
				return;
			var stock = StockRepository.BalanceInStockSummary (uow, nomenclatures);
			foreach(var item in WorkwearItems)
			{
				if (item.MatchedNomenclature == null)
					continue;
				var inStock = stock.FirstOrDefault (s => s.Nomenclature == item.MatchedNomenclature);
				item.SetInStockAmount (inStock == null ? 0 : inStock.Amount);
			}
		}
	}

	public enum Sex{
		[Display(Name = "Нет")]
		None,
		[Display(Name = "Мужской")]
		M,
		[Display(Name = "Женский")]
		F
	}

	public class SexStringType : NHibernate.Type.EnumStringType
	{
		public SexStringType () : base (typeof(Sex))
		{
		}
	}

}

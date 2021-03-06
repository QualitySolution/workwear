using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using workwear.Domain.Regulations;
using workwear.Measurements;

namespace workwear.Domain.Stock
{
	[Appellative (Gender = GrammaticalGender.Feminine,
		NominativePlural = "номенклатура",
		Nominative = "номенклатура")]
	public class Nomenclature: PropertyChangedBase, IDomainObject, IValidatableObject
	{
		#region Свойства

		public virtual int Id { get; set; }

		string name;

		[Display (Name = "Название")]
		[Required (ErrorMessage = "Название номенклатуры должно быть заполнено.")]
		[StringLength(240)]
		public virtual string Name {
			get { return name; }
			set { SetField (ref name, value, () => Name); }
		}

		ItemsType type;

		[Display (Name = "Группа номенклатур")]
		[Required (ErrorMessage = "Номенклатурная группа должна быть указана.")]
		public virtual ItemsType Type {
			get { return type; }
			set { SetField (ref type, value, () => Type); }
		}

		ClothesSex? sex;

		[Display (Name = "Пол одежды")]
		public virtual ClothesSex? Sex {
			get { return sex; }
			set { SetField (ref sex, value, () => Sex); }
		}

		string sizeStd;

		[Display (Name = "Стандарт размера")]
		public virtual string SizeStd {
			get { return sizeStd; }
			set { SetField (ref sizeStd, value, () => SizeStd); }
		}

		[Display (Name = "Стандарт роста")]
		public virtual string WearGrowthStd {
			get {
				if(Type?.WearCategory == null || Sex == null)
					return null;
				var growthStd = SizeHelper.GetGrowthStandart(Type.WearCategory.Value, Sex.Value);
				return growthStd != null ? SizeHelper.GetSizeStdCode(growthStd) : null;
			}
			set { }
		}

		private string comment;

		[Display(Name = "Комментарий")]
		public virtual string Comment
		{
			get { return comment; }
			set { SetField(ref comment, value, () => Comment); }
		}

		private uint? number;

		[Display(Name = "Номенклатурный номер")]
		public virtual uint? Number {
			get { return number; }
			set { SetField(ref number, value, () => Number); }
		}

		#endregion

		#region Рассчетные

		public virtual string TypeName => Type.Name;

		public virtual string GetAmountAndUnitsText(int amount)
		{
			return this.Type?.Units?.MakeAmountShortStr(amount) ?? amount.ToString();
		}

		#endregion

		#region Средства защиты

		private IList<ProtectionTools> protectionTools = new List<ProtectionTools>();

		[Display(Name = "Номенклатры ТОН")]
		public virtual IList<ProtectionTools> ProtectionTools {
			get { return protectionTools; }
			set { SetField(ref protectionTools, value, () => ProtectionTools); }
		}

		GenericObservableList<ProtectionTools> observableProtectionTools;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<ProtectionTools> ObservableProtectionTools {
			get {
				if(observableProtectionTools == null)
					observableProtectionTools = new GenericObservableList<ProtectionTools>(ProtectionTools);
				return observableProtectionTools;
			}
		}

		#endregion

		public Nomenclature ()
		{
			
		}

		#region IValidatableObject implementation

		public virtual System.Collections.Generic.IEnumerable<ValidationResult> Validate (ValidationContext validationContext)
		{
			if (Type != null && Type.WearCategory != null && Sex.HasValue 
				&& Sex == ClothesSex.Universal && SizeHelper.HasСlothesSizeStd(Type.WearCategory.Value) && !SizeHelper.IsUniversalСlothes (Type.WearCategory.Value))
				yield return new ValidationResult ("Данный вид одежды не имеет универсальных размеров.", 
					new[] { this.GetPropertyName (o => o.Sex) });

			if(Type != null && Type.WearCategory != null && Type.WearCategory != СlothesType.PPE && String.IsNullOrWhiteSpace(SizeStd))
				yield return new ValidationResult("Необходимо указать стандарт размера спецодежды.",
					new[] { this.GetPropertyName(o => o.SizeStd) });
		}

		#endregion

		#region Функции
		/// <summary>
		/// Копирует текущий объект Nomenclature и возвращает ссылку на копию.
		/// </summary>
		/// <returns>The Nomenclature clone.</returns>
		public virtual Nomenclature Clone()
		{
			Nomenclature nomenclature = new Nomenclature();
			nomenclature.name = this.Name;
			nomenclature.type = this.type;
			nomenclature.sex = this.sex;
			nomenclature.sizeStd = this.sizeStd;
			nomenclature.comment = this.comment;
			nomenclature.number = this.number;
			return nomenclature;
		}

		#endregion
	}
}


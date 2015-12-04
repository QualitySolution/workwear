﻿using System;
using QSOrmProject;
using System.ComponentModel.DataAnnotations;
using QSProjectsLib;

namespace workwear.Domain
{
	[OrmSubject (Gender = QSProjectsLib.GrammaticalGender.Feminine,
		NominativePlural = "строки нормы",
		Nominative = "строка нормы")]
	public class NormItem : PropertyChangedBase, IDomainObject
	{
		#region Свойства

		public virtual int Id { get; set; }

		Norm norm;

		[Display (Name = "Норма")]
		public virtual Norm Norm {
			get { return norm; }
			set { SetField (ref norm, value, () => Norm); }
		}

		ItemsType item;

		[Display (Name = "Позиция")]
		public virtual ItemsType Item {
			get { return item; }
			set { SetField (ref item, value, () => Item); }
		}

		int amount;

		[Display (Name = "Количество")]
		public virtual int Amount {
			get { return amount; }
			set { SetField (ref amount, value, () => Amount); }
		}

		NormPeriodType normPeriod;

		[Display (Name = "Период нормы")]
		public virtual NormPeriodType NormPeriod {
			get { return normPeriod; }
			set { SetField (ref normPeriod, value, () => NormPeriod); }
		}

		int periodCount;

		[Display (Name = "Количество периодов")]
		public virtual int PeriodCount {
			get { return periodCount; }
			set { SetField (ref periodCount, value, () => PeriodCount); }
		}

		#endregion

		public virtual double AmountPerYear
		{
			get{
				double years = -1;
				switch(NormPeriod)
				{
				case NormPeriodType.Year:
					years = PeriodCount;
					break;
				case NormPeriodType.Month:
					years = (double)PeriodCount / 12;
					break;
				case NormPeriodType.Shift:
					years = (double)PeriodCount / 247;
					break;
				}
				return Amount / years;
			}
		}

		public virtual string LifeText{
			get{
				switch(NormPeriod)
				{
				case NormPeriodType.Year:
					return RusNumber.FormatCase (PeriodCount, "{0} год", "{0} года", "{0} лет");
				case NormPeriodType.Month:
					return RusNumber.FormatCase (PeriodCount, "{0} месяц", "{0} месяца", "{0} месяцев");
				case NormPeriodType.Shift:
					return RusNumber.FormatCase (PeriodCount, "{0} смена", "{0} смены", "{0} смен");
				}
				return String.Empty;
			}
		}

		public NormItem ()
		{
		}
	}

	public enum NormPeriodType{
		[Display(Name = "Год")]
		Year,
		[Display(Name = "Месяц")]
		Month,
		[Display(Name = "Смена")]
		Shift,
	}

	public class NormPeriodTypeType : NHibernate.Type.EnumStringType
	{
		public NormPeriodTypeType () : base (typeof(NormPeriodType))
		{
		}
	}
}


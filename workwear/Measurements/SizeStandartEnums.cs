﻿using System;
using System.ComponentModel.DataAnnotations;

namespace workwear.Measurements
{
	public enum GrowthStandartWear
	{
		[StdCode("MenGrowth")]
		[Display(Name = "Мужской рост", ShortName = "Муж.")]
		Men,
		[StdCode("WomenGrowth")]
		[Display(Name = "Женский рост", ShortName = "Жен.")]
		Women,
	}

	public enum SizeStandartMenWear
	{
		[StdCode("MenWearRus")]
		[Display(Name = "Российский", ShortName = "РФ")]
		Rus,
		[StdCode("MenWearIntl")]
		[Display(Name = "Международный", ShortName = "Межд.")]
		Intl,
	}

	public enum SizeStandartWomenWear
	{
		[StdCode("WomenWearRus")]
		[Display(Name = "Российский", ShortName = "РФ")]
		Rus,
		[StdCode("WomenWearIntl")]
		[Display(Name = "Международный", ShortName = "Межд.")]
		Intl,
	}

	public enum SizeStandartMenShoes
	{
		[StdCode("MenShoesRus")]
		[Display(Name = "Российский", ShortName = "РФ")]
		Rus,
		[StdCode("MenShoesEU")]
		[Display(Name = "Европа", ShortName = "EU")]
		EU,
	}

	public enum SizeStandartWomenShoes
	{
		[StdCode("WomenShoesRus")]
		[Display(Name = "Российский", ShortName = "РФ")]
		Rus,
		[StdCode("WomenShoesEU")]
		[Display(Name = "Европа", ShortName = "EU")]
		EU,
	}


	public enum SizeStandartHeaddress
	{
		[StdCode("HeaddressRus")]
		[Display(Name = "Российский", ShortName = "РФ")]
		Rus,
		[StdCode("HeaddressIntl")]
		[Display(Name = "Международный", ShortName = "Межд.")]
		Intl,
	}

	public enum SizeStandartGloves
	{
		[StdCode("GlovesRus")]
		[Display(Name = "Российский", ShortName = "РФ")]
		Rus,
		[StdCode("GlovesIntl")]
		[Display(Name = "Международный", ShortName = "Межд.")]
		Intl,
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class StdCodeAttribute : Attribute 
	{
		public string Code { get; set;}

		public StdCodeAttribute(string code)
		{
			Code = code;
		}
	}
}

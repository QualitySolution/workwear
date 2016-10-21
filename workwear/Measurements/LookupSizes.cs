﻿using System;

namespace workwear.Measurements
{
	public static class LookupSizes
	{
		public static readonly WearGrowth[] WomenGrowth = new WearGrowth[] {
			new WearGrowth("146", 143, 149),
			new WearGrowth("152", 149, 155),
			new WearGrowth("158", 155, 161),
			new WearGrowth("164", 161, 167),
			new WearGrowth("170", 167, 173),
			new WearGrowth("176", 173, 179), 
		};

		public static readonly WearGrowth[] MenGrowth = new WearGrowth[] {
			new WearGrowth("158", 155, 161),
			new WearGrowth("164", 161, 167),
			new WearGrowth("170", 167, 173),
			new WearGrowth("176", 173, 179),
			new WearGrowth("182", 179, 185),
			new WearGrowth("188", 185, 191),
			new WearGrowth("194", 191, 197),
			new WearGrowth("200", 197, 203),
		};

		public static readonly WearGrowth[] UniversalGrowth = new WearGrowth[] {
			new WearGrowth("152", 149, 155),
			new WearGrowth("158", 155, 161),
			new WearGrowth("164", 161, 167),
			new WearGrowth("170", 167, 173),
			new WearGrowth("176", 173, 179),
			new WearGrowth("182", 179, 185),
			new WearGrowth("188", 185, 191),
			new WearGrowth("194", 191, 197),
			new WearGrowth("200", 197, 203),
		};

		public static readonly string[,] MenWear = new string[,] {
			{ "44", "XXS" },
			{ "46", "XS" },
			{ "48", "S" },
			{ "50", "M" },
			{ "52", "L" },
			{ "54", "XL" },
			{ "56", "XXL" },
			{ "58", "XXXL" },
			{ "60", "XXXL" },
			{ "62", "XXXL" },
			{ "64", "4XL" },
			{ "66", "4XL" },
			{ "68", "5XL" },
			{ "70", "5XL" },
		};

		public static readonly string[,] WomenWear = new string[,] {
			{ "38", "XXS" },
			{ "40", "XS" },
			{ "42", "S" },
			{ "44", "M" },
			{ "46", "M" },
			{ "48", "L" },
			{ "50", "L" },
			{ "52", "XL" },
			{ "54", "XXL" },
			{ "56", "XXL" },
			{ "58", "XXXL" },
			{ "60", "4XL" },
			{ "62", "4XL" },
			{ "64", "4XL" },
			{ "66", "5XL" },
			{ "68", "5XL" },
			{ "70", "5XL" },
		};

		public static readonly string[,] UnisexWear = new string[,] {
			{ "38", "XXS" },
			{ "40", "XS" },
			{ "42", "S" },
			{ "44", "M" },
			{ "46", "M" },
			{ "48", "L" },
			{ "50", "L" },
			{ "52", "XL" },
			{ "54", "XXL" },
			{ "56", "XXL" },
			{ "58", "XXXL" },
			{ "60", "4XL" },
			{ "62", "4XL" },
			{ "64", "4XL" },
			{ "66", "5XL" },
			{ "68", "5XL" },
			{ "70", "5XL" },
		};

		public static readonly string[,] MenShoes = new string[,] {
			{ "38", "38" },
			{ "39", "39" },
			{ "40", "40" },
			{ "40,5", "41" },
			{ "41", "41,5" },
			{ "42", "42" },
			{ "43", "43" },
			{ "43,5", "44" },
			{ "44", "44,5" },
			{ "45", "45" },
			{ "46", "46" },
			{ "46,5", "47" },
			{ "47", "47,5" },
			{ "48", "48" },
		};

		public static readonly string[,] WomenShoes = new string[,] {
			{ "34", "34" },
			{ "34,5", "35" },
			{ "35", "35,5" },
			{ "36", "36" },
			{ "37", "37" },
			{ "37,5", "38" },
			{ "38", "38,5" },
			{ "38,5", "39" },
			{ "39", "39,5" },
			{ "40", "40" },
			{ "40,5", "41" },
			{ "41", "41,5" },
			{ "42", "42" },
			{ "43", "43" },
			{ null, "44" },
		};

		public static readonly string[,] UnisexShoes = new string[,] {
			{ "34", "34" },
			{ "35", "35,5" },
			{ "36", "36" },
			{ "37", "37" },
			{ "38", "38,5" },
			{ "39", "39,5" },
			{ "40", "40" },
			{ "41", "41,5" },
			{ "42", "42" },
			{ "43", "43" },
			{ "44", "44,5" },
			{ "45", "45" },
			{ "46", "46" },
			{ "47", "47,5" },
			{ "48", "48" },
		};

		public static readonly string[,] Headdress = new string[,] {
			{ "54", "XXS" },
			{ "55", "XS" },
			{ "56", "S" },
			{ "57", "M" },
			{ "58", "L" },
			{ "59", "XL" },
			{ "60", "XXL" },
			{ "61", "XXL" },
			{ "62", "XXXL" },
			{ "63", "XXXL" },
			{ "64", "XXXXL" },
			{ "65", "XXXXL" },
		};

		public static readonly string[,] Gloves = new string[,] {
			{ "6", "XXS" },
			{ "6,5", "XS" },
			{ "7", "S" },
			{ "7,5", "M" },
			{ "8", "L" },
			{ "8,5", "XL" },
			{ "9", "XXL" },
			{ "9,5", "XXXL" },
			{ "10", null },
			{ "10,5", null },
			{ "11", null },
			{ "11,5", null },
			{ "12", null },
		};

	}

	public struct WearGrowth{
		public string Name;
		public int Upper;
		public int Lower;

		public WearGrowth(string name, int upper, int lower)
		{
			Name = name;
			Upper = upper;
			Lower = lower;
		}
	}
}


﻿using System;

namespace workwear.Measurements
{
	public static class LookupSizes
	{
		public static readonly WearGrowth[] WomenGrowth = new WearGrowth[] {
			new WearGrowth("146", 143, 149),
			new WearGrowth("146-152", 155, 167, SizeUse.СlothesOnly, "146", "152"),
			new WearGrowth("152", 149, 155),
			new WearGrowth("155-166", 155, 166, SizeUse.СlothesOnly, "158"),
			new WearGrowth("158", 155, 161),
			new WearGrowth("158-164", 155, 167, SizeUse.СlothesOnly, "158", "164"),
			new WearGrowth("164", 161, 167),
			new WearGrowth("167-178", 167, 178, SizeUse.СlothesOnly, "170"),
			new WearGrowth("170", 167, 173),
			new WearGrowth("170-176", 167, 179, SizeUse.СlothesOnly, "170", "176"),
			new WearGrowth("176", 173, 179),
			new WearGrowth("179-190", 179, 190, SizeUse.СlothesOnly, "182"),
			new WearGrowth("182", 179, 185),
			new WearGrowth("182-188", 179, 191, SizeUse.СlothesOnly, "182", "188"),
			new WearGrowth("188", 185, 191),
			new WearGrowth("191-200", 191, 200, SizeUse.СlothesOnly),
		};

		public static readonly WearGrowth[] MenGrowth = new WearGrowth[] {
			new WearGrowth("146", 143, 149),
			new WearGrowth("146-152", 155, 167, SizeUse.СlothesOnly, "146", "152"),
			new WearGrowth("152", 149, 155),
			new WearGrowth("155-166", 155, 166, SizeUse.СlothesOnly, "158"),
			new WearGrowth("158", 155, 161),
			new WearGrowth("158-164", 155, 167, SizeUse.СlothesOnly, "158", "164"),
			new WearGrowth("164", 161, 167),
			new WearGrowth("167-178", 167, 178, SizeUse.СlothesOnly, "170"),
			new WearGrowth("170", 167, 173),
			new WearGrowth("170-176", 167, 179, SizeUse.СlothesOnly, "170", "176"),
			new WearGrowth("176", 173, 179),
			new WearGrowth("179-190", 179, 190, SizeUse.СlothesOnly, "182"),
			new WearGrowth("182", 179, 185),
			new WearGrowth("182-188", 179, 191, SizeUse.СlothesOnly, "182", "188"),
			new WearGrowth("188", 185, 191),
			new WearGrowth("191-200", 191, 200, SizeUse.СlothesOnly, "194"),
			new WearGrowth("194", 191, 197),
			new WearGrowth("194-200", 191, 203, SizeUse.СlothesOnly, "194", "200"),
			new WearGrowth("200", 197, 203),
			new WearGrowth("201-210", 201, 210, SizeUse.СlothesOnly),
		};

		public static readonly WearGrowth[] UniversalGrowth = new WearGrowth[] {
			new WearGrowth("146", 143, 149),
			new WearGrowth("146-152", 155, 167, SizeUse.СlothesOnly, "146", "152"),
			new WearGrowth("152", 149, 155),
			new WearGrowth("155-166", 155, 166, SizeUse.СlothesOnly, "158"),
			new WearGrowth("158", 155, 161),
			new WearGrowth("158-164", 155, 167, SizeUse.СlothesOnly, "158", "164"),
			new WearGrowth("164", 161, 167),
			new WearGrowth("167-178", 167, 178, SizeUse.СlothesOnly, "170"),
			new WearGrowth("170", 167, 173),
			new WearGrowth("170-176", 167, 179, SizeUse.СlothesOnly, "170", "176"),
			new WearGrowth("176", 173, 179),
			new WearGrowth("179-190", 179, 190, SizeUse.СlothesOnly, "182"),
			new WearGrowth("182", 179, 185),
			new WearGrowth("182-188", 179, 191, SizeUse.СlothesOnly, "182", "188"),
			new WearGrowth("188", 185, 191),
			new WearGrowth("191-200", 191, 200, SizeUse.СlothesOnly, "194"),
			new WearGrowth("194", 191, 197),
			new WearGrowth("194-200", 191, 203, SizeUse.СlothesOnly, "194", "200"),
			new WearGrowth("200", 197, 203),
			new WearGrowth("201-210", 201, 210, SizeUse.СlothesOnly),
		};

		public static readonly WearSize[] MenWear = {
			new WearSize(new []{ "40", null }),
			new WearSize(new []{ "40-42", null }, SizeUse.СlothesOnly, new []{ "40", null }, new []{ "42", null }),
			new WearSize(new []{ "42", null }),
			new WearSize(new []{ "44", "XXS" }),
			new WearSize(new []{ "44-46", null }, SizeUse.СlothesOnly, new []{ "44", "XXS" }, new []{ "46", "XS" }),
			new WearSize(new []{ "46", "XS" }),
			new WearSize(new []{ "48", "S" }),
			new WearSize(new []{ "48-50", null }, SizeUse.СlothesOnly, new []{ "48", "S" }, new []{ "50", "M" }),
			new WearSize(new []{ "50", "M" }),
			new WearSize(new []{ "50-52", null }, SizeUse.СlothesOnly, new []{ "50", "M" }, new []{ "52", "L" }),
			new WearSize(new []{ "52", "L" }),
			new WearSize(new []{ "52-54", null }, SizeUse.СlothesOnly, new []{ "52", "L" }, new []{ "54", "XL" }),
			new WearSize(new []{ "54", "XL" }),
			new WearSize(new []{ "56", "XXL" }),
			new WearSize(new []{ "56-58", null }, SizeUse.СlothesOnly, new []{ "56", "XXL" }, new []{ "58", "XXXL" }),
			new WearSize(new []{ "58", "XXXL" }),
			new WearSize(new []{ "58-60", null }, SizeUse.СlothesOnly, new []{ "58", "XXXL" }, new []{ "60", "XXXL" }),
			new WearSize(new []{ "60", "XXXL" }),
			new WearSize(new []{ "60-62", null }, SizeUse.СlothesOnly, new []{ "60", "XXXL" }, new []{ "62", "XXXL" }),
			new WearSize(new []{ "62", "XXXL" }),
			new WearSize(new []{ "62-64", null }, SizeUse.СlothesOnly, new []{ "62", "XXXL" }, new []{ "64", "4XL" }),
			new WearSize(new []{ "64", "4XL" }),
			new WearSize(new []{ "64-66", null }, SizeUse.СlothesOnly, new []{ "64", "4XL" }, new []{ "66", "4XL" }),
			new WearSize(new []{ "66", "4XL" }),
			new WearSize(new []{ "68", "5XL" }),
			new WearSize(new []{ "68-70", null }, SizeUse.СlothesOnly, new []{ "68", "5XL" }, new []{ "70", "5XL" }),
			new WearSize(new []{ "70", "5XL" }),
			new WearSize(new []{ "72", null }),
			new WearSize(new []{ "72-74", null }, SizeUse.СlothesOnly, new []{ "72", null }, new []{ "74", null }),
			new WearSize(new []{ "74", null }),
			new WearSize(new []{ "74-76", null }, SizeUse.СlothesOnly, new []{ "74", null }, new []{ "76", null }),
			new WearSize(new []{ "76", null }),
			new WearSize(new []{ "76-78", null }, SizeUse.СlothesOnly, new []{ "76", null }, new []{ "78", null }),
			new WearSize(new []{ "78", null }),
			new WearSize(new []{ "80", null }),
			new WearSize(new []{ "80-82", null }, SizeUse.СlothesOnly, new []{ "80", null }, new []{ "82", null }),
			new WearSize(new []{ "82", null }),
		};

		public static readonly WearSize[] WomenWear = {
			new WearSize(new []{ "38", "XXS" }),
			new WearSize(new []{ "40", "XS" }),
			new WearSize(new []{ "40-42", null }, SizeUse.СlothesOnly, new []{ "40", "XS" }, new []{ "42", "S" }),
			new WearSize(new []{ "42", "S" }),
			new WearSize(new []{ "44", "M" }),
			new WearSize(new []{ "44-46", null }, SizeUse.СlothesOnly, new []{ "44", "M" }, new []{ "46", "M" }),
			new WearSize(new []{ "46", "M" }),
			new WearSize(new []{ "48", "L" }),
			new WearSize(new []{ "48-50", null }, SizeUse.СlothesOnly, new []{ "48", "L" }, new []{ "50", "L" }),
			new WearSize(new []{ "50", "L" }),
			new WearSize(new []{ "50-52", null }, SizeUse.СlothesOnly, new []{ "50", "L" }, new []{ "52", "XL" }),
			new WearSize(new []{ "52", "XL" }),
			new WearSize(new []{ "52-54", null }, SizeUse.СlothesOnly, new []{ "52", "XL" }, new []{ "54", "XXL" }),
			new WearSize(new []{ "54", "XXL" }),
			new WearSize(new []{ "56", "XXL" }),
			new WearSize(new []{ "56-58", null }, SizeUse.СlothesOnly, new []{ "56", "XXL" }, new []{ "58", "XXXL" }),
			new WearSize(new []{ "58", "XXXL" }),
			new WearSize(new []{ "58-60", null }, SizeUse.СlothesOnly, new []{ "58", "XXXL" }, new []{ "60", "4XL" }),
			new WearSize(new []{ "60", "4XL" }),
			new WearSize(new []{ "60-62", null }, SizeUse.СlothesOnly, new []{ "60", "4XL" }, new []{ "62", "4XL" }),
			new WearSize(new []{ "62", "4XL" }),
			new WearSize(new []{ "62-64", null }, SizeUse.СlothesOnly, new []{ "62", "4XL" }, new []{ "64", "4XL" }),
			new WearSize(new []{ "64", "4XL" }),
			new WearSize(new []{ "64-66", null }, SizeUse.СlothesOnly, new []{ "64", "4XL" }, new []{ "66", "5XL" }),
			new WearSize(new []{ "66", "5XL" }),
			new WearSize(new []{ "68", "5XL" }),
			new WearSize(new []{ "68-70", null }, SizeUse.СlothesOnly, new []{ "68", "5XL" }, new []{ "70", "5XL" }),
			new WearSize(new []{ "70", "5XL" }),
		};

		public static readonly WearSize[] UnisexWear = {
			new WearSize(new []{ "38", "XXS" }),
			new WearSize(new []{ "40", "XS" }),
			new WearSize(new []{ "40-42", null }, SizeUse.СlothesOnly, new []{ "40", "XS" }, new []{ "42", "S" }),
			new WearSize(new []{ "42", "S" }),
			new WearSize(new []{ "44", "M" }),
			new WearSize(new []{ "44-46", null }, SizeUse.СlothesOnly, new []{ "44", "M" }, new []{ "46", "M" }),
			new WearSize(new []{ "46", "M" }),
			new WearSize(new []{ "48", "L" }),
			new WearSize(new []{ "48-50", null }, SizeUse.СlothesOnly, new []{ "48", "L" }, new []{ "50", "L" }),
			new WearSize(new []{ "50", "L" }),
			new WearSize(new []{ "50-52", null }, SizeUse.СlothesOnly, new []{ "50", "L" }, new []{ "52", "XL" }),
			new WearSize(new []{ "52", "XL" }),
			new WearSize(new []{ "52-54", null }, SizeUse.СlothesOnly, new []{ "52", "XL" }, new []{ "54", "XXL" }),
			new WearSize(new []{ "54", "XXL" }),
			new WearSize(new []{ "56", "XXL" }),
			new WearSize(new []{ "56-58", null }, SizeUse.СlothesOnly, new []{ "56", "XXL" }, new []{ "58", "XXXL" }),
			new WearSize(new []{ "58", "XXXL" }),
			new WearSize(new []{ "58-60", null }, SizeUse.СlothesOnly, new []{ "58", "XXXL" }, new []{ "60", "4XL" }),
			new WearSize(new []{ "60", "4XL" }),
			new WearSize(new []{ "60-62", null }, SizeUse.СlothesOnly, new []{ "60", "4XL" }, new []{ "62", "4XL" }),
			new WearSize(new []{ "62", "4XL" }),
			new WearSize(new []{ "62-64", null }, SizeUse.СlothesOnly, new []{ "62", "4XL" }, new []{ "64", "4XL" }),
			new WearSize(new []{ "64", "4XL" }),
			new WearSize(new []{ "64-66", null }, SizeUse.СlothesOnly, new []{ "64", "4XL" }, new []{ "66", "5XL" }),
			new WearSize(new []{ "66", "5XL" }),
			new WearSize(new []{ "68", "5XL" }),
			new WearSize(new []{ "68-70", null }, SizeUse.СlothesOnly, new []{ "68", "5XL" }, new []{ "70", "5XL" }),
			new WearSize(new []{ "70", "5XL" }),
			new WearSize(new []{ "72", null }),
			new WearSize(new []{ "72-74", null }, SizeUse.СlothesOnly, new []{ "72", null }, new []{ "74", null }),
			new WearSize(new []{ "74", null }),
			new WearSize(new []{ "74-76", null }, SizeUse.СlothesOnly, new []{ "74", null }, new []{ "76", null }),
			new WearSize(new []{ "76", null }),
			new WearSize(new []{ "76-78", null }, SizeUse.СlothesOnly, new []{ "76", null }, new []{ "78", null }),
			new WearSize(new []{ "78", null }),
			new WearSize(new []{ "80", null }),
			new WearSize(new []{ "80-82", null }, SizeUse.СlothesOnly, new []{ "80", null }, new []{ "82", null }),
			new WearSize(new []{ "82", null }),
		};

		public static readonly WearSize[] MenShoes = {
			new WearSize(new []{ "36", "36" }),
			new WearSize(new []{ "36-37", null }, SizeUse.СlothesOnly, new []{ "36", "36" }, new []{ "37", "37" }),
			new WearSize(new []{ "37", "37" }),
			new WearSize(new []{ "38", "38" }),
			new WearSize(new []{ "38-39", null }, SizeUse.СlothesOnly, new []{ "38", "38" }, new []{ "39", "39" }),
			new WearSize(new []{ "39", "39" }),
			new WearSize(new []{ "40", "40" }),
			new WearSize(new []{ "40,5", "41" }),
			new WearSize(new []{ "40-41", null }, SizeUse.СlothesOnly, new []{ "40", "40" }, new []{ "40,5", "41" }, new []{ "41", "41,5" }),
			new WearSize(new []{ "41", "41,5" }),
			new WearSize(new []{ "42", "42" }),
			new WearSize(new []{ "42-43", null }, SizeUse.СlothesOnly, new []{ "42", "42" }, new []{ "43", "43" }, new []{ "43,5", "44" }),
			new WearSize(new []{ "43", "43" }),
			new WearSize(new []{ "43,5", "44" }),
			new WearSize(new []{ "44", "44,5" }),
			new WearSize(new []{ "44-45", null }, SizeUse.СlothesOnly, new []{ "43,5", "44" }, new []{ "44", "44,5" }, new []{ "45", "45" }),
			new WearSize(new []{ "45", "45" }),
			new WearSize(new []{ "46", "46" }),
			new WearSize(new []{ "46,5", "47" }),
			new WearSize(new []{ "46-47", null }, SizeUse.СlothesOnly, new []{ "46", "46" }, new []{ "46,5", "47" }, new []{ "47", "47,5" }),
			new WearSize(new []{ "47", "47,5" }),
			new WearSize(new []{ "48", "48" }),
			new WearSize(new []{ "49", null }),
			new WearSize(new []{ "50", null }),
		};

		public static readonly WearSize[] WomenShoes = {
			new WearSize(new []{ "34", "34" }),
			new WearSize(new []{ "34,5", "35" }),
			new WearSize(new []{ "34-35", null }, SizeUse.СlothesOnly, new []{ "34", "34" }, new []{ "34,5", "35" }, new []{ "35", "35,5" }),
			new WearSize(new []{ "35", "35,5" }),
			new WearSize(new []{ "36", "36" }),
			new WearSize(new []{ "36-37", null }, SizeUse.СlothesOnly, new []{ "36", "36" }, new []{ "37", "37" }, new []{ "37,5", "38" }),
			new WearSize(new []{ "37", "37" }),
			new WearSize(new []{ "37,5", "38" }),
			new WearSize(new []{ "38", "38,5" }),
			new WearSize(new []{ "38,5", "39" }),
			new WearSize(new []{ "38-39", null }, SizeUse.СlothesOnly, new []{ "38", "38,5" }, new []{ "38,5", "39" }, new []{ "39", "39,5" }),
			new WearSize(new []{ "39", "39,5" }),
			new WearSize(new []{ "40", "40" }),
			new WearSize(new []{ "40,5", "41" }),
			new WearSize(new []{ "40-41", null }, SizeUse.СlothesOnly, new []{ "40", "40" }, new []{ "40,5", "41" }, new []{ "41", "41,5" }),
			new WearSize(new []{ "41", "41,5" }),
			new WearSize(new []{ "42", "42" }),
			new WearSize(new []{ "42-43", null }, SizeUse.СlothesOnly, new []{ "42", "42" }, new []{ "43", "43" }),
			new WearSize(new []{ "43", "43" }),
			new WearSize(new []{ null, "44" }),
		};

		public static readonly WearSize[] UnisexShoes = {
			new WearSize(new []{ "34", "34" }),
			new WearSize(new []{ "34-35", null }, SizeUse.СlothesOnly, new []{ "34", "34" }, new []{ "35", "35,5" }),
			new WearSize(new []{ "35", "35,5" }),
			new WearSize(new []{ "36", "36" }),
			new WearSize(new []{ "36-37", null }, SizeUse.СlothesOnly, new []{ "36", "36" }, new []{ "37", "37" }),
			new WearSize(new []{ "37", "37" }),
			new WearSize(new []{ "38", "38,5" }),
			new WearSize(new []{ "38-39", null }, SizeUse.СlothesOnly, new []{ "38", "38,5" }, new []{ "39", "39,5" }),
			new WearSize(new []{ "39", "39,5" }),
			new WearSize(new []{ "40", "40" }),
			new WearSize(new []{ "40-41", null }, SizeUse.СlothesOnly, new []{ "40", "40" }, new []{ "41", "41,5" }),
			new WearSize(new []{ "41", "41,5" }),
			new WearSize(new []{ "42", "42" }),
			new WearSize(new []{ "42-43", null }, SizeUse.СlothesOnly, new []{ "42", "42" }, new []{ "43", "43" }),
			new WearSize(new []{ "43", "43" }),
			new WearSize(new []{ "44", "44,5" }),
			new WearSize(new []{ "44-45", null }, SizeUse.СlothesOnly, new []{ "44", "44,5" }, new []{ "45", "45" }),
			new WearSize(new []{ "45", "45" }),
			new WearSize(new []{ "46", "46" }),
			new WearSize(new []{ "46-47", null }, SizeUse.СlothesOnly, new []{ "46", "46" }, new []{ "47", "47,5" }),
			new WearSize(new []{ "47", "47,5" }),
			new WearSize(new []{ "48", "48" }),
			new WearSize(new []{ "49", null }),
			new WearSize(new []{ "50", null }),
		};

		public static readonly WearSize[] Headdress = {
			new WearSize(new []{ "54", "XXS" }),
			new WearSize(new []{ "55", "XS" }),
			new WearSize(new []{ "56", "S" }),
			new WearSize(new []{ "57", "M" }),
			new WearSize(new []{ "58", "L" }),
			new WearSize(new []{ "58-60", null }, SizeUse.СlothesOnly, new []{ "58", "L" }, new []{ "60", "XXL" }),
			new WearSize(new []{ "59", "XL" }),
			new WearSize(new []{ "59-60", null }, SizeUse.СlothesOnly, new []{ "59", "XL" }, new []{ "60", "XXL" }),
			new WearSize(new []{ "60", "XXL" }),
			new WearSize(new []{ "61", "XXL" }),
			new WearSize(new []{ "62", "XXXL" }),
			new WearSize(new []{ "63", "XXXL" }),
			new WearSize(new []{ "64", "XXXXL" }),
			new WearSize(new []{ "65", "XXXXL" }),
		};

		public static readonly WearSize[] Gloves = {
			new WearSize(new []{ "6", "XXS" }),
			new WearSize(new []{ "6,5", "XS" }),
			new WearSize(new []{ "7", "S" }),
			new WearSize(new []{ "7,5", "M" }),
			new WearSize(new []{ "8", "L" }),
			new WearSize(new []{ "8,5", "XL" }),
			new WearSize(new []{ "9", "XXL" }),
			new WearSize(new []{ "9,5", "XXXL" }),
			new WearSize(new []{ "10", null }),
			new WearSize(new []{ "10,5", null }),
			new WearSize(new []{ "11", null }),
			new WearSize(new []{ "11,5", null }),
			new WearSize(new []{ "12", null }),
			new WearSize(new []{ "13", null }),
		};

		public static readonly WearSize[] Mittens = {
			new WearSize(new []{ "1"}),
			new WearSize(new []{ "2"}),
			new WearSize(new []{ "3"}),
		};
	}
}


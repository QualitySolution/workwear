﻿using System;
using System.Linq;
using QS.Project.Versioning.Product;
using QS.Serial;
using QS.Serial.Encoding;

namespace workwear.Tools.Features
{
	public class FeaturesService : IProductService
	{
		public static ProductEdition[] SupportEditions = new[] {
			new ProductEdition(1, "Однопользовательская"),
			new ProductEdition(2, "Профессиональная"),
			new ProductEdition(3, "Предприятие")
		};
		private readonly SerialNumberEncoder serialNumberEncoder;

		public byte ProductEdition { get; }

		public string EditionName => SupportEditions.First(x => x.Number == ProductEdition).Name;

		public FeaturesService(ISerialNumberService serialNumberService, SerialNumberEncoder serialNumberEncoder)
		{
			this.serialNumberEncoder = serialNumberEncoder ?? throw new ArgumentNullException(nameof(serialNumberEncoder));

			ProductEdition = 1;

			if(String.IsNullOrWhiteSpace(serialNumberService.SerialNumber))
				return;

			serialNumberEncoder.Number = serialNumberService.SerialNumber;
			if(serialNumberEncoder.IsValid) {
				if(serialNumberEncoder.CodeVersion == 1)
					ProductEdition = 2; //Все купленные серийные номера версии 1 приравниваются к професиональной редации.
				else if(serialNumberEncoder.CodeVersion == 2 
						&& serialNumberEncoder.EditionId >= 1
						&& serialNumberEncoder.EditionId <= 3) 
					ProductEdition = serialNumberEncoder.EditionId;
			}
		}

		/// <summary>
		/// Используется только для тестов!!!
		/// </summary>
		public FeaturesService()
		{
		}

		virtual public bool Available(WorkwearFeature feature)
		{
			switch(feature) {
				case WorkwearFeature.Warehouses:
					return ProductEdition == 3;
				case WorkwearFeature.IdentityCards:
					return ProductEdition == 3;
				default:
					return false;
			}
		}
	}

	public enum WorkwearFeature
	{
		Warehouses,
		IdentityCards,
	}
}

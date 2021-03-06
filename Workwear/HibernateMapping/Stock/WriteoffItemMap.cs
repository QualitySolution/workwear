﻿using FluentNHibernate.Mapping;
using workwear.Domain.Stock;

namespace workwear.HMap
{
	public class WriteoffItemMap : ClassMap<WriteoffItem>
	{
		public WriteoffItemMap ()
		{
			Table ("stock_write_off_detail");

			Id (x => x.Id).Column ("id").GeneratedBy.Native ();
			Map (x => x.Amount).Column ("quantity");
			Map(x => x.Size).Column("size");
			Map(x => x.WearGrowth).Column("growth");
			Map(x => x.AktNumber).Column("akt_number");

			References(x => x.Document).Column("stock_write_off_id").Cascade.All();
			References(x => x.Nomenclature).Column ("nomenclature_id");
			References(x => x.EmployeeWriteoffOperation).Column("employee_issue_operation_id").Cascade.All();
			References(x => x.SubdivisionWriteoffOperation).Column ("subdivision_issue_operation_id").Cascade.All();
			References(x => x.Warehouse).Column("warehouse_id");
			References(x => x.WarehouseOperation).Column("warehouse_operation_id").Cascade.All();
		}
	}
}
﻿using System;
using Gamma.ColumnConfig;
using QS.Journal.GtkUI;
using workwear.JournalViewModels.Company;
using workwear.JournalViewModels.Statements;

namespace workwear.JournalViewModels
{
	public static class JournalsColumnsConfigs
	{
		public static void RegisterColumns()
		{
			TreeViewColumnsConfigFactory.Register<OrganizationJournalViewModel>(
				() => FluentColumnsConfig<ClientJournalNode>.Create()
					.AddColumn("Код").AddTextRenderer(node => node.Id.ToString()).SearchHighlight()
					.AddColumn("Название").AddTextRenderer(node => node.Name).SearchHighlight()
					.AddColumn("Адрес").AddTextRenderer(node => node.Address).SearchHighlight()
					.Finish()
			);

			TreeViewColumnsConfigFactory.Register<IssuanceSheetJournalViewModel>(
				() => FluentColumnsConfig<IssuanceSheetJournalNode>.Create()
					.AddColumn("Номер").AddTextRenderer(node => node.Id.ToString()).SearchHighlight()
					.AddColumn("Дата").AddTextRenderer(node => node.Date.ToShortDateString())
					.AddColumn("Организация").AddTextRenderer(node => node.Organigation).SearchHighlight()
					.AddColumn("Код подр.").AddTextRenderer(node => node.SubdivisionCode).SearchHighlight()
					.AddColumn("Подразделение").AddTextRenderer(node => node.Subdivision).SearchHighlight()
					.Finish()
			);
		}
	}
}
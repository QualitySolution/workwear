﻿using System;
using Gamma.ColumnConfig;
using QS.Journal.GtkUI;
using workwear.Journal.ViewModels.Stock;
using workwear.JournalViewModels.Company;
using workwear.JournalViewModels.Statements;
using workwear.JournalViewModels.Stock;

namespace workwear.Journal
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

			TreeViewColumnsConfigFactory.Register<LeadersJournalViewModel>(
				() => FluentColumnsConfig<LeaderJournalNode>.Create()
					.AddColumn("Номер").AddTextRenderer(node => node.Id.ToString()).SearchHighlight()
					.AddColumn("Фамилия").AddTextRenderer(node => node.SurName).SearchHighlight()
					.AddColumn("Имя").AddTextRenderer(node => node.Name).SearchHighlight()
					.AddColumn("Отчество").AddTextRenderer(node => node.Patronymic).SearchHighlight()
					.AddColumn("Должность").AddTextRenderer(node => node.Position).SearchHighlight()
					.Finish()
			);

			TreeViewColumnsConfigFactory.Register<WarehouseJournalViewModel>(
			() => FluentColumnsConfig<WarehouseJournalNode>.Create()
				.AddColumn("Номер").AddTextRenderer(node => node.Id.ToString()).SearchHighlight()
				.AddColumn("Название").AddTextRenderer(node => node.Name).SearchHighlight()
				.Finish()
		);

			TreeViewColumnsConfigFactory.Register<StockBalanceJournalViewModel>(
			() => FluentColumnsConfig<StockBalanceJournalNode>.Create()
			.AddColumn("Наименование").AddTextRenderer(e => e.NomenclatureName).SearchHighlight()
			.AddColumn("Размер").AddTextRenderer(e => e.Size).SearchHighlight()
			.AddColumn("Рост").AddTextRenderer(e => e.Growth).SearchHighlight()
			.AddColumn("Количество").AddTextRenderer(e => e.BalanceText, useMarkup: true)
			.AddColumn("Процент износа").AddTextRenderer(e => e.WearPercentText)
			.Finish()
		);
		}
	}
}
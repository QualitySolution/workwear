﻿using workwear.DTO;
using workwear.Repository.Operations;
using workwear.ViewModels.Company.EmployeeChilds;

namespace workwear.Views.Company.EmployeeChilds
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class EmployeeMovementsView : Gtk.Bin
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		private EmployeeMovementsViewModel viewModel;

		public EmployeeMovementsView()
		{
			this.Build();

			ytreeviewMovements.CreateFluentColumnsConfig<EmployeeCardMovements>()
				.AddColumn("Дата").AddTextRenderer(e => e.Date.ToShortDateString())
				//Заголовок колонки используется в методе YtreeviewMovements_RowActivated
				.AddColumn("Документ").AddTextRenderer(e => e.DocumentName)
				.AddColumn("Номенклатура").AddTextRenderer(e => e.NomenclatureName)
				.AddColumn("% износа").AddTextRenderer(e => e.WearPercentText)
				.AddColumn("Стоимость").AddTextRenderer(e => e.CostText)
				.AddColumn("Получено").AddTextRenderer(e => e.AmountReceivedText)
				.AddColumn("Сдано\\списано").AddTextRenderer(e => e.AmountReturnedText)
				.AddColumn("Автосписание").AddToggleRenderer(e => e.UseAutoWriteOff, false)
					.AddSetter((c, e) => c.Visible = e.ReferencedDocument?.DocType == EmployeeIssueOpReferenceDoc.ReceivedFromStock)
					.AddSetter((c, e) => c.Activatable = e.Operation.ExpiryByNorm.HasValue)
					.AddTextRenderer(e => e.AutoWriteOffDateTextColored, useMarkup: true)
				.AddColumn("")
				.Finish();
			ytreeviewMovements.RowActivated += YtreeviewMovements_RowActivated;
		}

		public EmployeeMovementsViewModel ViewModel {
			get => viewModel; 
			set {
				viewModel = value;
				viewModel.PropertyChanged += ViewModel_PropertyChanged;
			}
		}

		void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(viewModel.Movements))
				ytreeviewMovements.ItemsDataSource = viewModel.Movements;
		}

		public void YtreeviewMovements_RowActivated(object o, Gtk.RowActivatedArgs args)
		{
			if(args.Column.Title == "Документ") {
				var item = ytreeviewMovements.GetSelectedObject<EmployeeCardMovements>();
				ViewModel.OpenDoc(item);
			}
		}
	}
}

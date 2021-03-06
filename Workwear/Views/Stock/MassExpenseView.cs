using System;
using System.Linq;
using Gtk;
using QS.Views.Dialog;
using workwear.Domain.Company;
using workwear.Domain.Statements;
using workwear.Domain.Stock;
using workwear.Measurements;
using workwear.ViewModels.Stock;

namespace workwear.Views.Stock
{
	public partial class MassExpenseView : EntityDialogViewBase<MassExpenseViewModel, MassExpense>
	{
		public MassExpenseView(MassExpenseViewModel viewModel) : base(viewModel)
		{
			this.Build();
			ConfigureDlg();
			CommonButtonSubscription();
		}

		private void ConfigureDlg()
		{
			datepicker.Binding.AddBinding(Entity, e => e.Date, w => w.Date).InitializeFromSource();
			ytextComment.Binding.AddBinding(Entity, e => e.Comment, w => w.Buffer.Text).InitializeFromSource();
			entityentryWarehouseExpense.ViewModel = ViewModel.WarehouseFromEntryViewModel;

			ViewModel.PropertyChanged += ViewModel_PropertyChanged;

			tableNomenclature.CreateFluentColumnsConfig<MassExpenseNomenclature>()
			.AddColumn("Наименование").Tag("Name").AddTextRenderer(x => x.Nomenclature != null ? x.Nomenclature.Name : String.Empty)
			.AddColumn("Тип").Tag("Type").AddTextRenderer(x => x.Nomenclature != null ? x.Nomenclature.TypeName : String.Empty)
			.AddColumn("Количество").Tag("Count")
			.AddNumericRenderer(x => x.Amount, false).Editing(true).Adjustment(new Adjustment(1, 0, 100000, 1, 10, 10)).WidthChars(8)
			.AddTextRenderer(x => x.Nomenclature != null && x.Nomenclature.Type.Units != null ? x.Nomenclature.Type.Units.Name : String.Empty, false)
			.Finish();

			tableNomenclature.Selection.Changed += Selection_Changed_Nomenclature;
			tableNomenclature.Selection.Mode = SelectionMode.Multiple;
			tableNomenclature.ItemsDataSource = ViewModel.Entity.ObservableItemsNomenclature;


			tableEmployee.CreateFluentColumnsConfig<MassExpenseEmployee>()
			.AddColumn("Фамилия").MinWidth(120).Tag("LastName").AddTextRenderer(x => x.LastName).Editable()
			.AddColumn("Имя").MinWidth(120).Tag("Name").AddTextRenderer(x => x.FirstName).Editable()
			.AddColumn("Отчество").MinWidth(120).Tag("Patronomic").AddTextRenderer(x => x.Patronymic).Editable()
			.AddColumn("Пол").Tag("Sex").AddEnumRenderer(x => x.Sex).Editing()
			.AddColumn("Размер").Tag(СlothesType.Wear)
				.AddComboRenderer(x => x.WearSizeStd).Editing()
				.DynamicFillListFunc(x => SizeHelper.GetSizeStandartsListOfCodes(СlothesType.Wear, x.Sex))
				.SetDisplayFunc(SizeHelper.GetSizeStdShortTitle)
				.AddComboRenderer(x => x.WearSize)
				.DynamicFillListFunc(x => ViewModel.GetSizes(x.WearSizeStd))
				.AddSetter((c, n) => c.Editable = !String.IsNullOrWhiteSpace(n.WearSizeStd))
			.AddColumn("Рост").Tag("Growth").AddComboRenderer(x => x.WearGrowth)
				.DynamicFillListFunc(x => ViewModel.GetGrowths(x.Sex))
				.AddSetter((c, n) => c.Editable = n.Sex != Sex.None)
			.AddColumn("Размер обуви").Tag(СlothesType.Shoes)
				.AddComboRenderer(x => x.ShoesSizeStd).Editing()
				.DynamicFillListFunc(x => SizeHelper.GetSizeStandartsListOfCodes(СlothesType.Shoes, x.Sex))
				.SetDisplayFunc(SizeHelper.GetSizeStdShortTitle)
				.AddComboRenderer(x => x.ShoesSize)
				.DynamicFillListFunc(x => ViewModel.GetSizes(x.ShoesSizeStd))
				.AddSetter((c, n) => c.Editable = !String.IsNullOrWhiteSpace(n.ShoesSizeStd))
			.AddColumn("Размер зимней обуви").Tag(СlothesType.WinterShoes)
				.AddComboRenderer(x => x.WinterShoesSizeStd).Editing()
				.DynamicFillListFunc(x => SizeHelper.GetSizeStandartsListOfCodes(СlothesType.WinterShoes, x.Sex))
				.SetDisplayFunc(SizeHelper.GetSizeStdShortTitle)
				.AddComboRenderer(x => x.WinterShoesSize)
				.DynamicFillListFunc(x => ViewModel.GetSizes(x.WinterShoesSizeStd))
				.AddSetter((c, n) => c.Editable = !String.IsNullOrWhiteSpace(n.WinterShoesSizeStd))
			.AddColumn("Размер головного убора").Tag(СlothesType.Headgear)
				.AddComboRenderer(x => x.HeaddressSizeStd).Editing()
				.DynamicFillListFunc(x => SizeHelper.GetSizeStandartsListOfCodes(СlothesType.Headgear, x.Sex))
				.SetDisplayFunc(SizeHelper.GetSizeStdShortTitle)
				.AddComboRenderer(x => x.HeaddressSize)
				.DynamicFillListFunc(x => ViewModel.GetSizes(x.HeaddressSizeStd))
				.AddSetter((c, n) => c.Editable = !String.IsNullOrWhiteSpace(n.HeaddressSizeStd))
			.AddColumn("Размер перчаток").Tag(СlothesType.Gloves)
				.AddComboRenderer(x => x.GlovesSizeStd).Editing()
				.DynamicFillListFunc(x => SizeHelper.GetSizeStandartsListOfCodes(СlothesType.Gloves, x.Sex))
				.SetDisplayFunc(SizeHelper.GetSizeStdShortTitle)
				.AddComboRenderer(x => x.GlovesSize)
				.DynamicFillListFunc(x => ViewModel.GetSizes(x.GlovesSizeStd))
				.AddSetter((c, n) => c.Editable = !String.IsNullOrWhiteSpace(n.GlovesSizeStd))
			.AddColumn("Размер рукавиц").Tag(СlothesType.Mittens)
				.AddComboRenderer(x => x.MittensSize)
				.DynamicFillListFunc(x => ViewModel.GetSizes(x.MittensSizeStd))
				.AddSetter((c, n) => c.Editable = !String.IsNullOrWhiteSpace(n.MittensSizeStd))
			.AddColumn(String.Empty)
			.Finish();

			enumPrint.ItemsEnum = typeof(IssuedSheetPrint);

			tableEmployee.Selection.Changed += Selection_Changed_Employee;
			tableEmployee.Selection.Mode = SelectionMode.Multiple;
			tableEmployee.ItemsDataSource = ViewModel.Entity.ObservableEmployeeCard;

			Entity.ObservableItemsNomenclature.ListContentChanged += ObservableItemsNomenclature_ListContentChanged;
			Entity.ObservableEmployeeCard.ListContentChanged += ObservableEmployeeCard_ListContentChanged;
			Entity.PropertyChanged += EntityChange;

			foreach(var column in tableEmployee.ColumnsConfig.ConfiguredColumns)
				if (!(column.tag == "LastName" || column.tag == "Name" || column.tag == "Patronomic" || column.tag == "Sex" || column.Title == string.Empty))
					column.TreeViewColumn.Visible = false;
			refreshSizeColumns();
			IssuanceSheetSensetive();

			buttonAddNomenclature.Sensitive = Entity.WarehouseFrom != null;
		}

		void ObservableEmployeeCard_ListContentChanged(object sender, EventArgs e)
		{
			IssuanceSheetSensetive();
		}

		void EntityChange(object sender, EventArgs e)
		{
			buttonAddNomenclature.Sensitive = Entity.WarehouseFrom != null;
		}

		void ObservableItemsNomenclature_ListContentChanged(object sender, EventArgs e)
		{
			refreshSizeColumns();
			IssuanceSheetSensetive();
		}

		void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(ViewModel.DisplayMessage))
				textMessage.Markup = ViewModel.DisplayMessage;
		}


		private void refreshSizeColumns()
		{
			foreach(var column in tableEmployee.ColumnsConfig.ConfiguredColumns) {
				if( column.tag == "Growth") {
					column.TreeViewColumn.Visible = Entity.ItemsNomenclature.Any(x => x.Nomenclature.Type.WearCategory != null && SizeHelper.HasGrowthStandart(x.Nomenclature.Type.WearCategory.Value));
				}
				if(column.tag is СlothesType) {
					column.TreeViewColumn.Visible = Entity.ItemsNomenclature.Any(x => x.Nomenclature.Type.WearCategory != null && x.Nomenclature.Type.WearCategory.Value.Equals(column.tag));
				}
			}
		}

		void Selection_Changed_Nomenclature(object sender, EventArgs e)
		{
			buttonRemoveNomenclature.Sensitive = tableNomenclature.Selection.CountSelectedRows() > 0;
		}

		void Selection_Changed_Employee(object sender, EventArgs e)
		{
			buttonRemoveEmployee.Sensitive = tableEmployee.Selection.CountSelectedRows() > 0;
		}

		protected void OnButtonAddNomenclatureClicked(object sender, EventArgs e)
		{
			ViewModel.AddNomenclature();
		}

		protected void OnButtonAddEmployeeClicked(object sender, EventArgs e)
		{
			ViewModel.AddEmployee();
		}

		protected void OnButtonRemoveEmployeeClicked(object sender, EventArgs e)
		{
			var items = tableEmployee.GetSelectedObjects<MassExpenseEmployee>();
			ViewModel.RemoveEmployee(items);
		}

		protected void OnButtonRemoveNomenclatureClicked(object sender, EventArgs e)
		{
			var items = tableNomenclature.GetSelectedObjects<MassExpenseNomenclature>();
			ViewModel.RemoveNomenclature(items);
		}

		protected void OnButtonCreateEmployeeClicked(object sender, EventArgs e)
		{
			ViewModel.AddNewEmployee();
		}

		private void IssuanceSheetSensetive()
		{
			buttonIssuanceSheetCreate.Sensitive = Entity.ListEmployees.Count > 0 && Entity.ItemsNomenclature.Count > 0;
			buttonIssuanceSheetCreate.Visible = Entity.IssuanceSheet == null;
			buttonIssuanceSheetOpen.Visible = enumPrint.Visible = Entity.IssuanceSheet != null;

		}

		protected void OnButtonIssuanceSheetCreateClicked(object sender, EventArgs e)
		{
			ViewModel.IssuanceSheetCreate();
			IssuanceSheetSensetive();
		}

		protected void OnButtonIssuanceSheetOpenClicked(object sender, EventArgs e)
		{
			ViewModel.IssuanceSheetOpen();
		}

		protected void OnEnumPrintEnumItemClicked(object sender, QSOrmProject.EnumItemClickedEventArgs e)
		{
			ViewModel.PrintIssuenceSheet((IssuedSheetPrint)e.ItemEnum);
		}
	}
}

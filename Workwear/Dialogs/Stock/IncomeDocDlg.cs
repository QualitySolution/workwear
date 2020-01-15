﻿using System;
using System.Linq;
using NLog;
using QS.Dialog.Gtk;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Validation.GtkUI;
using QSOrmProject;
using workwear.Domain.Company;
using workwear.Domain.Stock;
using workwear.Repository;

namespace workwear
{
	public partial class IncomeDocDlg : EntityDialogBase<Income>
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		public IncomeDocDlg()
		{
			this.Build();
			UoWGeneric = UnitOfWorkFactory.CreateWithNewRoot<Income> ();
			Entity.Date = DateTime.Today;
			Entity.CreatedbyUser = UserRepository.GetMyUser (UoW);
			ConfigureDlg ();
		}

		public IncomeDocDlg (EmployeeCard employee) : this () 
		{
			Entity.Operation = IncomeOperations.Return;
			Entity.EmployeeCard = employee;
		}

		public IncomeDocDlg (Subdivision facility) : this () 
		{
			Entity.Operation = IncomeOperations.Object;
			Entity.Subdivision = facility;
		}

		public IncomeDocDlg (Income item) : this (item.Id) {}

		public IncomeDocDlg (int id)
		{
			this.Build ();
			UoWGeneric = UnitOfWorkFactory.CreateForRoot<Income> (id);
			ConfigureDlg ();
		}

		private void ConfigureDlg()
		{
			ylabelId.Binding.AddBinding (Entity, e => e.Id, w => w.LabelProp, new IdToStringConverter()).InitializeFromSource ();

			ylabelCreatedBy.Binding.AddFuncBinding (Entity, e => e.CreatedbyUser.Name, w => w.LabelProp).InitializeFromSource ();

			ydateDoc.Binding.AddBinding (Entity, e => e.Date, w => w.Date).InitializeFromSource ();

			yentryNumber.Binding.AddBinding (Entity, e => e.Number, w => w.Text).InitializeFromSource ();

			ycomboOperation.ItemsEnum = typeof(IncomeOperations);
			ycomboOperation.Binding.AddBinding (Entity, e => e.Operation, w => w.SelectedItemOrNull).InitializeFromSource ();

			yentryEmployee.SubjectType = typeof(EmployeeCard);
			yentryEmployee.Binding.AddBinding (Entity, e => e.EmployeeCard, w => w.Subject).InitializeFromSource ();

			yentryObject.SubjectType = typeof(Subdivision);
			yentryObject.Binding.AddBinding (Entity, e => e.Subdivision, w => w.Subject).InitializeFromSource ();

			ytextComment.Binding.AddBinding(Entity, e => e.Comment, w => w.Buffer.Text).InitializeFromSource();

			ItemsTable.IncomeDoc = Entity;
		}			

		public override bool Save()
		{
			logger.Info ("Запись документа...");
			var valid = new QSValidator<Income> (UoWGeneric.Root);
			if (valid.RunDlgIfNotValid ((Gtk.Window)this.Toplevel))
				return false;

			Func<string, bool> ask = MessageDialogHelper.RunQuestionDialog;
			Entity.UpdateOperations(UoW, ask);
			UoWGeneric.Save ();
			if(Entity.Operation == IncomeOperations.Return)
			{
				logger.Debug ("Обновляем записи о выданной одежде в карточке сотрудника...");
				foreach(var itemsGroup in Entity.Items.GroupBy (i => i.Nomenclature.Type.Id))
				{
					var wearItem = Entity.EmployeeCard.WorkwearItems.FirstOrDefault (i => i.Item.Id == itemsGroup.Key);
					if(wearItem == null)
					{
						logger.Debug ("Позиции <{0}> не требуется к выдаче, пропускаем...", itemsGroup.First ().Nomenclature.Type.Name);
						continue;
					}

					wearItem.UpdateNextIssue (UoW);
				}
				UoWGeneric.Commit ();
			}

			logger.Info ("Ok");
			return true;
		}

		protected void OnYcomboOperationChanged (object sender, EventArgs e)
		{
			labelTTN.Visible = yentryNumber.Visible = Entity.Operation == IncomeOperations.Enter;
			labelWorker.Visible = yentryEmployee.Visible = Entity.Operation == IncomeOperations.Return;
			labelObject.Visible = yentryObject.Visible = Entity.Operation == IncomeOperations.Object;

			if (!UoWGeneric.IsNew)
				return;
			
			switch (Entity.Operation)
			{
			case IncomeOperations.Enter:
					TabName = "Новая приходная накладная";
				break;
			case IncomeOperations.Return:
					TabName = "Новый возврат от работника";
				break;
			case IncomeOperations.Object:
					TabName = "Новый возврат c объекта";
				break;
			}

		}
	}
}


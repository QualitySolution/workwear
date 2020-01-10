﻿using System;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using QS.Dialog;
using QS.DomainModel.Entity;
using QS.DomainModel.NotifyChange;
using QS.Testing.DB;
using workwear.Domain.Operations;
using workwear.Domain.Operations.Graph;
using workwear.Domain.Company;
using workwear.Domain.Regulations;
using workwear.Domain.Stock;
using workwear.Tools;

namespace WorkwearTest.Integration.Tools
{
	[TestFixture(TestOf = typeof(BuisnessLogicGlobalEventHandler))]
	[Category("Integrated")]
	public class BuisnessLogicGlobalEventHandlerTest : InMemoryDBGlobalConfigTestFixtureBase
	{
		[OneTimeSetUp]
		public void Init()
		{
			ConfigureOneTime.ConfigureNh();
			InitialiseUowFactory();
			NotifyConfiguration.Enable();
		}

		[SetUp]
		public void TestSetup()
		{
			NewSessionWithSameDB();
		}

		[TearDown]
		public void TestTearDown()
		{
			NewSessionWithNewDB();
		}

		[Test(Description = "Проверяем что после удаления пересчитываем даты и следующею выдачу")]
		public void HandleDeleteEmployeeVacation_RecalculateDatesAndNextIssueTest()
		{
			var ask = Substitute.For<IInteractiveQuestion>();
			ask.Question(string.Empty).ReturnsForAnyArgs(true);

			using(var uow = UnitOfWorkFactory.CreateWithoutRoot("Тест на обработку события удаления")) {
				BuisnessLogicGlobalEventHandler.Init(ask, UnitOfWorkFactory);

				var nomenclatureType = new ItemsType();
				nomenclatureType.Name = "Тестовый тип номенклатуры";
				uow.Save(nomenclatureType);

				var nomenclature = new Nomenclature();
				nomenclature.Type = nomenclatureType;
				uow.Save(nomenclature);

				var norm = new Norm();
				var normItem = norm.AddItem(nomenclatureType);
				normItem.Amount = 1;
				normItem.NormPeriod = NormPeriodType.Month;
				normItem.PeriodCount = 2;
				uow.Save(norm);

				var employee = new EmployeeCard();

				var vacationType = new VacationType();
				vacationType.Name = "Тестовый отпуск";
				vacationType.ExcludeFromWearing = true;

				var vacation = new EmployeeVacation();
				vacation.BeginDate = new DateTime(2019, 2, 1);
				vacation.EndDate = new DateTime(2019, 3, 1);
				vacation.VacationType = vacationType;
				employee.AddVacation(vacation);
				uow.Save(vacationType);
				uow.Save(vacation);
				uow.Save(employee);

				var expenseOp = new EmployeeIssueOperation();
				expenseOp.OperationTime = new DateTime(2019, 1, 1);
				expenseOp.ExpiryByNorm = new DateTime(2019, 4, 1);
				expenseOp.Employee = employee;
				expenseOp.Nomenclature = nomenclature;
				expenseOp.NormItem = normItem;
				expenseOp.Issued = 1;
				uow.Save(nomenclature);
				uow.Save(normItem);
				uow.Save(expenseOp);
				uow.Commit();

				//Выполняем удаление
				employee.Vacations.Remove(vacation);
				uow.Delete(vacation);
				uow.Commit();

				//проверяем данные
				using(var uow2 = UnitOfWorkFactory.CreateWithoutRoot("Тест на обработку события удаления uow2")) {
					var resultOp = uow2.GetById<EmployeeIssueOperation>(expenseOp.Id);
					Assert.That(resultOp.ExpiryByNorm, Is.EqualTo(new DateTime(2019, 3, 1)));
				}

			}
		}

		[Test(Description = "Проверяем что после удаления пересчитываем правильно даты с двумя одинаковыми выдачами за день, расположенными в неправильном порядке.")]
		[Category("Real case")]
		public void HandleDeleteEmployeeVacation_RecalculateWithTwoIssuePerDayTest()
		{
			var ask = Substitute.For<IInteractiveQuestion>();
			ask.Question(string.Empty).ReturnsForAnyArgs(true);

			using(var uow = UnitOfWorkFactory.CreateWithoutRoot("Тест на обработку события удаления")) {
				BuisnessLogicGlobalEventHandler.Init(ask, UnitOfWorkFactory);

				var nomenclatureType = new ItemsType();
				nomenclatureType.Name = "Тестовый тип номенклатуры";
				uow.Save(nomenclatureType);

				var nomenclature = new Nomenclature();
				nomenclature.Type = nomenclatureType;
				uow.Save(nomenclature);

				var norm = new Norm();
				var normItem = norm.AddItem(nomenclatureType);
				normItem.Amount = 1;
				normItem.NormPeriod = NormPeriodType.Year;
				normItem.PeriodCount = 1;
				uow.Save(norm);

				var employee = new EmployeeCard();
				employee.AddUsedNorm(norm);

				var vacationType = new VacationType();
				vacationType.Name = "Тестовый отпуск";
				vacationType.ExcludeFromWearing = true;

				var vacation = new EmployeeVacation();
				vacation.BeginDate = new DateTime(2019, 2, 1);
				vacation.EndDate = new DateTime(2019, 2, 10);
				vacation.VacationType = vacationType;
				employee.AddVacation(vacation);
				uow.Save(vacationType);
				uow.Save(vacation);
				uow.Save(employee);
				uow.Commit();

				var expenseOp = new EmployeeIssueOperation();
				expenseOp.OperationTime = new DateTime(2019, 1, 1, 14, 0, 0);
				expenseOp.AutoWriteoffDate = new DateTime(2020, 1, 1);
				expenseOp.Employee = employee;
				expenseOp.Nomenclature = nomenclature;
				expenseOp.NormItem = normItem;
				expenseOp.Issued = 1;
				var graph = IssueGraph.MakeIssueGraph(uow, employee, nomenclatureType);
				expenseOp.RecalculateDatesOfIssueOperation(graph, ask);
				uow.Save(expenseOp);

				var expenseOp2 = new EmployeeIssueOperation();
				expenseOp2.OperationTime = new DateTime(2019, 1, 1, 13, 0, 0);
				expenseOp2.AutoWriteoffDate = new DateTime(2020, 1, 1);
				expenseOp2.Employee = employee;
				expenseOp2.Nomenclature = nomenclature;
				expenseOp2.NormItem = normItem;
				expenseOp2.Issued = 1;
				graph = IssueGraph.MakeIssueGraph(uow, employee, nomenclatureType);
				expenseOp2.RecalculateDatesOfIssueOperation(graph, ask);
				uow.Save(expenseOp2);

				vacation.UpdateRelatedOperations(uow, ask);
				uow.Commit();

				Assert.That(employee.WorkwearItems[0].NextIssue, Is.EqualTo(new DateTime(2021, 1, 11)));

				//Выполняем удаление
				employee.Vacations.Remove(vacation);
				uow.Delete(vacation);
				uow.Commit();

				//проверяем данные
				using(var uow2 = UnitOfWorkFactory.CreateWithoutRoot("Тест на обработку события удаления uow2")) {
					var resultEmployee = uow2.GetById<EmployeeCard>(employee.Id);
					Assert.That(resultEmployee.WorkwearItems[0].NextIssue, Is.EqualTo(new DateTime(2021, 1, 1)));
				}

			}
		}

		[Test(Description = "Корректно удаляем строку из документа выдачи сотруднику. Реальный баг.")]
		[Category("real case")]
		[Category("Integrated")]
		public void UpdateOperations_DeleteRowTest()
		{
			var ask = Substitute.For<IInteractiveQuestion>();
			ask.Question(string.Empty).ReturnsForAnyArgs(true);

			using(var uow = UnitOfWorkFactory.CreateWithoutRoot()) {
				BuisnessLogicGlobalEventHandler.Init(ask, UnitOfWorkFactory);

				var nomenclatureType = new ItemsType();
				nomenclatureType.Name = "Тестовый тип номенклатуры";
				uow.Save(nomenclatureType);

				var nomenclature = new Nomenclature();
				nomenclature.Type = nomenclatureType;
				uow.Save(nomenclature);

				var nomenclatureType2 = new ItemsType();
				nomenclatureType2.Name = "Тестовый тип номенклатуры2";
				uow.Save(nomenclatureType2);

				var nomenclature2 = new Nomenclature();
				nomenclature2.Type = nomenclatureType2;
				uow.Save(nomenclature2);

				var norm = new Norm();
				var normItem = norm.AddItem(nomenclatureType);
				normItem.Amount = 1;
				normItem.NormPeriod = NormPeriodType.Year;
				normItem.PeriodCount = 1;
				var normItem2 = norm.AddItem(nomenclatureType2);
				normItem2.Amount = 1;
				normItem2.NormPeriod = NormPeriodType.Month;
				normItem2.PeriodCount = 4;
				uow.Save(norm);

				var employee = new EmployeeCard();
				employee.HireDate = new DateTime(2018, 1, 15);
				employee.AddUsedNorm(norm);
				uow.Save(employee);
				uow.Commit();

				var income = new Income();
				income.Date = new DateTime(2017, 1, 1);
				income.Operation = IncomeOperations.Enter;
				var incomeItem1 = income.AddItem(nomenclature);
				incomeItem1.Amount = 10;
				var incomeItem2 = income.AddItem(nomenclature2);
				incomeItem2.Amount = 10;
				income.UpdateOperations(uow, s => true);
				uow.Save(income);

				var expense = new Expense();
				expense.Employee = employee;
				expense.Date = new DateTime(2018, 4, 22);
				expense.Operation = ExpenseOperations.Employee;
				expense.AddItem(incomeItem1, 1);
				expense.AddItem(incomeItem2, 1);

				//Обновление операций
				expense.UpdateOperations(uow, ask);
				uow.Save(expense);
				expense.UpdateEmployeeNextIssue();
				employee.WorkwearItems.First(e => e.Item.IsSame(nomenclatureType2)).Created = new DateTime(2018, 4, 22);
				uow.Save(expense.Employee);
				uow.Commit();

				Assert.That(employee.WorkwearItems.First(e => e.Item.IsSame(nomenclatureType2)).NextIssue,
					Is.EqualTo(new DateTime(2018, 8, 22))
				);

				//Выполняем удаление
				expense.RemoveItem(expense.Items.First(e => e.Nomenclature.Type.IsSame(nomenclatureType2)));
				uow.Save(expense);
				uow.Commit();

				//проверяем данные
				using(var uow2 = UnitOfWorkFactory.CreateWithoutRoot("Тест на обработку события удаления uow2")) {
					var resultEmployee = uow2.GetById<EmployeeCard>(employee.Id);
					Assert.That(resultEmployee.WorkwearItems.First(e => e.Item.IsSame(nomenclatureType2)).NextIssue, 
					Is.EqualTo(new DateTime(2018, 4, 22)));
				}
			}
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using QS.DomainModel.UoW;
using workwear.Domain.Organization;
using workwear.Domain.Regulations;
using workwear.Repository.Stock;

namespace workwear.Domain.Operations.Graph
{
	public class IssueGraph
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public List<GraphInterval> Intervals = new List<GraphInterval>();

		public IssueGraph()
		{

		}

		public IEnumerable<GraphInterval> OrderedIntervals => Intervals.OrderBy(x => x.StartDate);

		public IEnumerable<GraphInterval> OrderedIntervalsReverse => Intervals.OrderByDescending(x => x.StartDate);

		public IssueGraph(IList<EmployeeIssueOperation> issues)
		{
			//создаем интервалы.
			List<DateTime> starts = issues.Select(x => x.OperationTime).ToList();
			starts.AddRange(issues.Where(x => x.AutoWriteoffDate.HasValue).Select(x => x.AutoWriteoffDate.Value));
			starts = starts.Distinct().OrderBy(x => x.Ticks).ToList();

			var graphItems = issues.Where(x => x.Issued > 0).Select(x => new GraphItem(x)).ToList();
			foreach (var issue in issues.Where(x => x.Returned > 0))
			{
				if (issue.IssuedOperation == null)
				{
					logger.Error($"{typeof(EmployeeIssueOperation).Name}:{issue.Id} списывает спецодежду с сотрудника при этом не имеет ссылки на операцию по которой эта одежда была выдана сотруднику. Операция была пропущена в построение графа выдачи.");
					continue;
				}

				var item = graphItems.FirstOrDefault(x => x.IssueOperation.Id == issue.IssuedOperation.Id);
				if (item == null)
				{
					logger.Error($"{typeof(EmployeeIssueOperation).Name}:{issue.Id} ссылается на некоректную операцию выдачи. Операция была пропущена в построение графа выдачи.");
					continue;
				}
				item.WriteOffOperations.Add(issue);
			}

			foreach (var date in starts)
			{
				var interval = new GraphInterval();
				interval.StartDate = date;
				foreach (var item in graphItems.Where(x => x.IssueOperation.OperationTime <= date))
				{
					if (item.AmountAtBeginOfDay(date) <= 0)
						continue;
					interval.ActiveItems.Add(item);
					interval.CurrentCount += item.AmountAtEndOfDay(date);
				}
				Intervals.Add(interval);
			}
		}

		#region Методы

		public int AmountAtBeginOfDay(DateTime date, EmployeeIssueOperation excludeOperation = null)
		{
			var interval = IntervalOfDate(date);
			if (interval == null)
				return 0;
			return interval.ActiveItems.Sum(x => x.AmountAtBeginOfDay(date, excludeOperation));
		}

		public int AmountAtEndOfDay(DateTime date, EmployeeIssueOperation excludeOperation = null)
		{
			var interval = IntervalOfDate(date);
			if (interval == null)
				return 0;
			return interval.ActiveItems.Sum(x => x.AmountAtEndOfDay(date, excludeOperation));
		}

		public GraphInterval IntervalOfDate(DateTime date)
		{
			return Intervals.Where(x => x.StartDate <= date.Date).OrderByDescending(x => x.StartDate).Take(1).SingleOrDefault();
		}

		#endregion

		#region Статические

		public static IssueGraph MakeIssueGraph(IUnitOfWork uow, EmployeeCard employee, ItemsType itemsType)
		{
			var nomenclatures = NomenclatureRepository.GetNomenclaturesOfType(uow, itemsType);

			var issues = uow.Session.QueryOver<EmployeeIssueOperation>()
					.Where(x => x.Employee.Id == employee.Id)
					.Where(x => x.Nomenclature.Id.IsIn(nomenclatures.Select(n => n.Id).ToArray()))
					.OrderBy(x => x.OperationTime).Asc
					.List();

			return new IssueGraph(issues);
		}

		#endregion
	}
}

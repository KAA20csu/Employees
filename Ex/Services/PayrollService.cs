using System;
using System.Collections.Generic;
using System.Linq;
using Ex.Data;

namespace Ex.Services
{
	internal class PayrollService
	{
		public static void GetSalaries()
		{
			// создадим экземляр класса для ананимных типов
			var groupOfEmployees = FileData.Persons.GroupBy(e => e.Work.workName,
				(key, g) => new { Key = key, Value = g.Where(g => g.IsHead == false) });

			foreach (var employee in groupOfEmployees)
			{
				var salary = employee.Value.Average(f => f.Salary);
				Console.WriteLine($"Средняя зарплата по {employee.Key}: " + salary);
			}
		}

		public static void GetTheRichestHead()
		{
			var groupOfHeads = FileData.Persons.GroupBy(e => e.Work.workName,
				(key, g) => new { Key = key, Value = g.Where(g => g.IsHead) });

			var headSalaries = new List<double>();

			foreach (var head in groupOfHeads)
			{
				headSalaries.Add(head.Value.Max(f => f.Salary));
			}

			var richest = headSalaries.Max();
			Console.WriteLine("Cамая высокая зарплата руководителя: " + richest);
		}

		public static void GetWorkPlaceInfo()
		{
			var groupOfemployees = FileData.Persons.GroupBy(e => e.Work.workName,
					(key, g) =>
						new { Key = key, Value = g.Count(f => f.IsHead) })
				.OrderBy(c => c.Key);

			foreach (var employee in groupOfemployees)
			{
				if (employee.Value < 1 || employee.Value > 2)
				{
					throw new Exception("Ошибка!");
				}
			}

			Salaries.GetSalaries();
			Salaries.GetTheRichestHead();
		}
	}
}
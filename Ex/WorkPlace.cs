using System;
using System.Linq;

namespace Ex
{
	internal class WorkPlace
	{
		public WorkPlace(string work)
		{
			workName = work;
		}

		public string workName { get; }

		public static void GetWorkPlaceInfo()
		{
			var groupOfemployees = DataReader.person.GroupBy(e => e.Work.workName,
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
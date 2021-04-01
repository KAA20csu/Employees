using System.Collections.Generic;
using System.Linq;
using Ex.Data;
using Ex.Models;

namespace Ex.Services
{
	internal class PayrollService
	{
		public IList<PersonSalary> GetAverageSalaries()
		{
			return FileData.Persons.GroupBy(e => e.Work.WorkName,
					(key, g) => new { WorkName = key, Persons = g.Where(g => g.IsHead == false) })
				.Select(g => new PersonSalary { WorkName = g.WorkName, Salary = g.Persons.Average(p => p.Salary) })
				.ToList();
		}

		public double GetTheRichestHead()
		{
			return FileData.Persons.GroupBy(e => e.Work.WorkName,
					(key, g) => new { Key = key, Value = g.Where(g => g.IsHead) })
				.Select(head => head.Value.Max(f => f.Salary))
				.Select(dummy => (double) dummy)
				.Max();
		}
	}
}
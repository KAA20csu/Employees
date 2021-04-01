using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex.Validations
{
	internal class FileDataValidation
	{
		public static void Validate(IList<Person> persons)
		{
			// можно вот так
			if (persons.GroupBy(person => person.Work)
				.Select(workGroup => workGroup.Count(v => v.IsHead))
				.Any(heads => heads < 1 || heads > 2))
			{
				throw new Exception("Ошибка!");
			}
		}
	}
}
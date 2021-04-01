using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex.Validations
{
	/// <summary>
	/// Класс валидатор
	/// </summary>
	internal class FileDataValidation
	{
		/// <summary>
		/// Валидация данных из файла
		/// </summary>
		/// <param name="persons"></param>
		public static void Validate(IList<Person> persons)
		{
			foreach (var workGroup in persons.GroupBy(person => person.Work.WorkName))
			{
				var heads = workGroup.Count(v => v.IsHead);

				if (heads < 1 || heads > 2)
				{
					throw new Exception("Ошибка!");
				}
			}
		}
	}
}
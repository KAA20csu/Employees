using System.Collections.Generic;
using System.IO;

namespace Ex
{
	internal class DataReader
	{
		/// <summary>
		/// здесь должно было быть { get; } свойство, но не поле. поля даолжны быть
		/// закрытыми, и, принято именовать их так => _persons. Т.е. приватное поле с _
		/// вначале. Свойства же, именуют с большой буквы, Persons. На конце s -
		/// множественное число (коллекция)
		/// </summary>
		public static List<Person> person = new List<Person>();

		public static string[] information { get; } = File.ReadAllLines("tsk.txt");

		public static void GetPerson()
		{
			foreach (var employee in information)
			{
				person.Add(new Person(employee.Split(';'), new WorkPlace(employee.Split(';')[1])));
			}
		}
	}
}
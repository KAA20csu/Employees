using System.Collections.Generic;
using System.IO;

namespace Ex
{
	/// <summary>
	/// Сам же класс DataReader выполняет сервисную функцию, т.к. он должен только
	/// читать фаил, в данном случае, но не как че хранить в себе данные
	/// </summary>
	internal class DataReader
	{
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
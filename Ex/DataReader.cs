using System.Collections.Generic;
using System.IO;

namespace Ex
{
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
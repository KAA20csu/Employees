using System.Collections.Generic;
using System.IO;

namespace Ex
{
	internal class DataReader
	{
		public static List<Person> Persons { get; }  = new List<Person>();

		public static string[] Informations { get; } = File.ReadAllLines("tsk.txt");

		public static void GetPerson()
		{
			foreach (var employee in Informations)
			{
				Persons.Add(new Person(employee.Split(';'), new WorkPlace(employee.Split(';')[1])));
			}
		}
	}
}
using System.Collections.Generic;
using System.IO;

namespace Ex
{
	/// <summary>
	/// Уходим от статики
	/// </summary>
	internal class DataReader
	{
		public static List<Person> Persons { get; }  = new List<Person>();

		/// <summary>
		/// Всё это можно сделать в методе, и не хранить вечно в статическом свойсте
		/// </summary>
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
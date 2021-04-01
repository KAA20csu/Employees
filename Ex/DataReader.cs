using System.Collections.Generic;
using System.IO;

namespace Ex
{
	internal class DataReader
	{
		public static List<Person> person = new List<Person>();

		/// <summary>
		/// В данном случае (да и чаще всего) статический класс это плохо. Скажем так, в
		/// будущем возникнут проблемы с потокобезопасностью, а так же, данная коллекция
		/// хранится на протяжении всего времени выполнения приложения. Но зачем,
		/// используется только раз
		/// </summary>
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
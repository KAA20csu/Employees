using System;

namespace Ex
{
	internal class Person
	{
		public Person(string[] inforamtion, WorkPlace work)
		{
			Name = inforamtion[0];
			Work = work;
			Salary = int.Parse(inforamtion[2]);

			if (inforamtion.Length == 4)
			{
				IsHead = Convert.ToBoolean(inforamtion[3]);
			} else
			{
				IsHead = false;
			}
		}

		public string Name { get; }

		public WorkPlace Work { get; }

		public int Salary { get; }

		public bool IsHead { get; }
	}
}
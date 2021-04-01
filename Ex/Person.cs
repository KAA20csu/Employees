namespace Ex
{
	internal class Person
	{
		public Person(string name, int salary, bool isHead, WorkPlace work)
		{
			Name = name;
			Salary = salary;
			IsHead = isHead;
			Work = work;
		}

		public string Name { get; }

		public WorkPlace Work { get; }

		public int Salary { get; }

		public bool IsHead { get; }
	}
}
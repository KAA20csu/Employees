using System.Collections.Generic;

namespace Ex.Data
{
	internal class FileData
	{
		private readonly DataReader _dataReader;

		public FileData()
		{
			_dataReader = new DataReader();
		}

		public static IList<Person> Persons { get; private set; }

		public void Initialize()
		{
			var information = _dataReader.GetFileData();

			foreach (var line in information)
			{
				var data = line.Split(";");

				Persons.Add(new Person(data, new WorkPlace(data[1])));
			}
		}
	}
}
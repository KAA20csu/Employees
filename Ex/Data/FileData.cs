using System.Collections.Generic;

namespace Ex.Data
{
	/// <summary>
	/// По хорошему, можно реализовать синглтон, раз хранилище одно(статическая Persons). 
	/// </summary>
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
				// каждый раз вот так сплитить в FileData не надо, это должен был делать DataReader
				var data = line.Split(";");

				Persons.Add(new Person(data, new WorkPlace(data[1])));
			}
		}
	}
}
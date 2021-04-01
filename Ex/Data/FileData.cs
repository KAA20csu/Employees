using System.Collections.Generic;
using System.Linq;
using Ex.Validations;

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

			Persons = information.Select(data =>
					new Person(data[0], int.Parse(data[2]), data.Length == 4 && bool.Parse(data[3]), new WorkPlace(data[1])))
				.ToList();

			FileDataValidation.Validate(Persons);
		}
	}
}
using System.IO;

namespace Ex
{
	/// <summary>
	/// Пока так, т.к. задача DataReader только прочитать
	/// </summary>
	internal class DataReader
	{
		public string[] GetPerson()
		{
			var information = File.ReadAllLines("tsk.txt");

			return information;
		}
	}
}
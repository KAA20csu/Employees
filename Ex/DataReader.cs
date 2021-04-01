using System.IO;

namespace Ex
{
	internal class DataReader
	{
		public string[] GetPerson()
		{
			var information = File.ReadAllLines("tsk.txt");

			return information;
		}
	}
}
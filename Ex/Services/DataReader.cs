using System.IO;

namespace Ex
{
	internal class DataReader
	{
		private const string FILE_NAME = "tsk.txt";

		public string[] GetFileData()
		{
			var information = File.ReadAllLines(FILE_NAME);

			return information;
		}
	}
}
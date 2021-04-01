using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ex
{
	internal class DataReader
	{
		private const string FileName = "tsk.txt";

		public IList<string[]> GetFileData()
		{
			var information = new List<string[]>();

			using var fileStream = File.OpenRead(FileName);
			using var streamReader = new StreamReader(fileStream, Encoding.UTF8);

			string line;

			while ((line = streamReader.ReadLine()) != null)
			{
				information.Add(line.Split(";"));
			}

			return information;
		}
	}
}
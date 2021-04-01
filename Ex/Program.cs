using System;
using Ex.Data;
using Ex.Services;

namespace Ex
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// инициализация наших данных
			var fileData = new FileData();
			fileData.Initialize();

			// инициализация сервиса запросов
			var payrollService = new PayrollService();

			// получаем средние зарплаты
			var workPlaceAverageSalaries = payrollService.GetAverageSalaries();
			foreach (var workPlace in workPlaceAverageSalaries)
			{
				Console.WriteLine($"Средняя зарплата по {workPlace.WorkName}: {workPlace.Salary}");
			}

			// получаем самую большую зарплату
			var maxSalary = payrollService.GetTheRichestHead();
			Console.WriteLine($"Cамая высокая зарплата руководителя: {maxSalary}");

			Console.ReadKey(false);
		}
	}
}
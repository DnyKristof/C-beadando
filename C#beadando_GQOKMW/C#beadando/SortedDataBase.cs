using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_beadando
{
	internal class SortedDataBase
	{
		private SortedDictionary<int, string> dataBase = new SortedDictionary<int, string>();
		public SortedDictionary<int, string> db { get; }

		public SortedDataBase() { }

		public void listDB()
		{
			foreach (var item in dataBase.Keys.Zip(dataBase.Values, (a, b) => new { a = a, b = b }))
			{
				Console.WriteLine("{0} : {1}", item.a, item.b);


			}

		}

		public static IEnumerable<string> addValues(int number)
		{

			Console.WriteLine("Kérlek add meg az értékeket: ");
			for (int i = 1; i < number +1; i++)
			{
                Console.Write("{0}. érték :",i);
                string input = Console.ReadLine();

				yield return input;   // yield return használva
			}
		}

		public static IEnumerable<int> numberUpTo(int number)
		{
			for (int i = 0; i < number; i++)
			{
				yield return i;
			}
		}

		public void actAsDatabase(int recordnum)
		{
			foreach (var item in numberUpTo(recordnum).Zip(addValues(recordnum), (a, b) => new { a = a, b = b }))
			{
				dataBase.Add(item.a, item.b);
			}

		}
	}
}

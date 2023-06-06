using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_beadando
{
	internal class SortedDictMagic
	{
		private SortedDictionary<string, string> magicDict = new SortedDictionary<string, string>();



		public SortedDictMagic() { }

		public SortedDictionary<string, string> magic { get; }



		public SortedDictMagic(string[] keys, string[] values)
		{

			foreach (var item in keys.Zip(values, (a, b) => new { a = a, b = b }))
			{
				magicDict.Add(item.a, item.b);    //1. metódus : Add
			}

		}

		public void Add(string key, string value)
		{
			magicDict.Add(key, value);
		}

		public void checkIfInDict(string key, string value)
		{
			if (!magicDict.ContainsKey(key) || !magicDict.ContainsValue(value))
			{
				Console.WriteLine("Ez a páros még nem szerepel a szótárban");  //2. metódus : ContainsKey , 3. metódus ContainsValue
				return;
			}
			foreach (var item in magicDict.Values.Zip(magicDict.Keys, (a, b) => new { a = a, b = b }))
			{
				if (item.a.Equals(value) && item.b.Equals(key))
				{
					Console.WriteLine("Ez a páros már szerepel a szótárban");
					return;
				}
			}
			Console.WriteLine("Ez a páros még nem szerepel a szótárban");
		}


		public void listDict()
		{
			foreach (var item in magicDict.Keys.Zip(magicDict.Values, (a, b) => new { a = a, b = b }))
			{
				Console.WriteLine("{0} : {1}", item.a, item.b);


			}

		}

		public void removeKeyByLength(int length)
		{
			foreach (var item in magicDict.Keys)
			{
				if (item.Length == length)
				{
					magicDict.Remove(item);  //4. metódus : Remove
				}
			}
		}

		public void clearIfBadWord(string[] badwords)
		{
			foreach (var item in badwords)
			{
				if (magicDict.ContainsKey(item) || magicDict.ContainsValue(item))
				{
					magicDict.Clear(); // 5. metódus : Clear
                    Console.WriteLine("Nem rosszalkodni!");
					return;
                }
			}
            Console.WriteLine("Helyes!");
        }


	}
}

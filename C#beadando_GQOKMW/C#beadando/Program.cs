using System;
using System.IO;
using System.Collections.Generic;
using C_beadando;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using System.Collections;

public class Csharp
{
	static public void Main()
	{
		string[] badwords = { "búbánat", "fene", "teringettét", "fránya", "kiskésit", "guta"};

		string[] keys = { "hill", "weight", "unrest", "habit", "interactive", "negotiation", "estimate", "flat", "wheat", "report", "radiation", "consumption", "frank", "reporter", "blame", "soul", "define", "king", "page", "humanity" };
		string[] values = { "The", "pet", "shop", "stocks", "everything", "you ", "need", "to", "keep", "your", "anaconda", "happy", "The","gloves","protect","my","feet","from","excess","work" };

		SortedDictMagic teliDict = new SortedDictMagic(keys,values);

        Console.WriteLine("A teli szótár:");
		teliDict.listDict();

        Console.WriteLine("\nSzerepel-e a szótárban a {0} : {1} páros?", keys[0], values[0]);

		teliDict.checkIfInDict(keys[0], values[0]);

		Console.WriteLine("\nSzerepel-e a szótárban a {0} : {1} páros?", keys[12], values[9]);

		teliDict.checkIfInDict(keys[12], values[9]);

        Console.WriteLine("\nVajon van rossz szó a szótárban?");

		teliDict.clearIfBadWord(badwords);

        Console.WriteLine("\nDe ha lenne működne?");

        teliDict.Add("búbánat", "teringettét");
		teliDict.clearIfBadWord(badwords);
		teliDict.listDict();

		Console.WriteLine("\nÉs most szimulálunk egy mini adatbázist.");

		SortedDataBase db = new SortedDataBase();

		db.actAsDatabase(3);

		db.listDB();





	}
}
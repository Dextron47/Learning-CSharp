using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
	class MadLib
	{
		public static void Run(){

			string color, pluralNoun, celebrity;
			Console.WriteLine("Enter a color:");
			color = Console.ReadLine();
			Console.WriteLine("Enter a plural noun:");
			pluralNoun = Console.ReadLine();
			Console.WriteLine("Enter a celebrity:");
			celebrity = Console.ReadLine();

			Console.WriteLine("Roses are " + color);
			Console.WriteLine(pluralNoun + " are blue");
			Console.WriteLine("I love " + celebrity);
		}
	}
}

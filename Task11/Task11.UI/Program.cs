using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task11.ClassHierarchy.Clients;
using Task11.ClassHierarchy.Factories;

namespace Task11.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			var vegetables = new Factory1();
			var fruits = new Factory2();

			var clientA = new Client(vegetables);
			var clientB = new Client(fruits);

			Console.WriteLine(clientA.ImportProduct());
			Console.WriteLine(clientA.ExportProduct());

			Console.WriteLine(new string('-',30));
			
			Console.WriteLine(clientB.ImportProduct());
			Console.WriteLine(clientB.ExportProduct());

			Console.ReadKey();
		}
	}
}

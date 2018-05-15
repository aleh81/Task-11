using System;
using Task11.ClassHierarchy.Clients;
using Task11.ClassHierarchy.Factories;

namespace Task11.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			#region ClassHierarchyTest

			ClassHierarchyTest();

			#endregion

			Console.ReadKey();
		}

		private static void ClassHierarchyTest()
		{
			var vegetables = new Factory1();
			var fruits = new Factory2();

			var clientA = new Client<Factory1>();
			var clientB = new Client<Factory2>();

			Console.WriteLine(clientA.ImportProduct());
			Console.WriteLine(clientA.ExportProduct());

			Console.WriteLine(new string('-', 30));

			Console.WriteLine(clientB.ImportProduct());
			Console.WriteLine(clientB.ExportProduct());
		} 
	}
}

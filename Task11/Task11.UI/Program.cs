using System;
using Task11.BLL.Models;
using Task11.BLL.Services;
using Task11.ClassHierarchy.Clients;
using Task11.ClassHierarchy.Factories;

namespace Task11.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ClassHierarchyTest

            //ClassHierarchyTest();

            #endregion

            //var binaryTree = new BinaryTree<TestResult>(2);
           
            //binaryTree.Add(new TestResult { TestName = "Тест на вич", StudentName = "Губа", DatePassing = DateTime.Now, Score = 5 });
            //binaryTree.Add(new TestResult { StudentName = "Сидоров", TestName = "Тест 2", DatePassing = DateTime.Now, Score = 10 });

            //foreach(TestResult item in binaryTree)
            //{
            //    Console.WriteLine(item.StudentName);
            //}
    

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

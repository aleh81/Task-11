using Task11.ClassHierarchy.Enum;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Products
{
	public class ProductA1 : IProductA
	{
		private const Fruits Fruit = Fruits.Apples;

		public string Export()
		{
			return $"Product {Fruit} exported";
		}
	}
}

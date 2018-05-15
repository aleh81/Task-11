using Task11.ClassHierarchy.Enum;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Products
{
	public class ProductB1 : IProductB
	{
		private const Fruits Fruit = Fruits.Bananas;

		public string Import()
		{
			return $"Product {Fruit} imported";
		}
	}
}

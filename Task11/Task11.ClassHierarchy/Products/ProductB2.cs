using Task11.ClassHierarchy.Enum;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Products
{
	public class ProductB2 : IProductB
	{
		private const Vegetables Vegetable = Vegetables.Cabbage;

		public string Import()
		{
			return $"Product {Vegetable} imported";
		}
	}
}

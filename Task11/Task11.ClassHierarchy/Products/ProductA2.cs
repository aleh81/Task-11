using Task11.ClassHierarchy.Enum;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Products
{
	public class ProductA2 : IProductA
	{
		private const Vegetables Vegetable = Vegetables.Potato;
		public string Export()
		{
			return $"Product {Vegetable} exported";
		}
	}
}

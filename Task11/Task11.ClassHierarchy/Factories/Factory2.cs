using Task11.ClassHierarchy.Factories.Interfaces;
using Task11.ClassHierarchy.Products;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Factories
{
	public class Factory2 : IFactory
	{
		public IProductA CreateVegetables()
		{
			return new ProductA2();
		}

		public IProductB CreateFruits()
		{
			return new ProductB2();
		}
	}
}
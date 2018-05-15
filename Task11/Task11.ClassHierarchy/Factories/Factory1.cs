using Task11.ClassHierarchy.Factories.Interfaces;
using Task11.ClassHierarchy.Products;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Factories
{
	public class Factory1 : IFactory
	{
		public IProductA CreateVegetables()
		{
			return new ProductA1();
		}

		public IProductB CreateFruits()
		{
			return new ProductB1();
		}
	}
}

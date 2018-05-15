using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Factories.Interfaces
{
	public interface IFactory
	{
		IProductA CreateVegetables();
		IProductB CreateFruits();
	}
}

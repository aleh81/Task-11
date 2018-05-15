using Task11.ClassHierarchy.Factories.Interfaces;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Clients
{
	public class Client
	{
		public IFactory Factory { get; }

		private readonly IProductA _productA;

		private readonly IProductB _productB;

		public Client(IFactory factory)
		{
			Factory = factory;

			_productA = factory.CreateVegetables();
			_productB = factory.CreateFruits();
		}

		public string ExportProduct()
		{
			return _productA.Export();
		}

		public string ImportProduct()
		{
			return _productB.Import();;
		}
	}
}

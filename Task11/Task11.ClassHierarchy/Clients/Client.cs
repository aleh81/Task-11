using Task11.ClassHierarchy.Factories.Interfaces;
using Task11.ClassHierarchy.Products.Interfaces;

namespace Task11.ClassHierarchy.Clients
{
	public class Client<T> : IClient where T : IFactory, new()
	{
		public T Factory { get; }

		private readonly IProductA _productA;

		private readonly IProductB _productB;

		public Client()
		{
			Factory = new T();

			_productA = Factory.CreateVegetables();
			_productB = Factory.CreateFruits();
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

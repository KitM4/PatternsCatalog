using PatternsCatalog.CreationalPatterns.AbstractFactory.Interfaces;

namespace PatternsCatalog.CreationalPatterns.AbstractFactory;

public class AbstractFactoryExecutor<TFactory, TProduct>(TFactory factory) where TFactory : IAbstractFactory<TProduct> where TProduct : IProduct
{
    private readonly TFactory _factory = factory;

    public string Execute()
    {
        TProduct product = _factory.CreateProduct();
        return product.Display();
    }
}
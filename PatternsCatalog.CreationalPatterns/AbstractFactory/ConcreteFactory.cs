using PatternsCatalog.CreationalPatterns.AbstractFactory.Interfaces;

namespace PatternsCatalog.CreationalPatterns.AbstractFactory;

public class ConcreteFactory(string productName) : IAbstractFactory<ConcreteProduct>
{
    private readonly string _productName = productName;

    public ConcreteProduct CreateProduct() =>
        new(_productName);
}
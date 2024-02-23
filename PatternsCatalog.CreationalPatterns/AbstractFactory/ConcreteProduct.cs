using PatternsCatalog.CreationalPatterns.AbstractFactory.Interfaces;

namespace PatternsCatalog.CreationalPatterns.AbstractFactory;

public class ConcreteProduct(string name) : IProduct
{
    private readonly string _name = name;

    public string Display() =>
        $"Product name: {_name}";
}
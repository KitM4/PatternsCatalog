using PatternsCatalog.CreationalPatterns.Builder.Interfaces;

namespace PatternsCatalog.CreationalPatterns.Builder;

public class ConcreteBuilder<T> : IBuilder<T>
{
    private Product<T> _product = new();

    public void Reset() =>
        _product = new();

    public void BuildPart(T item) =>
        _product.Add(item);

    public Product<T> GetProduct()
    {
        Product<T> result = _product;

        Reset();

        return result;
    }
}
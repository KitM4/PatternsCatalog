namespace PatternsCatalog.CreationalPatterns.AbstractFactory.Interfaces;

public interface IAbstractFactory<T> where T : IProduct
{
    public T CreateProduct();
}
using PatternsCatalog.CreationalPatterns.Builder.Interfaces;

namespace PatternsCatalog.CreationalPatterns.Builder;

public class Director<T>(IBuilder<T> builder)
{
    private readonly IBuilder<T> _builder = builder;

    public void BuildProduct(params T[] items)
    {
        foreach (T item in items)
            _builder.BuildPart(item);
    }
}
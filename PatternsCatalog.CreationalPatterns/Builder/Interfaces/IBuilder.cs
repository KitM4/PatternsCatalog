namespace PatternsCatalog.CreationalPatterns.Builder.Interfaces;

public interface IBuilder<T>
{
    public void Reset();

    public void BuildPart(T item);
}
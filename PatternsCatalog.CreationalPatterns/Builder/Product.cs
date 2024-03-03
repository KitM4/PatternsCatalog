namespace PatternsCatalog.CreationalPatterns.Builder;

public class Product<T>
{
    private readonly List<T> _parts = [];

    public void Add(T part) =>
        _parts.Add(part);

    public string ListParts() =>
        Product<T>.ItemsListToString(_parts);

    private static string ItemsListToString(List<T> items)
    {
        string joinedItems = string.Join(", ", items);
        return $"Parts: {joinedItems}";
    }
}
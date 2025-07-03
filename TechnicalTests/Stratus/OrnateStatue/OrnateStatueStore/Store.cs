namespace OrnateStatueStore;

public class Store
{
    private readonly DegradeFunctionMap _map = new();
    private readonly IList<Item> _items;
    public Store(IList<Item> items)
    {
        _items = items;
    }
    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            _map.GetDegradeMethod(item).DegradeItem(item);
        }
    }
}

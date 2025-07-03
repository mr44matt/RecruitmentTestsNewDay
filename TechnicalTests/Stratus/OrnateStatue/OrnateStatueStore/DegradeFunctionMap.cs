using OrnateStatueStore.DegradeFunctions;

namespace OrnateStatueStore;

public class DegradeFunctionMap
{
    private readonly Dictionary<string, IDegrade> _map = new()
    {
        { "Diamond ring", new GoldRingDegrade() },
        { "Backstage passes to concert", new BackStagePassesDegrade() },
        { "Aged Brie", new StandardDegrade(-1)},
        { "Fresh apples" , new StandardDegrade(2)}
    };
    private readonly IDegrade _defaultDegrade = new StandardDegrade(1);

    public IDegrade GetDegradeMethod(Item item)
    {
        return _map.GetValueOrDefault(item.Name, _defaultDegrade);
    }
}
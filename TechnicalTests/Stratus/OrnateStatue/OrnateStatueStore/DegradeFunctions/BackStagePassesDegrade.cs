namespace OrnateStatueStore.DegradeFunctions;

public class BackStagePassesDegrade: IDegrade
{
    public void DegradeItem(Item item)
    {
        var deltaValue = GetDegradeDeltaValue(item);
        
        item.Quality += deltaValue;
        
        item.Quality = Math.Clamp(item.Quality, 0, 50);
        item.SellIn -= 1;
    }

    private int GetDegradeDeltaValue(Item item)
    {
        return item.SellIn switch
        {
            <= 0 => int.MinValue,
            <= 5 => 3,
            <= 10 => 2,
            _ => 1
        };
    }
}
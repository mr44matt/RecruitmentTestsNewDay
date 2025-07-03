namespace OrnateStatueStore.DegradeFunctions;

public class StandardDegrade(int initialDegrade) : IDegrade
{
    public void DegradeItem(Item item)
    {
        var degradeValue = item.SellIn <= 0 ? initialDegrade * 2 : initialDegrade;
        
        item.Quality -= degradeValue;

        item.Quality = Math.Clamp(item.Quality, 0, 50);
        item.SellIn -= 1;
    }
}
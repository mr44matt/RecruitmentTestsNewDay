namespace OrnateStatueStore.DegradeFunctions;

public class GoldRingDegrade : IDegrade
{
    public void DegradeItem(Item item)
    {
        //"Diamond ring", being a valuable item, never has to be sold or decreases in Quality
    }
}
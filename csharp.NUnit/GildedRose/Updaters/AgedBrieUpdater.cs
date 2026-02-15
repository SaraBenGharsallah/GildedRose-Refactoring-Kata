namespace GildedRoseKata;

public class AgedBrieUpdater : IItemUpdater
{
    public void Update(Item item)
    {
        IncreaseQuality(item);
        item.SellIn--;

        if (item.SellIn < 0)
            IncreaseQuality(item);
    }

    private static void IncreaseQuality(Item item)
    {
        if (item.Quality < 50)
            item.Quality++;
    }
}

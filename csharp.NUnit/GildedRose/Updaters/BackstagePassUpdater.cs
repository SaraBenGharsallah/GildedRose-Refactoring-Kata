namespace GildedRoseKata;

public class BackstagePassUpdater : IItemUpdater
{
    public void Update(Item item)
    {
        IncreaseQuality(item);

        if (item.SellIn <= 10) IncreaseQuality(item);
        if (item.SellIn <= 5) IncreaseQuality(item);

        item.SellIn--;

        if (item.SellIn < 0)
            item.Quality = 0;
    }

    private static void IncreaseQuality(Item item)
    {
        if (item.Quality < 50)
            item.Quality++;
    }
}

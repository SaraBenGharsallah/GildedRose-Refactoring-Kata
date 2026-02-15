namespace GildedRoseKata;

public class NormalItemUpdater : IItemUpdater
{
    public void Update(Item item)
    {
        DecreaseQuality(item);
        item.SellIn--;

        if (item.SellIn < 0)
            DecreaseQuality(item);
    }

    private static void DecreaseQuality(Item item)
    {
        if (item.Quality > 0)
            item.Quality--;
    }
}

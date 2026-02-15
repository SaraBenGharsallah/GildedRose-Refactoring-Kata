namespace GildedRoseKata;

public static class ItemUpdaterFactory
{
    public static IItemUpdater GetUpdater(Item item)
    {
        return item.Name switch
        {
            "Aged Brie" => new AgedBrieUpdater(),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassUpdater(),
            "Sulfuras, Hand of Ragnaros" => new SulfurasUpdater(),
            _ => new NormalItemUpdater()
        };
    }
}

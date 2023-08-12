namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}

public abstract partial class Product : Item
{
    public abstract void UpdateQuality();

    public abstract void RemoveOneToSellIn();
}

public class AgedBrieProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;
        }
    }

    public override void RemoveOneToSellIn()
    {
        SellIn = SellIn - 1;
    }
}

public class BackstagePassesProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;

            if (SellIn < 11)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }

            if (SellIn < 6)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }
        }
    }

    public override void RemoveOneToSellIn()
    {
        SellIn = SellIn - 1;
    }
}
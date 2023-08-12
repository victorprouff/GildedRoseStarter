namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}

public class Product : Item
{
    public virtual void UpdateQuality()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }
    }

    public virtual void RemoveOneToSellIn()
    {
        SellIn = SellIn - 1;
    }
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

public class SulfurasProduct : Product
{
    public override void UpdateQuality()
    {
    }

    public override void RemoveOneToSellIn()
    {
    }
}
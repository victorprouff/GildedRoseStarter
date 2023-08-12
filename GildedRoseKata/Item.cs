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
            Quality--;
        }
    }

    public virtual void RemoveOneToSellIn()
    {
        SellIn--;
    }

    public virtual void UpdateQualityWhenSellInLessThan0()
    {
        if (SellIn < 0 && Quality > 0)
        {
            Quality--;
        }
    }
}

public class AgedBrieProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }

    public override void UpdateQualityWhenSellInLessThan0()
    {
        if (SellIn < 0 && Quality < 50)
        {
            Quality++;
        }
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

    public override void UpdateQualityWhenSellInLessThan0()
    {
        if (SellIn < 0)
        {
            Quality = 0;
        }
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

    public override void UpdateQualityWhenSellInLessThan0()
    {
    }
}
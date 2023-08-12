namespace GildedRoseKata.Products;

public class BackstagePassesProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality >= 50) return;

        Quality++;

        if (SellIn < 11 && Quality < 50)
        {
            Quality++;
        }

        if (SellIn < 6)
        {
            if (Quality < 50)
            {
                Quality++;
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
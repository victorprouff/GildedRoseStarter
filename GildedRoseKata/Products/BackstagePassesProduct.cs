namespace GildedRoseKata.Products;

public class BackstagePassesProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality >= 50)
        {
            SellIn--;
            return;
        }

        Quality++;

        if (Quality < 50)
        {
            if (SellIn < 11)
            {
                Quality++;
            }

            if (SellIn < 6)
            {
                Quality++;
            }
        }

        SellIn--;
    }

    public override void UpdateQualityWhenSellInLessThan0()
    {
        if (SellIn < 0)
        {
            Quality = 0;
        }
    }
}
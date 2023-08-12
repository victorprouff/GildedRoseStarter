namespace GildedRoseKata.Products;

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
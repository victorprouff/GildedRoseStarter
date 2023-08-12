namespace GildedRoseKata.Products;

public class AgedBrieProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }

        SellIn--;

        UpdateQualityWhenSellInLessThan0();
    }

    private void UpdateQualityWhenSellInLessThan0()
    {
        if (SellIn < 0 && Quality < 50)
        {
            Quality++;
        }
    }
}
namespace GildedRoseKata.Products;

public class Product : Item
{
    public virtual void UpdateQuality()
    {
        if (Quality > 0)
        {
            Quality--;
        }

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
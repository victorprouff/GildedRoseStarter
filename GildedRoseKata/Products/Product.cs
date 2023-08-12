namespace GildedRoseKata.Products;

public class Product : Item
{
    public virtual void UpdateQuality()
    {
        SetQuality();

        SetSellIn();

        SetQualityWhenSellInLessThan0();
    }

    private void SetQuality()
    {
        if (Quality > 0)
        {
            Quality--;
        }
    }

    private void SetSellIn()
    {
        SellIn--;
    }

    private void SetQualityWhenSellInLessThan0()
    {
        if (SellIn < 0 && Quality > 0)
        {
            Quality--;
        }
    }
}
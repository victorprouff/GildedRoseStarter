namespace GildedRoseKata.Products;

public class AgedBrieProduct : Product
{
    public AgedBrieProduct(int sellIn)
        : base("Aged Brie", sellIn, 0)
    {
    }

    public override void UpdateQuality()
    {
        SetQuality();

        SetSellIn();

        SetQualityWhenSellInLessThan0();
    }

    private void SetQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }

    private void SetSellIn()
    {
        SellIn--;
    }

    private void SetQualityWhenSellInLessThan0()
    {
        if (SellIn < 0 && Quality < 50)
        {
            Quality++;
        }
    }
}
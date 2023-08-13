namespace GildedRoseKata.Products;

public class ConjuredProduct : Product
{
    public ConjuredProduct(int sellIn, int quality)
        : base("Conjured Mana Cake", sellIn, quality)
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
        if (Quality > 0)
        {
            Quality = Quality - 2;
        }
    }

    private void SetQualityWhenSellInLessThan0()
    {
        if (SellIn < 0 && Quality > 0)
        {
            Quality = Quality - 2;
        }
    }
}
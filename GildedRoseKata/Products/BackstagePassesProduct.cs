namespace GildedRoseKata.Products;

public class BackstagePassesProduct : Product
{
    public BackstagePassesProduct(int sellIn, int quality)
        : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
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
        if (Quality >= 50) return;

        Quality++;

        if (Quality >= 50) return;

        if (SellIn < 11)
        {
            Quality++;
        }

        if (SellIn < 6)
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
        if (SellIn < 0)
        {
            Quality = 0;
        }
    }
}
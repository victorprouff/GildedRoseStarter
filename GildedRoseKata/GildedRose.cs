using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Product> Products;

    public GildedRose(IList<Product> products)
    {
        this.Products = products;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Products.Count; i++)
        {
            Products[i].UpdateQuality();
            Products[i].RemoveOneToSellIn();

            if (Products[i].SellIn < 0)
            {
                if (Products[i] is AgedBrieProduct)
                {
                    Products[i].UpdateQualityWhenSellInLessThan0();
                }
                else if (Products[i] is BackstagePassesProduct)
                {
                    Products[i].UpdateQualityWhenSellInLessThan0();
                }
                else
                {
                    Products[i].UpdateQualityWhenSellInLessThan0();
                }
            }
        }
    }
}
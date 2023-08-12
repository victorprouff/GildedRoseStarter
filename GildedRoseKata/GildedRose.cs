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
                Products[i].UpdateQualityWhenSellInLessThan0();
            }
        }
    }
}
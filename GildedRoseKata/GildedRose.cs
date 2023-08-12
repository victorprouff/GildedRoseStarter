using System.Collections.Generic;
using GildedRoseKata.Products;

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
            Products[i].UpdateQualityWhenSellInLessThan0();
        }
    }
}
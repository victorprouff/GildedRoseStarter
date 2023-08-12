using System.Collections.Generic;
using GildedRoseKata.Products;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Product> Products;

    public GildedRose(IList<Product> products)
    {
        Products = products;
    }

    public void UpdateQuality()
    {
        foreach (var product in Products)
        {
            product.UpdateQuality();
            product.RemoveOneToSellIn();
            product.UpdateQualityWhenSellInLessThan0();
        }
    }
}
using System.Collections.Generic;
using GildedRoseKata.Products;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Product> _products;

    public GildedRose(IList<Product> products)
    {
        _products = products;
    }

    public void UpdateQuality()
    {
        foreach (var product in _products)
        {
            product.UpdateQuality();
        }
    }
}
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
            if (Products[i] is AgedBrieProduct)
            {
                var agedBrieProduct = ((AgedBrieProduct)Products[i]);

                agedBrieProduct.UpdateQuality();
                agedBrieProduct.RemoveOneToSellIn();
            }
            else if (Products[i] is BackstagePassesProduct)
            {
                var backstagePassesProduct = ((BackstagePassesProduct)Products[i]);

                backstagePassesProduct.UpdateQuality();
                backstagePassesProduct.RemoveOneToSellIn();
            }
            else if (Products[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                UpdateQualityForNormalProducts(Products[i]);

                RemoveOneToSellIn(Products[i]);
            }

            if (Products[i].SellIn < 0)
            {
                if (Products[i].Name == "Aged Brie")
                {
                    if (Products[i].Quality < 50)
                    {
                        Products[i].Quality = Products[i].Quality + 1;
                    }
                }
                else if (Products[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    Products[i].Quality = 0;
                }
                else
                {
                    if (Products[i].Quality > 0)
                    {
                        if (Products[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Products[i].Quality = Products[i].Quality - 1;
                        }
                    }
                }
            }
        }
    }

    private void RemoveOneToSellIn(Item item)
    {
        item.SellIn = item.SellIn - 1;
    }

    private void UpdateQualityForNormalProducts(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality = item.Quality - 1;
        }
    }
}
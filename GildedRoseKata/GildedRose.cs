﻿using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            if (Items[i] is AgedBrieProduct)
            {
                ((AgedBrieProduct)Items[i]).UpdateQuality();

                RemoveOneToSellIn(Items[i]);
            }
            else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                UpdateQualityForBackstagePasses(Items[i]);

                RemoveOneToSellIn(Items[i]);
            }
            else if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                UpdateQualityForNormalProducts(Items[i]);

                RemoveOneToSellIn(Items[i]);
            }

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name == "Aged Brie")
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    Items[i].Quality = 0;
                }
                else
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
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

    private void UpdateQualityForBackstagePasses(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality = item.Quality + 1;

            if (item.SellIn < 11)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
using System.Collections.Generic;

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
            if (Items[i].Name == "Aged Brie" || Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[i].Quality < 50)
                {
                    Items[i].Quality = Items[i].Quality + 1;

                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        CalculateBackstagePasses(Items[i]);
                    }
                }
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

            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name == "Aged Brie")
                {
                    Add1QualityIfQualityLowerTo50(Items[i]);
                }
                else
                {
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
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
    }

    private void CalculateBackstagePasses(Item item)
    {
        if (item.SellIn < 11)
        {
            Add1QualityIfQualityLowerTo50(item);
        }

        if (item.SellIn < 6)
        {
            Add1QualityIfQualityLowerTo50(item);
        }
    }

    private void Add1QualityIfQualityLowerTo50(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality = item.Quality + 1;
        }
    }
}
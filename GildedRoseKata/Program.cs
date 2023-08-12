using System;
using System.Collections.Generic;
using GildedRoseKata.Products;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Product> products = new List<Product>{
            new Product {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new AgedBrieProduct(2),
            new Product {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new SulfurasProduct() {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new SulfurasProduct {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new BackstagePassesProduct
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new BackstagePassesProduct
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            },
            new BackstagePassesProduct
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            },
            // this conjured item does not work properly yet
            new Product {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        };

        var app = new GildedRose(products);


        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < products.Count; j++)
            {
                System.Console.WriteLine(products[j].Name + ", " + products[j].SellIn + ", " + products[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}
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
            new Product("+5 Dexterity Vest", 10, 20),
            new AgedBrieProduct(2),
            new Product("Elixir of the Mongoose", 5, 7),
            new SulfurasProduct(0),
            new SulfurasProduct(-1),
            new BackstagePassesProduct(15, 20),
            new BackstagePassesProduct(10, 49),
            new BackstagePassesProduct(5, 49),
            // this conjured item does not work properly yet
            new Product("Conjured Mana Cake", 3, 6)
        };

        var app = new GildedRose(products);

        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < products.Count; j++)
            {
                System.Console.WriteLine(products[j].ToString());
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}
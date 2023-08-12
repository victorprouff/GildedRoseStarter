﻿namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}

public abstract partial class Product : Item
{
    public abstract void UpdateQuality();
}
public class AgedBrieProduct : Product
{
    public override void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;
        }
    }
}
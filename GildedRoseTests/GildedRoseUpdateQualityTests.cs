using FluentAssertions;
using GildedRoseKata.Products;
using Shouldly;

namespace GildedRoseKata;

/// <summary>
/// Test naming convention recommendation:
/// https://ardalis.com/unit-test-naming-convention/
/// </summary>
public class GildedRoseUpdateQualityTests
{
    [Fact]
    public void DoesNothingGivenSulfuras()
    {
        int initialQuality = 80;
        var products = new List<Product>
        {
            new SulfurasProduct(0),
        };
        var gildedRose = new GildedRose(products);

        gildedRose.UpdateQuality();

        var firstItem = products.First();

        // Use your preferred assertion library (already included - pick one delete others)
        // xunit default
        Assert.Equal(initialQuality, firstItem.Quality);

        // fluentassertions
        firstItem.Quality.Should().Be(initialQuality);

        // shouldly
        firstItem.Quality.ShouldBe(initialQuality);
    }
}
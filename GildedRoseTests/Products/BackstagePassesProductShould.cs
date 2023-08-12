using FluentAssertions;

namespace GildedRoseKata.Products;

public class BackstagePassesProductShould
{
    [Theory]
    [InlineData(11, 7)]
    [InlineData(10, 8)]
    [InlineData(6, 8)]
    [InlineData(5, 9)]
    [InlineData(1, 9)]
    [InlineData(0, 0)]
    [InlineData(-1, 0)]
    public void UpdateQuality(int sellIn, int expectedQuality)
    {
        var product = new BackstagePassesProduct(sellIn, 6);

        product.UpdateQuality();

        product.Quality.Should().Be(expectedQuality);
    }

    [Fact]
    public void ToStringReturnLabelProduct()
    {
        var product = new BackstagePassesProduct(5, 50);

        var label = product.ToString();

        label.Should().Be("Backstage passes to a TAFKAL80ETC concert, 5, 50");
    }
}
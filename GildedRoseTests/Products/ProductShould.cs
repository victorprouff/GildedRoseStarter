using FluentAssertions;

namespace GildedRoseKata.Products;

public class ProductShould
{
    [Theory]
    [InlineData(5, 5, 4)]
    [InlineData(1, 5, 4)]
    [InlineData(0, 5, 3)]
    [InlineData(-1, 5, 3)]
    [InlineData(-1, 0, 0)]
    public void UpdateQuality(int sellIn, int quality, int expectedQuality)
    {
        var product = new Product("", sellIn, quality);

        product.UpdateQuality();

        product.Quality.Should().Be(expectedQuality);
    }

    [Fact]
    public void ToStringReturnLabelProduct()
    {
        var product = new Product("test", 5, 50);

        var label = product.ToString();

        label.Should().Be("test, 5, 50");
    }
}
using FluentAssertions;

namespace GildedRoseKata.Products;

public class SulfurasShould
{
    [Theory]
    [InlineData(10, 80)]
    [InlineData(1, 80)]
    [InlineData(0, 80)]
    [InlineData(-1, 80)]
    public void UpdateQuality(int sellIn, int expectedQuality)
    {
        var product = new SulfurasProduct(sellIn);

        product.UpdateQuality();

        product.Quality.Should().Be(expectedQuality);
    }

    [Fact]
    public void ToStringReturnLabelProduct()
    {
        var product = new SulfurasProduct(5);

        var label = product.ToString();

        label.Should().Be("Sulfuras, Hand of Ragnaros, 5, 80");
    }
}
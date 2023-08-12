using FluentAssertions;

namespace GildedRoseKata.Products;

public class SulfurasShould
{
    [Theory]
    [InlineData(10, 80)]
    [InlineData(1, 80)]
    [InlineData(0, 80)]
    [InlineData(-1, 80)]
    public void QualityDeclines(int sellIn, int expectedQuality)
    {
        var product = new SulfurasProduct(sellIn);

        product.UpdateQuality();

        product.Quality.Should().Be(expectedQuality);
    }
}
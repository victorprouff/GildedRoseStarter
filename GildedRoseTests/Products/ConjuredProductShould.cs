using FluentAssertions;

namespace GildedRoseKata.Products;

public class ConjuredProductShould
{
    [Theory]
    [InlineData(3, 6, 4)]
    [InlineData(2, 4, 2)]
    [InlineData(1, 2, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 0, 0)]
    public void QualityDeclinesTwiceAsFastAsNormalProducts(int sellIn, int quality, int expectedQuality)
    {
        var product = new ConjuredProduct(sellIn, quality);

        product.UpdateQuality();

        product.Quality.Should().Be(expectedQuality);
    }
}
using FluentAssertions;

namespace GildedRoseKata.Products;

public class AgedBrieProductShould
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 7)]
    [InlineData(30, 50)]
    public void UpdateQuality(int numberOfTurns, int expectedQuality)
    {
        var product = new AgedBrieProduct(3);

        for (var turn = 0; turn < numberOfTurns; turn++)
        {
            product.UpdateQuality();
        }

        product.Quality.Should().Be(expectedQuality);
    }

    [Fact]
    public void ToStringReturnLabelProduct()
    {
        var product = new AgedBrieProduct(5);

        var label = product.ToString();

        label.Should().Be("Aged Brie, 5, 0");
    }
}
using NUnit.Framework;
using Pricing;

namespace Pricing.Tests;

[TestFixture]
public class PriceCalculatorTests
{
    [Test]
    public void Total_OfOneTwoThree_IsSix()
    {
        decimal result = PriceCalculator.Total(new[] { 1m, 2m, 3m });
        Assert.That(result, Is.EqualTo(6m));
    }

    [Test]
    public void Total_OfEmptyList_IsZero()
    {
        decimal result = PriceCalculator.Total(Array.Empty<decimal>());
        Assert.That(result, Is.EqualTo(0m));
    }

    [Test]
    public void Average_OfTwoAndFour_IsThree()
    {
        decimal result = PriceCalculator.Average(new[] { 2m, 4m });
        Assert.That(result, Is.EqualTo(3m));
    }

    [Test]
    public void MaxPrice_ReturnsTheLargest()
    {
        decimal result = PriceCalculator.MaxPrice(new[] { 1.5m, 9m, 3m });
        Assert.That(result, Is.EqualTo(9m));
    }

    [Test]
    public void MinPrice_ReturnsTheSmallest()
    {
        decimal result = PriceCalculator.MinPrice(new[] { 1.5m, 9m, 3m });
        Assert.That(result, Is.EqualTo(1.5m));
    }
}

namespace Pricing;

public static class PriceCalculator
{
    // Adds up every price in the list. An empty list has a total of 0.
    public static decimal Total(IReadOnlyList<decimal> prices)
    {
        decimal total = 0m;
        foreach (decimal price in prices)
        {
            total += price;
        }
        return total;
    }

    // The average price. An empty list has an average of 0.
    public static decimal Average(IReadOnlyList<decimal> prices)
    {
        if (prices.Count == 0)
        {
            return 0m;
        }
        return Total(prices) / prices.Count;
    }

    // The highest price. An empty list has a maximum of 0.
    public static decimal MaxPrice(IReadOnlyList<decimal> prices)
    {
        if (prices.Count == 0)
        {
            return 0m;
        }
        return prices.Max();
    }

    // The lowest price. An empty list has a minimum of 0.
    public static decimal MinPrice(IReadOnlyList<decimal> prices)
    {
        if (prices.Count == 0)
        {
            return 0m;
        }
        return prices.Max();
    }
}

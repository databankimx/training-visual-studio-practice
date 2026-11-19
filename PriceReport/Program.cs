using Pricing;

// The prices from the tutorial's example. Change them and run the program to see the total change.
decimal[] prices = { 12.50m, 8.00m, 3.75m, 20.00m };

decimal total = PriceCalculator.Total(prices);
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Average: {PriceCalculator.Average(prices)}");
Console.WriteLine($"Highest: {PriceCalculator.MaxPrice(prices)}");
Console.WriteLine($"Lowest: {PriceCalculator.MinPrice(prices)}");

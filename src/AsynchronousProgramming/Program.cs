
using AsynchronousProgramming;

Console.WriteLine("Hello, Asynchronous Programming!");

var productId = 1;

var productService = new ProductService();
var currencyConverterService = new CurrencyConverterService();
LoggerService logger = new LoggerService();

decimal price = productService.GetPriceAsync(productId).Result;
decimal conversionRate = currencyConverterService.GetConversionRate("PLN", "EUR");

var priceInEur = price * conversionRate;

Console.WriteLine($"Price in EUR: {priceInEur}");

logger.Log($"Calculated price in EUR for product {productId}: {priceInEur:C}");


static void DumpThreadId(string message)
{
    Console.WriteLine($"{message}: Thread ID = {Thread.CurrentThread.ManagedThreadId}");
}


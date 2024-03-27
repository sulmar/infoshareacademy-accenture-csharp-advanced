
using AsynchronousProgramming;

Console.WriteLine("Hello, Asynchronous Programming!");

TasksTestAsync();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();


static void DumpThreadId(string message)
{
    Console.WriteLine($"{message}: Thread ID = {Thread.CurrentThread.ManagedThreadId}");
}

static async Task TasksTestAsync()
{
    var productId = 1;

    var productService = new ProductService();
    var currencyConverterService = new CurrencyConverterService();
    LoggerService logger = new LoggerService();

    var price = await productService.GetPriceAsync(productId);
    decimal conversionRate = await currencyConverterService.GetConversionRateAsync("PLN", "EUR");

    var priceInEur = price * conversionRate;

    Console.WriteLine($"Price in EUR: {priceInEur}");

    logger.Log($"Calculated price in EUR for product {productId}: {priceInEur:C}");
}
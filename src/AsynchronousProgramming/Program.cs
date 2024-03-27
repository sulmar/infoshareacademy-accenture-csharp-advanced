
using AsynchronousProgramming;

Console.WriteLine("Hello, Asynchronous Programming!");

var productId = 1;

var productService = new ProductService();
var currencyConverterService = new CurrencyConverterService();
LoggerService logger = new LoggerService();

Task<decimal> taskPrice = productService.GetPriceAsync(productId);

taskPrice.ContinueWith(taskPrice =>
{
    var price = taskPrice.Result;

    Task<decimal> conversionRateTask = currencyConverterService.GetConversionRateAsync("PLN", "EUR");

    conversionRateTask.ContinueWith(conversionRateTask =>
    {
        var conversionRate = conversionRateTask.Result;

        var priceInEur = price * conversionRate;

        Console.WriteLine($"Price in EUR: {priceInEur}");

        logger.Log($"Calculated price in EUR for product {productId}: {priceInEur:C}");
    });

});


Console.WriteLine("Press any key to exit.");
Console.ReadKey();


static void DumpThreadId(string message)
{
    Console.WriteLine($"{message}: Thread ID = {Thread.CurrentThread.ManagedThreadId}");
}



using AsynchronousProgramming;

Console.WriteLine("Hello, Asynchronous Programming!");

MultiTasksTestAsync();

// TasksTestAsync();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();


static void DumpThreadId(string message)
{
    Console.WriteLine($"{message}: Thread ID = {Thread.CurrentThread.ManagedThreadId}");
}

static async void MultiTasksTestAsync()
{
    var productService = new ProductService();

    var price1Task = productService.GetPriceAsync(1);
    var price2Task = productService.GetPriceAsync(2);

    // Task.WaitAll(price1Task, price2Task);

    await Task.WhenAll(price1Task, price2Task);

    var price1 = price1Task.Result;
    var price2 = price2Task.Result;

    var total = price1 + price2;
    Console.WriteLine(total);
}



static async void TasksTestAsync()
{
    var productId = 1;

    var productService = new ProductService();
    var currencyConverterService = new CurrencyConverterService();
    LoggerService logger = new LoggerService();

    // var price = productService.GetPrice(productId);
    // decimal conversionRate = currencyConverterService.GetConversionRate("PLN", "EUR");

    var price = await productService.GetPriceAsync(productId).ConfigureAwait(false);

    decimal conversionRate = await currencyConverterService.GetConversionRateAsync("PLN", "EUR").ConfigureAwait(false);

    var priceInEur = price * conversionRate;

    Console.WriteLine($"Price in EUR: {priceInEur}");

    try
    {
        await logger.LogAsync($"Calculated price in EUR for product {productId}: {priceInEur:C}");
    }
    catch (Exception ex)
    {

    }
}
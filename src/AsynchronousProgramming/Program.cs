
using AsynchronousProgramming;
using System;
using System.Threading.Channels;

Console.WriteLine("Hello, Asynchronous Programming!");

List<Customer> customers = new List<Customer>();

CustomerProcessor customerProcessor  = new CustomerProcessor();

for (int i = 0; i < 100; i++)
{
    customers.Add(new Customer { TaxNumber = i.ToString() });
}

customerProcessor.Process(customers, new SignalRCustomerProgress());



// MultiTasksTestAsync();

try
{
    CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(190));

    //IProgress<int> progress = new Progress<int>(step => Console.WriteLine(new string('.', step)));

    IProgress<int> progress = new ColorConsoleProgress();

    TasksTestAsync(cts.Token, progress);

    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();

    cts.Cancel();
    // cts.CancelAfter(TimeSpan.FromSeconds(3));

}
catch (OperationCanceledException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}

finally
{
    Console.WriteLine("Press any enter to exit.");
    Console.ReadLine();
}


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



static async void TasksTestAsync(CancellationToken cancellationToken = default, IProgress<int> progress = default)
{
    var productId = 1;

    var productService = new ProductService();
    var currencyConverterService = new CurrencyConverterService();
    LoggerService logger = new LoggerService();

    // var price = productService.GetPrice(productId);
    // decimal conversionRate = currencyConverterService.GetConversionRate("PLN", "EUR");



    var price = await productService.GetPriceAsync(productId, cancellationToken, progress).ConfigureAwait(false);

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
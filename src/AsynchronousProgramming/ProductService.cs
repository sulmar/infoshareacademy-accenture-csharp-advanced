using System.Threading;
using System;

namespace AsynchronousProgramming;

public class ProductService
{
    public Task<decimal> GetPriceAsync(int productId)
    {
        //Task task = new Task(() => GetPrice(productId));
        //task.Start();        

        Task<decimal> task = Task.Run(() => GetPrice(productId));

        return task;
    }

    public Task QuickChangePriceAsync(int productId, decimal newPrice)
    {
        // zła praktyka:
        // return Task.Run(() => QuickChangePrice(productId, newPrice));

        QuickChangePrice(productId, newPrice);

        // dobra praktyka
        return Task.CompletedTask;
    }

    public Task<decimal> RecalculatePriceAsync(decimal originalPrice)
    {
        decimal newPrice = originalPrice * 1.1m;

        return Task.FromResult(newPrice);
    }

    

    public void QuickChangePrice(int productId, decimal newPrice)
    {

    }

    public decimal GetPrice(int productId)
    {
        "Fetching product price...".DumpThreadId();

        // Simulate a delay to mimic database or network latency
        for (int i = 0; i <= 10; i++)
        {
            Thread.Sleep(100); // 1 second delay

            // TODO: Report progress (0% to 100%)
        }

        "Fetched product price.".DumpThreadId();

        // Return a dummy product for demonstration purposes
        return 29.99M;
    }
}

public class LoggerService
{
    // Simulates an asynchronous log operation without a return value
    public void Log(string message)
    {
        Thread.Sleep(1000); // Simulate some I/O delay, like writing to a file or database

        $"[Log]: {message}".DumpThreadId();
    }

    public Task LogAsync(string message)
    {
        return Task.Run(()=>Log(message));  
    }
}

public class CurrencyConverterService
{
    public Task<decimal> GetConversionRateAsync(string fromCurrency, string toCurrency)
    {
        return Task.Run(() => GetConversionRate(fromCurrency, toCurrency));
    }

    // Simulates fetching a currency conversion rate asynchronously
    public decimal GetConversionRate(string fromCurrency, string toCurrency)
    {
        "Fetching currency conversion rate...".DumpThreadId();

        for (int i = 0; i <= 5; i++)
        {
            Thread.Sleep(500); // 2.5 second delay            

            // TODO: Add cancellation 
        }

        "Fetched currency conversion rate.".DumpThreadId();

        // Return a dummy conversion rate for demonstration
        // In a real application, this could fetch live rates from an API
        return toCurrency.ToUpper() == "EUR" ? 0.93M : 1M; // Example: PLN to EUR
    }
}

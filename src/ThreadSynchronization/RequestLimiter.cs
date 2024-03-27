using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization;

internal class RequestLimiter
{
    private readonly Semaphore _semaphore;

    public RequestLimiter(int maxConcurrentRequests)
    {
        _semaphore = new Semaphore(maxConcurrentRequests, maxConcurrentRequests);
    }

    public void ProcessRequest(int requestId)
    {
        Console.WriteLine($"Request {requestId} is waiting to processing...");

        _semaphore.WaitOne();

        try
        {
            Console.WriteLine($"Processing request {requestId}");

            Thread.Sleep(1000);
        }
        finally
        {
            Console.WriteLine($"Request {requestId} is processed.");

            _semaphore.Release();
        }

    }
}

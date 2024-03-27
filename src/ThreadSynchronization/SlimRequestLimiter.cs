namespace ThreadSynchronization;

internal class RequestLimiterSlim
{
    private SemaphoreSlim _semaphoreSlim;

    public RequestLimiterSlim(int maxConcurrentRequests)
    {
        _semaphoreSlim = new SemaphoreSlim(maxConcurrentRequests);
    }

    public async Task ProcessRequest(int requestId)
    {
        Console.WriteLine($"Request {requestId} is awaiting to processing...");

        await _semaphoreSlim.WaitAsync();

        try
        {
            Console.WriteLine($"Processing request {requestId}");

            await Task.Delay(1000);
        }
        finally
        {
            Console.WriteLine($"Request {requestId} is processed.");

            _semaphoreSlim.Release();
        }
    }
}
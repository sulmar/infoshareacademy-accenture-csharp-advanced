// See https://aka.ms/new-console-template for more information

using System.Threading;
using ThreadSynchronization;

Console.WriteLine("Hello, Thread Synchronization!");

// MonitorTest();

SemaphoreTest();

//MutexTest();


void MonitorTest()
{
    // Simulate multiple threads accessing the LoadBalancer
    for (int i = 0; i < 5; i++)
    {
        Thread thread = new Thread(() =>
        {
            var loadBalancer = LoadBalancer.Instance;
            var server = loadBalancer.NextServer;
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} got server: {server.Name} ({server.IP})");
        });

        

        thread.Start();

        // Thread.Sleep(100);
    }

    // TODO: Fix the multi Initialize problem

    Console.ReadLine();
}

// SemaphoreTest();
SemaphoreSlimTest();


void SemaphoreTest()
{
    RequestLimiter requestLimiter = new RequestLimiter(3); // TODO: Limit to 3 concurrent requests

    for (int i = 1; i <= 20; i++)
    {
        int requestId = i;
        Thread thread = new Thread(() => requestLimiter.ProcessRequest(requestId));
        thread.Start();
    }
}


void SemaphoreSlimTest()
{
    RequestLimiterSlim requestLimiter = new RequestLimiterSlim(3); // TODO: Limit to 3 concurrent requests

    for (int i = 1; i <= 20; i++)
    {
        int requestId = i;
        Thread thread = new Thread(() => requestLimiter.ProcessRequest(requestId));
        thread.Start();
    }
}

static void MutexTest()
{
    // TODO: Check if another instance of the application is already running
    if (true)
    {
        Console.WriteLine("Another instance of the application is already running.");
        return;
    }

    Console.WriteLine("Application is running...");
    Console.ReadLine();
}
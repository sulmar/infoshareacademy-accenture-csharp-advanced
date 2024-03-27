// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using ThreadSafeCollection;

Console.WriteLine("Hello, Thread-safe Collection!");

// ConcurrentDictionaryTest();

// ConcurrentQueueTest();

// ConcurrentBagTest();

await BlockingCollectionsTest();

static async Task BlockingCollectionsTest()
{
    BlockingCollection<string> imageQueue = new BlockingCollection<string>();

    ImageProducer imageProducer = new(imageQueue);
    ImageConsumer imageConsumer = new(imageQueue);

    Task.Run(() => imageConsumer.StartProcessing());
    Task.Run(() => imageConsumer.StartProcessing());

    await imageProducer.StartProducingAsync();

    Console.WriteLine("Press any key to exit.");
    Console.ReadLine();
}

static void ConcurrentBagTest()
{
    LogManager logManager = new LogManager();
    // Start log processing in the background
    logManager.ProcessLogs();

    // Simulate multiple threads adding log entries concurrently
    Parallel.Invoke(
        () => logManager.Log("Error in Module A"),
        () => logManager.Log("Warning in Module B"),
        () => logManager.Log("Info in Module C")
    );

    // Simulate the main thread doing some work
    Console.WriteLine("Main thread is working...");

    // Keep the application running
    Console.ReadLine();
}

static void ConcurrentDictionaryTest()
{
    ConfigManager configManager = new ConfigManager();

    // Simulate multiple threads setting and getting values concurrently
    Parallel.Invoke(
        () => configManager.Set("Key1", "Value1"),
        () => configManager.Set("Key2", "Value2"),
        () => configManager.Set("Key3", "Value3"),
        () =>
        {
            // Simulate a delay before getting a value
            Task.Delay(100).Wait();
            var value = configManager.Get("Key2");
            Console.WriteLine($"Thread {Task.CurrentId} retrieved value: {value}");
        }
    );


    // Simulate the main thread doing some work
    Console.WriteLine("Main thread is working...");

    // Keep the application running
    Console.ReadLine();
}

static void ConcurrentQueueTest()
{
    TaskManager taskManager = new TaskManager();

    // Start task processing in the background
    taskManager.ProcessTasks();

    // Simulate multiple threads enqueuing tasks concurrently without proper synchronization
    Parallel.Invoke(
        () => taskManager.EnqueueTask("Task 1"),
        () => taskManager.EnqueueTask("Task 2"),
        () => taskManager.EnqueueTask("Task 3"),
        () => taskManager.EnqueueTask("Task 4"),
        () => taskManager.EnqueueTask("Task 5")
    );

    // Simulate the main thread doing some work
    Console.WriteLine("Main thread is working...");

    // Keep the application running
    Console.ReadLine();
}
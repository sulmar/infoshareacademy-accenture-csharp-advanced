
using System.Diagnostics;
using System.Net;
using Threads;

Console.WriteLine("Hello, Threads!");

const string defaultUri = "https://picsum.photos/800/600";
const int count = 100;

string[] uris = new string[count];

for (int i = 0; i < uris.Length; i++)
{
    uris[i] = defaultUri;
}

// ThreadTest(uris);

ThreadPoolTest(uris);


static void ThreadTest(string[] uris)
{
    Console.WriteLine("Downloading by Thread.");

    Stopwatch stopwatch = new Stopwatch();

    stopwatch.Start();

    List<Thread> threads = new List<Thread>();

    foreach (string uri in uris)
    {
        Thread thread = new Thread(() => Download(uri));
        thread.Start();
        threads.Add(thread);
    }

    // Wait for all thread to complete
    foreach (Thread thread in threads)
    {
        thread.Join();
    }

    stopwatch.Stop();

    Console.WriteLine("All downloads completed.");

    Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

    var usedThreads = uris.Length;

    Console.WriteLine($"Total threads used: {usedThreads}");
}


static void ThreadPoolTest(string[] uris)
{
    Console.WriteLine("Downloading by ThreadPool.");

    // TODO: Speed up downloading and reduce resources

    Stopwatch stopwatch = new Stopwatch();

    stopwatch.Start();

    foreach (string uri in uris)
    {
        ThreadPool.QueueUserWorkItem(_ => Download(uri));
    }

    stopwatch.Stop();
    

    Console.WriteLine("Press any key to continue.");
    Console.ReadKey();

    Console.WriteLine("All downloads completed.");

    Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

    var usedThreads = uris.Length;

    Console.WriteLine($"Total threads used: {usedThreads}");
}

static void Download(string uri)
{
    using (var client = new WebClient())
    {
        $"Downloading {uri}...".DumpThreadId();
        // string content = client.DownloadStringTaskAsync(uri).Result;
        // string content = client.DownloadString(uri);

        Thread.Sleep(Random.Shared.Next(200, 1000));

        $"Downoladed. {uri}".DumpThreadId();


    }
}
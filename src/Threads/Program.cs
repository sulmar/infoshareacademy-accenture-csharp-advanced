
using System.Diagnostics;
using System.Net;
using Threads;

Console.WriteLine("Hello, Threads!");

const string defaultUri = "https://picsum.photos/800/600";
const int count = 10;

string[] uris = new string[count];

for (int i = 0; i < uris.Length; i++)
{
    uris[i] = defaultUri;
}

ThreadTest(uris);

ThreadPoolTest(uris);


static void ThreadTest(string[] uris)
{
    Console.WriteLine("Downloading by Thread.");

    // TODO: Speed up downloading

    Stopwatch stopwatch = new Stopwatch();

    stopwatch.Start();

    foreach (string uri in uris)
    {
        Download(uri);        
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
        Download(uri);        
    }

    stopwatch.Stop();

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

        string content = client.DownloadString(uri);

        Thread.Sleep(250);

        $"Downoladed. {uri}".DumpThreadId();


    }
}
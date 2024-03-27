
using System.Diagnostics;
using System.Net;
using Threads;

Console.WriteLine("Hello, Threads!");

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

for (int i = 0; i < 10; i++)
{
    Download("https://picsum.photos/800/600");
}

stopwatch.Stop();

// Write result.
Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);


static void Download(string uri)
{
    using (var client = new WebClient())
    {
        $"Downloading {uri}...".DumpThreadId();
        
        string content = client.DownloadString(uri);

        $"Downoladed. {uri}".DumpThreadId();

        
    }
}
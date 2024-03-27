using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeCollection;

internal class ImageProducer
{
    private FileSystemWatcher watcher;

    private readonly BlockingCollection<string> imageQueue;

    public ImageProducer(BlockingCollection<string> imageQueue)
    {
        watcher = new FileSystemWatcher(@"C:\temp");

        watcher.Created += Watcher_Created;

        watcher.Filter = "*.*";
        watcher.IncludeSubdirectories = true;

        this.imageQueue = imageQueue;
    }

    private void Watcher_Created(object sender, FileSystemEventArgs e)
    {
        string image = e.FullPath;

        imageQueue.Add(image);


    }

    public Task StartProducingAsync()
    {
        watcher.EnableRaisingEvents = true;

        return Task.CompletedTask;
    }
}

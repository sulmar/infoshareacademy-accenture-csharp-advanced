using System.Collections.Concurrent;

namespace ThreadSafeCollection;

internal class ImageConsumer
{
    private readonly BlockingCollection<string> imageQueue;

    public ImageConsumer(BlockingCollection<string> imageQueue)
    {
        this.imageQueue = imageQueue;
    }

    public void StartProcessing()
    {
        foreach (var image in imageQueue.GetConsumingEnumerable())
        {
            Console.WriteLine($"Processing {image}");
        }
    }
}
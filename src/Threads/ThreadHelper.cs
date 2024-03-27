namespace Threads;

public static class ThreadHelper
{
    public static void DumpThreadId(this string message)
    {
        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} {message} ");
    }
}

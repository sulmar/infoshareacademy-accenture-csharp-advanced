namespace AsynchronousProgramming;

public static class ThreadHelper
{
    public static void DumpThreadId(this string message)
    {
        Console.WriteLine($"{message}: Thread ID = {Thread.CurrentThread.ManagedThreadId}");
    }
}

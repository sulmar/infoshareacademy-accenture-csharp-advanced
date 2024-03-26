
using AnonymousMethods;

Console.WriteLine("Hello, Delegates!");

Printer printer = new Printer();
printer.Log += LogToDb;
printer.Log += LogToConsole;
printer.Log += LogToFile;
printer.Log += Console.WriteLine;

// printer.Log -= LogToConsole;

var loggers = printer.Log.GetInvocationList();

foreach (var logger in loggers)
{
    Console.WriteLine(logger.Method);
}

printer.Print("Lorem ipsum");
printer.Print("Lorem ipsum", 3);

Console.WriteLine();

static void LogToConsole(string message)
{
    Console.WriteLine($"[{DateTime.Now}] {message}");
}

static void LogToFile(string message)
{
    File.AppendAllText("log.txt", $"[{DateTime.Now}] {message}");
}

static void LogToDb(string message)
{
    Console.WriteLine(message);
}
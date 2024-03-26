
using AnonymousMethods;

Console.WriteLine("Hello, Delegates!");

Printer printer = new Printer();
printer.Log += LogToDb;
printer.Log += LogToConsole;
printer.Log += LogToFile;
printer.Log += Console.WriteLine;

// Metoda anonimowa
printer.Log += delegate (string msg)
{
    File.AppendAllText("log.json", $"[{DateTime.Now}] {msg}");
};

// Wyrażenie Lambda (Lambda Expression) - funkcje strzałkowe w JS
printer.Log += (msg) => File.AppendAllText("log.bin", $"[{DateTime.Now}] {msg}");

PrintCostCalculator calculator = new PrintCostCalculator();
printer.CalculateCost += calculator.CalculateCost;

var f = (int x, int y) => x + y;

var result = f(1, 2);

// C# x => y
// JS x -> y
// R  y <- x

// f(x) = x + 1   gdzie x nalezy do Z
// int F(int x) { return x + 1; }
// x => x + 1
// f(x, y) = x + y 
// (x, y) => x + y

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


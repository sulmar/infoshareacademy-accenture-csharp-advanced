
using AnonymousMethods;
using System.Threading.Channels;

Console.WriteLine("Hello, Delegates!");


int res = Calculate();

int Calculate()
{
    return 1 + 2 + 4;
}

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


printer.OnPrintCompleted += (sender, args) => Console.WriteLine($"Printed by {sender} {args.Copies} copies.");

PrintCostCalculator calculator = new PrintCostCalculator();
// printer.CalculateCost += calculator.CalculateCost;

// Wyrażenie lambda
printer.CalculateCost += (copies, cost) => copies * cost;

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

// printer.OnPrintCompleted.Invoke(200);
printer.CanPrint = (copies) => copies < 10;

printer.OnErrorPrint((msg) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(msg);
    Console.ResetColor();
});

printer.Print("Lorem ipsum");
printer.Print("Lorem ipsum", 11);

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


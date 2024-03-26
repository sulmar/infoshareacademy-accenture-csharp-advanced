namespace AnonymousMethods;

public class Printer
{
    public delegate void LogDelegate(string message);
    public LogDelegate? Log;

    public void Print(string content, byte copies = 1)
    {
        for (int copy = 0; copy < copies; copy++)
        {
            Log?.Invoke($"Printing {content} copy #{copy}");
        }

        // TODO: refactor
        decimal? cost = CalculateCost(copies, 0.99M);

        if (cost.HasValue)
        {
            DisplayLCD(cost.Value);
        }

        // TODO: Send printed signal 
        Console.WriteLine($"Printed {copies} copies.");
    }

    private decimal CalculateCost(int copies, decimal cost)
    {
        return copies * cost;
    }

    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}


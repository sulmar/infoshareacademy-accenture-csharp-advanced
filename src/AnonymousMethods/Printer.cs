namespace AnonymousMethods;

public class Printer
{
    public Action<string> Log;
    public Func<byte, decimal, decimal> CalculateCost;

    public delegate void PrintCompletedDelegate(byte copies);
    public event PrintCompletedDelegate? OnPrintCompleted;

    public void Print(string content, byte copies = 1)
    {
        for (int copy = 0; copy < copies; copy++)
        {
            //if (Log != null)
            //{
            //    Log.Invoke($"Printing {content} copy #{copy}");
            //}

            Log?.Invoke($"Printing {content} copy #{copy}");
        }

        decimal? cost = CalculateCost?.Invoke(copies, 0.99M);

        if (cost.HasValue)
        {
            DisplayLCD(cost.Value);
        }
        
        OnPrintCompleted?.Invoke(copies);
    }



    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}


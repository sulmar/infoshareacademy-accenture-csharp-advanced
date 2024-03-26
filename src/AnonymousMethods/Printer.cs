namespace AnonymousMethods;

public class Printer
{
    public Action<string> Log;
    public Func<byte, decimal, decimal> CalculateCost;

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

        // TODO: Send printed signal 
        Console.WriteLine($"Printed {copies} copies.");
    }



    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}


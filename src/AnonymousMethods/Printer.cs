namespace AnonymousMethods;

public class PrintEventArgs : EventArgs
{
    public int Copies { get; }

    public PrintEventArgs(int copies)
    {
        Copies = copies;
    }
}

public class Printer
{
    public Action<string> Log;
    public Func<byte, decimal, decimal> CalculateCost;
    public Predicate<byte> CanPrint;

    public event EventHandler<PrintEventArgs> OnPrintCompleted;

    public void Print(string content, byte copies = 1)
    {
        if (!CanPrint.Invoke(copies))
        {
            throw new InvalidOperationException($"Nie możesz drukować więcej niż {copies} kopii.");
        }

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
        
        OnPrintCompleted?.Invoke(this, new PrintEventArgs(copies));
    }



    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}


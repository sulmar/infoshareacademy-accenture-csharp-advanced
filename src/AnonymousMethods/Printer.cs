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

    private Action<string> _onErrorPrint;
    public void OnErrorPrint(Action<string> onErrorPrint)
    {
        _onErrorPrint = onErrorPrint;
    }

    public void Print(string content, byte copies = 1)
    {
        if (!CanPrint.Invoke(copies))
        {
            var message = $"Nie możesz drukować więcej niż {copies} kopii.";

            _onErrorPrint?.Invoke(message);

            throw new InvalidOperationException(message);
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


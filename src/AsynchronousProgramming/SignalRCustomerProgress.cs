using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming;

internal class SignalRCustomerProgress : IProgress<Customer>
{
    public void Report(Customer value)
    {
        Console.WriteLine($"Send to client by Signal-R", value);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming;

internal class CustomerProcessor
{
    public void Process(IEnumerable<Customer> customers, IProgress<Customer> progress)
    {
        foreach (var customer in customers)
        {
            progress.Report(customer);

            Thread.Sleep(1000);

        }
    }
}

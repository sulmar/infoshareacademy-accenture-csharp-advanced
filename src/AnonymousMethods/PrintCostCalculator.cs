using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods;

internal class PrintCostCalculator
{
    public decimal CalculateCost(int copies, decimal cost)
    {
        return copies * cost;
    }
}

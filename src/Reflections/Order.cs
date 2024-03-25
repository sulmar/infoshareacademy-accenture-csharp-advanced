using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections;

/// <summary>
/// A class representing an order.
/// </summary>
public class Order
{
    /// <summary>
    /// The ID of the order.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the total amount of the order.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Calculates the tax for the order based on a given tax rate.
    /// </summary>
    /// <param name="taxRate">The tax rate as a percentage.</param>
    /// <returns>The tax amount for the order.</returns>
    public decimal CalculateTax(decimal taxRate)
    {
        return TotalAmount * (taxRate / 100);
    }

    public event EventHandler OrderProcessed;
}
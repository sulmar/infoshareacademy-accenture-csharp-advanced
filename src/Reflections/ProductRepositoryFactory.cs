using Reflections.Abstractions;
using Reflections.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections;

internal class ProductRepositoryFactory
{
    public static IProductRepository Create(bool csvMode)
    {
        if (csvMode)
        {
            return new CsvFileProductRepository("file1.csv");
        }
        else
        {
            return new DbProductRepository();
        }
    }
}

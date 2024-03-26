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
    public static IProductRepository Create(string source)
    {
        if (source == "CsvFile")
        {
            return new CsvFileProductRepository("file1.csv");
        }
        else if (source == "Db")
        {
            return new DbProductRepository();
        }

        throw new NotSupportedException();
    }
}

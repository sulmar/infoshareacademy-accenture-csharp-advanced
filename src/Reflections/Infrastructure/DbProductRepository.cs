using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Infrastructure;

internal class CsvFileProductRepository
{
    private Product product;

    public CsvFileProductRepository()
    {
        product = new Product(1, $"Product from CSV", "Black", 10.99m, Product.Category.Electronics);
    }

    public Product Load(string filename, int id)
    {
        return product;
    }

    public void Save(string filename, Product product)
    {
        this.product = product;
    }
}

internal class DbProductRepository
{
    private Product product;

    public DbProductRepository()
    {
        product = new Product(1, $"Product from Db", "Black", 10.99m, Product.Category.Electronics);
    }

    public Product Get(int id)
    {
        return product;
    }

    public void Add(Product product)
    {
        this.product = product;
    }

    public void ChangeColor(int id, string newColor)
    {
        product.Color = newColor;
    }
}

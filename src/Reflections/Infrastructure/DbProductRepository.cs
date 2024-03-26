using Reflections.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Infrastructure;

internal class S3StorageProductRepository : IProductRepository
{
    public void Add(Product product)
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }
}

internal class CsvFileProductRepository : IProductRepository
{
    private readonly string _filename;
    private Product product;

    public CsvFileProductRepository(string filename)
    {
        product = new Product(1, $"Product from CSV", "Black", 10.99m, Product.Category.Electronics);

        this._filename = filename;
    }

    public void Add(Product product)
    {
        Save(_filename, product);
    }

    public Product Get(int id)
    {
        return Load(_filename, id);
    }

    private Product Load(string filename, int id)
    {
        return product;
    }

    private void Save(string filename, Product product)
    {
        this.product = product;
    }
}

internal class DbProductRepository : IProductRepository
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

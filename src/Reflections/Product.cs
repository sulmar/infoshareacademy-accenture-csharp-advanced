namespace Reflections;


// TODO: Add [Image("product.ico")]
internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; }    
    public string Color { get; set; }
    public decimal Price { get; set; }
    public Category ProductCategory { get; set; }

    public Product(int id, string name, string color, decimal price, Category productCategory)
    {
        Id = id;
        Name = name;
        Color = color;
        Price = price;
        ProductCategory = productCategory;
    }

    public override string ToString()
    {
        return $"{{ Product: Name = {Name}, Price = {Price}, Category = {ProductCategory} }}";
    }

    public enum Category
    {
        Electronics,
        Clothing,
        Books,
        Beauty,
        Food,
        Home,
        Other
    }
}



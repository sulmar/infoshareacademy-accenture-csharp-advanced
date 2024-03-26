using Reflections.Abstractions;
using System.Reflection;

namespace Reflections;

internal class ProductRepositoryFactory
{
    private readonly IDictionary<Type, Type> _container;

    public static IProductRepository Create(string source)
    {
        string name = $"Reflections.Infrastructure.{source}ProductRepository";

        Type type = Assembly.GetExecutingAssembly().GetType(name);

        return Create(type);
    }

    public static IProductRepository Create<T>()
    {
        Type type = typeof(T);

        return Create(type);
    }


    public static IProductRepository Create(Type type)
    {
        foreach (var constructor in type.GetConstructors())
        {
            foreach(var parameter in constructor.GetParameters())
            {
                Console.WriteLine($"{parameter.Name} {parameter.ParameterType}");

            }
        }

        if (type == null)
            throw new NotSupportedException();

        IProductRepository instance = Activator.CreateInstance(type, "file1.txt") as IProductRepository;

        return instance;


    }
}

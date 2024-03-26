namespace Reflections;

internal class DocumentationGenerator
{
    public static void GenerateDocumentation(Type type)
    {
        Console.WriteLine($"Documentation for {type.Name}:");
        Console.WriteLine();

        GeneratePropertiesDocumentation(type);
        GenerateMethodsDocumentation(type);
        GenerateEventsDocumentation(type);
    }

    private static void GeneratePropertiesDocumentation(Type type)
    {
        Console.WriteLine("Properties:");

        foreach(var property in type.GetProperties())
        {
            Console.WriteLine($"{property.Name} {property.PropertyType}");
        }
    }

    private static void GenerateMethodsDocumentation(Type type)
    {
        Console.WriteLine("Methods:");

        foreach(var method in type.GetMethods())
        {
            Console.WriteLine($"{method.Name} {method.ReturnType}");
        }
    }

    private static void GenerateEventsDocumentation(Type type)
    {
        Console.WriteLine("Events:");

        foreach(var @event  in type.GetEvents())
        {
            Console.WriteLine($"{@event.Name}");
        }
    }
}


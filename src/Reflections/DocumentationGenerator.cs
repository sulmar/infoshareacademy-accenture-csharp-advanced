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

        throw new NotImplementedException();
    }

    private static void GenerateMethodsDocumentation(Type type)
    {
        Console.WriteLine("Methods:");

        throw new NotImplementedException();
    }

    private static void GenerateEventsDocumentation(Type type)
    {
        Console.WriteLine("Events:");

        throw new NotImplementedException();
    }
}


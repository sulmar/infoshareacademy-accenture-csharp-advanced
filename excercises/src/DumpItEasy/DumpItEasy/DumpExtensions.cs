using System.IO.Pipes;

namespace DumpItEasy;

public static class DumpExtensions
{
    public static void Dump<T>(this T obj, IFormatter? formatter = null, Action<string>? outputAction = null)
    {
        formatter ??= new MarkdownFormatter();

        var defaultAction = (string value) => Console.WriteLine(value);

        outputAction ??= defaultAction;

        var properties = obj.GetPropertiesWithValues();

        formatter.AddHeader();
        foreach (var property in properties)
        {
            formatter.AddRow(property.Key, property.Value);
        }

        var formattedText = formatter.Build();

        outputAction(formattedText);
    }   
}


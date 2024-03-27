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

        var formattedText = formatter.Format(properties);

        outputAction(formattedText);
    }   
}


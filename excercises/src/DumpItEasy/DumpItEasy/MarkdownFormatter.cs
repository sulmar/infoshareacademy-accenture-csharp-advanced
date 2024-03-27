using System.Text;

namespace DumpItEasy;

// Concrete Builder
public class MarkdownFormatter : IFormatter
{
    private readonly StringBuilder builder = new();

    public IFormatter AddHeader()
    {
        // TODO: Add columns width
        builder.AppendLine("| Property Name | Value                |");
        builder.AppendLine("|---------------|----------------------|");

        return this;
    }

    public IFormatter AddRow(string propertyName, object value)
    {
        // TODO: Add columns width
        builder.AppendLine($"| {propertyName,-13} | {value,-20} |");
        return this;
    }

    public string Build() => builder.ToString();

   
}


namespace DumpItEasy;

public class MarkdownFormatter : IFormatter
{
    private readonly ITableBuilder tableBuilder = new MarkdownTableBuilder();

    public string Format(Dictionary<string, object> properties)
    {
        tableBuilder.AddHeader();

        foreach (var property in properties)
        {
            tableBuilder.AddRow(property.Key, property.Value);
        }

        return tableBuilder.Build();
    }
   
}


namespace DumpItEasy;

// Abstract Builder
public interface ITableBuilder
{
    ITableBuilder AddHeader();
    ITableBuilder AddRow(string propertyName, object value);
    string Build();
}


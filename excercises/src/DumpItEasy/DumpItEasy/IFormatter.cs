namespace DumpItEasy;

// Abstract Builder
public interface IFormatter
{
    IFormatter AddHeader();
    IFormatter AddRow(string propertyName, object value);
    string Build();
}


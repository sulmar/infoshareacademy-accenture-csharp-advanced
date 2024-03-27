namespace DumpItEasyTests;

public class CustomerFaker
{
    public static Customer Generate() => new(
          "John",
          "Smith",
          30,
          "john@example.com",
          "Dworcowa 1",
          "555-123-4567",
          new DateTime(2020, 01, 01));
}

using DumpItEasy;

namespace DumpItEasyTests;

public class MarkdownFormatterTests
{
    [Fact]
    public void Format_Valid_ShouldReturnMarkdownTable()
    {
        // Arrange
        IFormatter sut = new MarkdownFormatter();
        Customer customer = CustomerFaker.Generate();

        var properties = customer.GetPropertiesWithValues();

        // Act
        var result = sut.Format(properties);

        // Assert
        var expected = """
            | Property Name | Value       |
            |---------------|-------------|
            | FirstName     | John        |
            | LastName      | Smith       |
            | Age           | 30          |
            | Email         | john@example.com |
            | Address       | Dworcowa 1   |
            | Phone Number  | 555-123-4567 |
            | Member Since  | 2020-01-01   |
            """;

        Assert.Equal(expected, result);
    }

   
}

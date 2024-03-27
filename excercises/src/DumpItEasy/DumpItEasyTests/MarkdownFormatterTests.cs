using DumpItEasy;

namespace DumpItEasyTests;

public class MarkdownFormatterTests
{
    private IFormatter sut;

    public MarkdownFormatterTests()
    {
        // Arrange
        sut = new MarkdownFormatter();
    }

    [Fact]
    public void AddHeader_WhenCalled_ShouldReturnMarkdownRow()
    {
        // Act
        sut.AddHeader();
        var result = sut.Build();

        // Assert

        var expected = """
            | Property Name | Value       |
            |---------------|-------------|
            """;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void AddRow_Valid_ShouldReturnMarkdownRow()
    {
        // Act
        sut.AddRow("FirstName", "John");
        var result = sut.Build();

        // Assert
        var expected = """            
            | FirstName     | John        |            
            """;

        Assert.Equal(expected, result);
    }

   
}

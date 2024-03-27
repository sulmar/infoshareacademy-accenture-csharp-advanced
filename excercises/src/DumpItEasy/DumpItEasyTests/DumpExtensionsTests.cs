using DumpItEasy;

namespace DumpItEasyTests;

public class DumpExtensionsTests
{
    [Fact]
    public void Dump_WhenReferenceObject_ShouldReturnsMarkdown()
    {
        // Arrange
        Customer sut = CustomerFaker.Generate();

        // Act
        sut.Dump();

        // Assert
        Assert.Fail();
    }
}
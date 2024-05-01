using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using name_sorter;  

public class ReadNameTests
{
    [Fact]
    public void ReadNames_FileExists_ReturnsNames()
    {
        var mockFileReader = new Mock<IFileReader>();
        mockFileReader.Setup(m => m.ReadAllLines(It.IsAny<string>()))
            .Returns(new string[] { "John Doe", "Jane Smith" });

        var readName = new ReadName(mockFileReader.Object);

        var result = readName.ReadNames("dummy.txt");

        // Assert statement
        Assert.Contains("John Doe", result);
        Assert.Contains("Jane Smith", result);
    }
    [Fact]
    public void ReadNames_FileDoesNotExist_ReturnsEmptyList()
    {
        var mockFileReader = new Mock<IFileReader>();
        mockFileReader.Setup(m => m.ReadAllLines(It.IsAny<string>()))
            .Throws(new FileNotFoundException());

        var readName = new ReadName(mockFileReader.Object);

        var result = readName.ReadNames("nonexistent.txt");

        // Assert
        Assert.Empty(result);
    }
}
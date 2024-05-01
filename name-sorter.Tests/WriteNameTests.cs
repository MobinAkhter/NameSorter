using System.Collections.Generic;
using System.IO;
using Xunit;
using name_sorter;

public class WriteNameTests
{
    [Fact]
    public void WriteNames_GivenNames_WritesToFile()
    {
        var writer = new WriteName();
        var names = new List<string> { "John Doe", "Jane Smith" };
        var filePath = "sorted-names-list.txt";

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            writer.WriteNames(names, filePath);

            var expectedOutput = $"New txt file with sorted names is located at {Path.Combine(Directory.GetCurrentDirectory(), filePath)}\n";
            Assert.Equal(expectedOutput, sw.ToString());
        }
        
        Assert.True(File.Exists(filePath));
        File.Delete(filePath);
    }
}
using System.Collections.Generic;
using Xunit;
using name_sorter;

public class SortNameTests
{
    [Fact]
    public void SortNames_GivenUnsortedNames_ReturnsSortedNames()
    {
        var sorter = new SortName();
        var unsortedNames = new List<string> { "Zoe Bell", "Aaron Carter", "Bella Zoe" };

        var sortedNames = sorter.SortNames(unsortedNames);

        var expected = new List<string> { "Zoe Bell", "Aaron Carter", "Bella Zoe" };

        Assert.Equal(expected, sortedNames);
    }

    [Fact]
    public void SortNames_GivenEmptyList_ReturnsEmptyList()
    {
        var sorter = new SortName();
        var unsortedNames = new List<string>();

        var sortedNames = sorter.SortNames(unsortedNames);

        Assert.Empty(sortedNames);
    }
}
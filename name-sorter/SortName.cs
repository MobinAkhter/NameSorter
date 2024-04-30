namespace name_sorter;

/*
 * This class will take a list of names and then return a sorted list.
 */
public class SortName
{
    public List<string> SortNames(List<string> names)
    {
        var sortedNames = names
            .Select(fullName => new { FullName = fullName, Parts = fullName.Split(' ') })
            .OrderBy(person => person.Parts[^1])
            .ThenBy(person => person.Parts.Length > 2 ? person.Parts[1] : "")
            .ThenBy(person => person.Parts[0])
            .Select(person => person.FullName)
            .ToList();

        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }

        return sortedNames;
    }
}
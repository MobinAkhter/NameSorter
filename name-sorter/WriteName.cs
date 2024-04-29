namespace name_sorter;

/*
 * Write name to new txt file, and also to the output
 */
public class WriteName
{
    /*
     * Method for writing sorted names to a txt file called sorted-names-list.txt
     */
    public void WriteNames()
    {
        
        
    }
    
    /*
     * Display the names to the console
     */
    public void PrintNames(List<string> names)
    {
     foreach (var name in names)
     {
      Console.WriteLine(name);
     }
    }
}
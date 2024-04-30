namespace name_sorter;

/*
 * Write name to new txt file, and also to the output
 */
public class WriteName
{
    /*
     * Method for writing sorted names to a txt file called sorted-names-list.txt
     */
    public void WriteNames(List<string> names, string filePath)
    {
     try
     {
      var outputPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
      
      File.WriteAllLines(outputPath, names);
      Console.WriteLine($"New txt file with sorted names is located at {outputPath}");
     }
     catch (UnauthorizedAccessException uEx)
     {
      Console.WriteLine("Write operation unauthorized: " + uEx.Message);
     }
     catch (DirectoryNotFoundException dEx)
     {
      Console.WriteLine("Directory not found: " + dEx.Message);
     }
     catch (IOException ioEx)
     {
      Console.WriteLine("IO Exception: " + ioEx.Message);
     }
     catch (Exception ex)
     {
      Console.WriteLine("An unexpected error occurred: " + ex.Message);
     }
        
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
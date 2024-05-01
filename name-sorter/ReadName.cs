namespace name_sorter
{

/*
 * Purpose of this class is to read names from the txt file
 *
 */
    public class ReadName
    {
        private readonly IFileReader _fileReader;

        public ReadName(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public List<string> ReadNames(string filePath)
        {
            try
            {
                // Read all lines from file path
                var names = new List<string>(_fileReader.ReadAllLines(filePath));
                return names;
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not read the file: " + e);
                return new List<string>(); // instead of throwing an error, return an empty list
            }
        }
    }
}
namespace name_sorter
{
    public class FileReader : IFileReader
    {
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
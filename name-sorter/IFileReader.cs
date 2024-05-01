namespace name_sorter
{
    public interface IFileReader
    {
        string[] ReadAllLines(string path);
    }
}
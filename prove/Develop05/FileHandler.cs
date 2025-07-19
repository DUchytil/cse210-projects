using System.IO;
class FileHandler
{
    string _filename;
    public FileHandler(string filename)
    {
        _filename = filename;
    }

    public void SaveStringToFile(string content)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename, true)) // 'true' appends to the file
        {
            outputFile.WriteLine(content);
        }
    }

    public string[] ReadStringsFromFile()
    {
        return System.IO.File.ReadAllLines(_filename);
    }
}
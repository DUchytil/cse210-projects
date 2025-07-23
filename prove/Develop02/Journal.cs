class Journal
{
    List<JournalEntry> _entries = new List<JournalEntry>();

    public Journal()
    {
    }

    public void AddEntry()
    {
        JournalEntry entry = new JournalEntry();
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void LoadEntries(string filename)
    {
        if (!File.Exists(filename)) // Check if the file exists
        {
            Console.WriteLine($"File {filename} does not exist.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            JournalEntry entry = new JournalEntry(parts[0], parts[1], parts[2]);
            _entries.Add(entry);

        }
    }

    public void SaveEntries(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.PackageForSaving());
            }
        }
    }
}
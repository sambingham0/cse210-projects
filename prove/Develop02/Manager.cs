public class JournalManager
{
    public List<JournalEntry> _entries = new List<JournalEntry>();
    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
   public void DisplayJournal()
   {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
   }
   public void SaveToFile(string fileName)
   {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date} - {entry._mood} - {entry._prompt}: {entry._response}");
            }
        }

        Console.WriteLine($"Journal saved to {fileName}");
    }
   public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Assuming the format is "Date - Prompt: Response"
                    string[] parts = line.Split(new[] { " - ", ": " }, StringSplitOptions.None);

                    if (parts.Length == 4)
                    {
                        JournalEntry loadedEntry = new JournalEntry
                        {
                            _date = parts[0],
                            _mood = parts[1],
                            _prompt = parts[2],
                            _response = parts[3]
                        };

                        _entries.Add(loadedEntry);
                    }
                }
            }

        Console.WriteLine($"Journal loaded from {fileName}");
        }
        else
        {
            Console.WriteLine("File not found. Unable to load journal.");
        }
    }
}
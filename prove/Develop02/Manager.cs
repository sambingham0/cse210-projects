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
        // save to file
        Console.WriteLine($"Journal saved to {fileName}");
   }
   public void LoadFromFile(string fileName)
    {
        // loading from file
        Console.WriteLine($"Journal loaded from {fileName}");
    }
}
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public string _scripture = "Proverbs 3:5-6";
    public Reference(string reference)
    {
        string[] parts = reference.Split(":");
        string[] bookParts = parts[0].Split(" ");
        string[] verseParts = parts[1].Split("-");
        _book = bookParts[0];
        _chapter = int.Parse(bookParts[1]);

        if (verseParts.Length > 1)
        {
            _startVerse = int.Parse(verseParts[0]);
            _endVerse = int.Parse(verseParts[1]);
        }
        else
        {
            // If there's no range, the start and end verses are the same
            _startVerse = int.Parse(verseParts[0]);
            _endVerse = _startVerse;
        }
    }

}
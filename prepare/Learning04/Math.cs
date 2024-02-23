public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;
    public Math(string section, string problems, string name, string topic) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
        Assignment assignment = new Assignment(name, topic);
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
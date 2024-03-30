public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        _comments.Add(comment);
    }

    public int NumComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length (seconds): " + _length);
        Console.WriteLine("Number of comments: " + NumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(" - " + comment._commenter + ": " + comment._text);
        }
        Console.WriteLine();
    }
}
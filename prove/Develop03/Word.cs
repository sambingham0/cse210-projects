public class Word
{
    public string _text;
    public bool _hidden;
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }

}
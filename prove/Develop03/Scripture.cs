public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference._scripture);
        foreach (Word word in _words)
        {
            Console.Write(word._hidden ? "____ " : $"{word._text} ");
        }
        Console.WriteLine("\n");
    }

    public void HideWords(int numWordsToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numWordsToHide; i++)
        {
            int indexToHide = rand.Next(0, _words.Count); // Randomly select index of word to hide
            if (!_words[indexToHide]._hidden)
            {
                _words[indexToHide].Hide();
            }
            else
            {
                i--;
            }
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word._hidden)
            {
                return false;
            }
        }
        return true;
    }
}
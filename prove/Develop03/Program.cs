using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.Write("Select difficulty level (how many words will hide at once):");
        string difficulty = Console.ReadLine();
        int difficultyint = int.Parse(difficulty);
        Reference reference = new Reference("Proverbs 3:5-6");
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);
        scripture.Display();
        
        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input == "quit")
                return;
            scripture.HideWords(difficultyint);
            Console.Clear();
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Scripture memorization completed.");
                return;
            }
        }
    }
}
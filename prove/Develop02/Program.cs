using System;
//Attributes should be _camelCase and methods and classes should be PascalCase.
class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        JournalManager journalManager = new JournalManager();
        Console.WriteLine("Welcome to the Journal Program!");

        while (!exit)
        {
            Console.WriteLine("Select one of the following choices: ");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    string randomPrompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    JournalEntry newEntry = new JournalEntry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _prompt = randomPrompt,
                        _response = response
                    };
                    journalManager.AddEntry(newEntry);
                    break;
                case "2":
                    journalManager.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journalManager.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journalManager.LoadFromFile(loadFileName);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
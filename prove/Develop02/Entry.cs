using System;

public class JournalEntry
{
    public string _date;
    public string _prompt;

    public string _response;
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }
}
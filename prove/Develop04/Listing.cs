using System.Diagnostics;
public class Listing : Mindfulness
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _duration;
    private string _prompt;
    public Listing(int duration, string greeting, string exit) : base(greeting, exit)
    {
        _duration = duration;
    }
    public void List()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Random random = new Random();
        _prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine($" ---{_prompt}--- ");
        Console.WriteLine("You may begin in: ");
        WaitTime(5);

        int items = 0;
        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items++;
        }
        Console.WriteLine($"You listed {items} items!");
    }
}
public class Reflection : Mindfulness
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int _duration;
    private string _prompt;
    private string _question;
    public Reflection(int duration, string greeting, string exit) : base(greeting, exit)
    {
        _duration = duration;
    }
    public void Reflect()
    {
        Random random = new Random();
        _prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($" ---{_prompt}--- ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions: ");
        Console.WriteLine("You may begin in: ");
        WaitTime(5);
        int _totalTime = 0;
        while (_totalTime < _duration)
        {
            _question = _questions[random.Next(_questions.Length)];
            Console.WriteLine($"{_question} ");
            int remainingTime = _duration - _totalTime;
            int displayTime = Math.Min(remainingTime, 15); // Display for remaining time or up to 15 seconds
            LoadingIcon(displayTime); // Display loading icon for remaining or up to 15 seconds
            _totalTime += displayTime;    
        }
    }

}
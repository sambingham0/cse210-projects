public class Mindfulness
{
    private List<string> animations = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\"};
    private string _greeting;
    private string _exit;
    public Mindfulness(string greeting, string exit)
    {
        _greeting = greeting;
        _exit = exit;
    }
    public void WaitTime(int wait)
    {
        for (int i = wait; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void LoadingIcon(int duration)
    {
        duration *=2;
        int index = 0;
        for (int a = 0; a < duration; a++)
        {
            Console.Write(animations[index]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index = (index + 1) % animations.Count;
        }
    }
    public void Greeting()
    {
        Console.WriteLine(_greeting);
        Console.WriteLine("Prepare to begin...");
        LoadingIcon(5);
    }
    public void Exit()
    {
        Console.WriteLine(_exit);
        Console.WriteLine("Well done!");
        LoadingIcon(3);
    }
}
public class Mindfulness
{
    public void waitTime(int wait)
    {
        for (int i = wait; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void greeting(string greeting)
    {
        Console.WriteLine(greeting);
        Console.WriteLine("Prepare to begin...");
        waitTime(5);
    }
}
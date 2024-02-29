public class Breathing : Mindfulness
{
    private int _duration;
    private int _intervals;
    private int _remaining;
    public Breathing(int duration)
    {
        _duration = duration;
        _intervals = _duration / 9;
        _remaining = _duration % 9;
    }
    public void breathe()
    {
        for (int i = 0; i < _intervals; i++)
        {
            BreatheIn();
            BreatheOut();
        }

        if (_remaining <= 4)
        {
            Console.WriteLine("Breathe in...");
            waitTime(_remaining);
        }

        else
        {
            Console.WriteLine("Breathe in...");
            waitTime(4);
            Console.WriteLine("Breathe out...");
            waitTime(_remaining - 4);
        }
        Console.WriteLine("You did it!");
    }
    private void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
        waitTime(4);
    }
    private void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        waitTime(5);
    }

}

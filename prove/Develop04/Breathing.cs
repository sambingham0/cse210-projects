public class Breathing : Mindfulness
{
    private int _duration;
    private int _intervals;
    private int _remaining;
    public Breathing(int duration, string greeting, string exit) : base(greeting, exit)
    {
        _duration = duration;
        //9 because 4 seconds in, 5 seconds out for a 9 second interval
        _intervals = _duration / 9;
        _remaining = _duration % 9;
    }
    public void Breathe()
    {
        for (int i = 0; i < _intervals; i++)
        {
            BreatheIn();
            BreatheOut();
        }

        if (_remaining <= 4)
        {
            Console.WriteLine("Breathe in...");
            WaitTime(_remaining);
        }

        else
        {
            Console.WriteLine("Breathe in...");
            WaitTime(4);
            Console.WriteLine("Breathe out...");
            WaitTime(_remaining - 4);
        }
    }
    //methods for breath periods
    private void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
        WaitTime(4);
    }
    private void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        WaitTime(5);
    }

}

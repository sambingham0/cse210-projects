public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance(); // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Laps: {_laps}, Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
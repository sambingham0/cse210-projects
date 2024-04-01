public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in miles per hour
    }

    public override double GetDistance()
    {
        double hours = _lengthInMinutes / 60.0; // Convert minutes to hours
        return _speed * hours; // Distance = Speed * Time
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        return $"{base.GetSummary()} - Distance: {distance} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}
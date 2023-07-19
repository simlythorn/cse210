using System;
public class Runing : Activity
{
    private double _distance;
    public Runing(string date, int lengthInMins, double distance) : base(date, lengthInMins)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _lengthInMins) * 60;
    }

    public override double GetPace()
    {
        return _lengthInMins/_distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_lengthInMins} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
using System;
public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int lengthInMins, double speed) : base(date, lengthInMins)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * 60) / _lengthInMins;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/_speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_lengthInMins} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
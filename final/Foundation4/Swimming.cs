using System;
public class Swimming : Activity
{
    private int _numLap;
    public Swimming(string date, int lengthInMins, int numLap) : base(date, lengthInMins)
    {
        _numLap = numLap;
    }
    public override double GetDistance()
    {
        return _numLap * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_lengthInMins) * 60;
    }

    public override double GetPace()
    {
        return _lengthInMins / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_lengthInMins} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
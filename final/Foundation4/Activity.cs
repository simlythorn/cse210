using System;
public abstract class Activity
{
    public string _date;
    public int _lengthInMins;
    public Activity(string date, int lengthInMins)
    {
        _date = date;
        _lengthInMins = lengthInMins;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} ({_lengthInMins}min)- Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}
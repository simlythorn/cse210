using System;


public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        IsComplete();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string completionIndicator = IsComplete() ? "[X]" : "[ ]";
        return $"{completionIndicator} {_shortName} ({_description})";
    }
}
using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string completionIndicator = IsComplete() ? "[X]" : "[ ]";
        return $"{completionIndicator} {_shortName} ({_description})";
    }
}
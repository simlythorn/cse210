using System;
public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        string completionIndicator = IsComplete() ? "[X]" : "[ ]";
        return $"{completionIndicator} {_shortName} ({_description}) — Currently completed: {_amountCompleted}/{_target}";
    }


    
}


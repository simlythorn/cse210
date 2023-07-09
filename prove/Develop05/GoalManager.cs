using System;
using System.Collections.Generic;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public int GetScore()
    {
        return _score;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(shortName, description, points, false));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetStringRepresentation()}");
            i++;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal._shortName}");
            i++;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Goal accomplishedGoal = _goals[goalIndex];
        accomplishedGoal.RecordEvent();
        if (accomplishedGoal.IsComplete() || accomplishedGoal is EternalGoal || accomplishedGoal is ChecklistGoal)
        {
            _score += accomplishedGoal._points;
            Console.WriteLine($"Congratulations! You earned {accomplishedGoal._points} points!");
            Console.WriteLine($"You now have {_score} points.");
            if (accomplishedGoal is ChecklistGoal checklistGoal)
            {
                if (checklistGoal._amountCompleted % checklistGoal._target == 0)
                {
                    _score += checklistGoal._bonus;
                    Console.WriteLine($"Congratulations! You earned a bonus of {checklistGoal._bonus} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
            }
        }
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                string goalTypeName = goal.GetType().Name;
                writer.Write(goalTypeName);
                writer.Write(",");
                writer.Write(goal._shortName);
                writer.Write(",");
                writer.Write(goal._description);
                writer.Write(",");
                writer.Write(goal._points);
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.Write(",");
                    writer.Write(simpleGoal.IsComplete());
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    // No additional information to write
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.Write(",");
                    writer.Write(checklistGoal._target);
                    writer.Write(",");
                    writer.Write(checklistGoal._bonus);
                }
                writer.WriteLine();
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string goalTypeName = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                if (goalTypeName == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(shortName, description, points, isComplete));
                }
                else if (goalTypeName == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(shortName, description, points));
                }
                else if (goalTypeName == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                }
            }
        }
        Console.WriteLine("Loaded goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }


}
        


    

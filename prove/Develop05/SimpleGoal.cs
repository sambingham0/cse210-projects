using System;

public class SimpleGoal : Goal
{
    private bool _completed = false;
    public override string GetCompletionStatus()
    {
        return _completed ? "[X]" : "[ ]";
    }
    public override void RecordEvent(string goalName)
    {
        if (_name == goalName)
        {
            _completed = true;
            Program._points += _pointValue;
            Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");
        }
    }
    public override void SaveToFile(string fileName, Goal goal)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            if (goal is SimpleGoal simpleGoal)
            {
                writer.WriteLine($"SimpleGoal,{simpleGoal._name},{simpleGoal._description},{simpleGoal._pointValue},{simpleGoal._completed}");
            }
        }
    }
    public SimpleGoal LoadFromFileSimple(string fileName, string[] parts)
    {
        SimpleGoal loadedSimple = new SimpleGoal
        {
            _name = parts[1],
            _description = parts[2],
            _pointValue = int.Parse(parts[3]),
            _completed = bool.Parse(parts[4]),
        };
        Console.WriteLine($"Journal loaded from {fileName}");
        return loadedSimple;
    }
}
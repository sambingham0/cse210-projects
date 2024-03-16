using System;

public class EternalGoal : Goal
{
    public override string GetCompletionStatus()
    {
        return "[ ]"; // Eternal goals always show [ ]
    }
    public override void RecordEvent(string goalName)
    {
        if (_name == goalName)
        {
            Program._points += _pointValue;
            Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");
        }
    }
    public override void SaveToFile(string fileName, Goal goal)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            if (goal is EternalGoal eternalGoal)
            {
                writer.WriteLine($"EternalGoal,{eternalGoal._name},{eternalGoal._description},{eternalGoal._pointValue}");
            }
        }
    }
    public EternalGoal LoadFromFileEternal(string fileName, string[] parts)
    {
        EternalGoal loadedEternal = new EternalGoal
        {
            _name = parts[1],
            _description = parts[2],
            _pointValue = int.Parse(parts[3]),            
        };
        Console.WriteLine($"Journal loaded from {fileName}");
        return loadedEternal;
    }
}
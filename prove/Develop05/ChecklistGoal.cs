using System;

public class ChecklistGoal : Goal
{
    public int _timesForBonus;
    private int _bonusPoints;
    public int _completed = 0;
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _timesForBonus = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override string GetCompletionStatus()
    {
        return _completed >= _timesForBonus ? "[X]" : "[ ]";
    }
    public override void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal && checklistGoal._name == goalName)
            {
                var checkedGoal = (ChecklistGoal)goal;
                checkedGoal._completed++;
                Program._points += checkedGoal.PointValue;
                Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");


                if (checklistGoal._completed == checklistGoal._timesForBonus)
                {
                    Program._points += _bonusPoints;
                    Console.WriteLine($"Congratulations! You have earned {_bonusPoints} points!");
                }
                break; // Exit the loop once the goal is found and processed
            }
        }
    }
    public override void SaveToFile(string fileName, Goal goal)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                writer.WriteLine($"ChecklistGoal,{checklistGoal._name},{checklistGoal._description},{checklistGoal._pointValue},{checklistGoal._timesForBonus},{checklistGoal._bonusPoints},{checklistGoal._completed}");
            }
        }
    }
    public ChecklistGoal LoadFromFileChecklist(string fileName, string[] parts)
    {
        ChecklistGoal loadedChecklist = new ChecklistGoal
        {
            _name = parts[1],
            _description = parts[2],
            _pointValue = int.Parse(parts[3]),
            _timesForBonus = int.Parse(parts[4]),
            _bonusPoints = int.Parse(parts[5]),
            _completed = int.Parse(parts[6]),
        };
        Console.WriteLine($"Journal loaded from {fileName}");
        return loadedChecklist;
    }
}
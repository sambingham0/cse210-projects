using System;
using System.Collections.Generic;

public abstract class Goal
{
    public static List<Goal> _goals = new List<Goal>();
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int PointValue => _pointValue;
    public string Name => _name;
    public virtual void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public static void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public virtual string GetCompletionStatus()
    {
        // Default implementation returns empty string
        return "[ ]";
    }
    public static void DisplayGoals()
    {
        int goalCount = 1;
        foreach (var goal in _goals)
        {
            Console.Write($"\n{goalCount}. {goal.GetCompletionStatus()} {goal.Name} ({goal._description})");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($" -- Currently Completed: {checklistGoal._completed}/{checklistGoal._timesForBonus}");
            }
            goalCount++;
        }
    }
    public abstract void RecordEvent(string goalName);
    public abstract void SaveToFile(string fileName, Goal goal);
    public static void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            SimpleGoal simple = new SimpleGoal();
            EternalGoal eternal = new EternalGoal();
            ChecklistGoal checklist = new ChecklistGoal();

            _goals.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] parts = line.Split(',');

                    if (parts[0] == "SimpleGoal")
                    {
                        _goals.Add(simple.LoadFromFileSimple(fileName, parts));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        _goals.Add(eternal.LoadFromFileEternal(fileName, parts));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        _goals.Add(checklist.LoadFromFileChecklist(fileName, parts));
                    }
                    else
                    {
                        Console.WriteLine("Invalid File Format");
                    }
                }
            }
        }
    }
}
using System;

class Program
{
    public static int _points = 0;
    private static bool _exit = false;
    static void Main(string[] args)
    {
        while (!_exit)
        {
            Console.WriteLine($"\n\nYou have {_points} points. \n");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int _choice = int.Parse(Console.ReadLine());

            switch (_choice)
            {
                case 1:
                    Console.WriteLine("\nThe types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    int _createGoalChoice = int.Parse(Console.ReadLine());

                    switch (_createGoalChoice)
                    {
                        case 1:
                            SimpleGoal simple = new SimpleGoal();
                            simple.CreateGoal();
                            Goal.AddGoal(simple);
                            break;
                        case 2:
                            EternalGoal eternal = new EternalGoal();
                            eternal.CreateGoal();
                            Goal.AddGoal(eternal);
                            break;
                        case 3:
                            ChecklistGoal checklist = new ChecklistGoal();
                            checklist.CreateGoal();
                            Goal.AddGoal(checklist);
                            break;
                    }
                    break;
                case 2:
                    Goal.DisplayGoals();
                    break;
                case 3:
                    Console.Write("Enter file name to save: ");
                    string saveFileName = Console.ReadLine();
                    // Iterate over each goal and save it to file
                    using (StreamWriter writer = new StreamWriter(saveFileName, false))
                    {
                        writer.Write(string.Empty);
                    }
                    foreach (var goal in Goal._goals)
                    {
                        goal.SaveToFile(saveFileName, goal);
                    }
                    break;
                case 4:
                    Console.Write("Enter file name to load: ");
                    string loadFileName = Console.ReadLine();
                    Goal.LoadFromFile(loadFileName);
                    break;
                case 5:
                    Console.Write("Enter the name of the goal completed: ");
                    string goalName = Console.ReadLine();
                    bool goalFound = false;
                    foreach (var goal in Goal._goals)
                    {
                        if (goal.Name == goalName)
                        {
                            goal.RecordEvent(goalName);
                            goalFound = true;
                            break;
                        }
                    }
                    if (!goalFound)
                    {
                        Console.WriteLine($"Goal with name '{goalName}' not found.");
                    }
                    break;
                case 6:
                    _exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
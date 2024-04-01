using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2022, 11, 4), 40, 15.0);
        Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 5), 45, 20);

        // Put activities in a list
        Activity[] activities = {runningActivity, cyclingActivity, swimmingActivity};

        // Display summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
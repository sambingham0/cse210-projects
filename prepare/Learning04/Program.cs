using System;

class Program
{
    static void Main(string[] args)
    {
        Math math = new Math("7.3", "8-19", "Sam Bingham", "Multiplication");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
    }
}
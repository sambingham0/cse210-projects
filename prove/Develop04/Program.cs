using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nBreathing Activity");
                    Console.Write("Enter duration in seconds: ");
                    int breathingDuration = Convert.ToInt32(Console.ReadLine());
                    Breathing breathing = new Breathing(breathingDuration);
                    breathing.greeting("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.breathe();

                    break;
                case "2":
                    Console.WriteLine("\nReflection Activity");
                    Console.Write("Enter duration in seconds: ");
                    int reflectionDuration = Convert.ToInt32(Console.ReadLine());
                    Reflection reflection = new Reflection();
                    break;
                case "3":
                    Console.WriteLine("\nListing Activity");
                    break;
                case "4":
                    Console.WriteLine("\nExiting Program...");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
}
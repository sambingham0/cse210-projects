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
                    //breathing
                    Console.WriteLine("\nBreathing Activity");
                    Console.Write("Enter duration in seconds: ");
                    int breathingDuration = Convert.ToInt32(Console.ReadLine());
                    Breathing breathing = new Breathing(breathingDuration, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "You have completed the Breathing Exercise.");
                    breathing.Greeting();
                    breathing.Breathe();
                    breathing.Exit();
                    break;
                case "2":
                    //reflection
                    Console.WriteLine("\nReflection Activity");
                    Console.Write("Enter duration in seconds: ");
                    int reflectionDuration = Convert.ToInt32(Console.ReadLine());
                    Reflection reflection = new Reflection(reflectionDuration, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "You have completed the Reflection Activity.");
                    reflection.Greeting();
                    reflection.Reflect();
                    reflection.Exit();
                    break;
                case "3":
                    //listing
                    Console.WriteLine("\nListing Activity");
                    Console.Write("Enter duration in seconds: ");
                    int listingDuration = Convert.ToInt32(Console.ReadLine());
                    Listing listing = new Listing(listingDuration, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "You have completed the Listing Activity.");
                    listing.Greeting();
                    listing.List();
                    listing.Exit();
                    break;
                case "4":
                //quit
                    Console.WriteLine("\nExiting Program...");
                    return;
                default:
                    //input error
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
}
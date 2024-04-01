using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Paris", "France");
        Address address2 = new Address("456 Elm St", "Los Angeles", "USA");
        Address address3 = new Address("789 Oak St", "London", "UK");

        // Create events
        Lecture lecture1 = new Lecture("Lecture on Polar Bears", "Learn about how cool Polar Bears are!", DateTime.Now.AddDays(20), address2, "Stanley Hudson", 5000);
        Reception reception1 = new Reception("Wedding Reception", "Come to my wedding reception please", DateTime.Now.AddDays(15), address3, "sam@gmail.com");
        OutdoorGathering gathering1 = new OutdoorGathering("Summer Picnic", "Enjoy a picnic in the park", DateTime.Now.AddDays(30), address2, "Sunny");

        // Display marketing messages for each event
        Console.WriteLine("Lecture: ");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception: ");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering: ");
        Console.WriteLine(gathering1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(gathering1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(gathering1.GetShortDescription());
    }
}
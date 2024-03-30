using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Paris", "Lle-de", "France");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Widget", "W123", 10.00, 2);
        Product product2 = new Product("Gadget", "G456", 15.00, 3);
        Product product3 = new Product("Thingamajig", "T789", 20.00, 5);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        Console.WriteLine("Order 1:\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2:\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order2.CalculateTotalCost());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello! Welcome to the 'Encapsulation with Online Ordering' final program.\n");

        List<Product> products = new List<Product>();

        Address address = new Address("123 Main St.", "Rexburg,", "ID", "USA");
        Customer customer = new Customer("The Karate Kid", address);
        Order order1 = new(customer);
        order1.GetShippingLabel();
        order1.AddProduct();
        order1.AddProduct();
        Console.WriteLine($"\nYour total is ${order1.CalculateTotal()}");
        order1.GetPackingLabel();

        Console.WriteLine("\nThank You for your order!\n\n");

        Order order2 = new(new Customer("Sally Thomson", new Address("111 N. Park Ave.", "Hollywood,", "Quebec", "Canada")));
        order2.GetShippingLabel();
        order2.AddProduct();
        Console.WriteLine($"\nYour total is ${order2.CalculateTotal()}");
        order2.GetPackingLabel();

        Console.WriteLine("\nThank You for your order!\n\n");

        /*Address address3 = new Address("1415 N. Celebrity Drive", "Nashville,", "Tennesee", "USA");
        Customer customer3 = new Customer("Dolly Parton", address3);
        Order order3 = new(customer3);*/
        Order order3 = new(new Customer("Dolly Parton", new Address("1415 N. Celebrity Drive", "Nashville,", "Tennesee", "USA")));
        order3.GetShippingLabel();
        order3.AddProduct();
        Console.WriteLine($"\nYour total is ${order3.CalculateTotal()}");
        order3.GetPackingLabel();

        Console.WriteLine("\nThank You for your order!\n\n");

    }
}
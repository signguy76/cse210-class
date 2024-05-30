using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Widget", "W123", 10.0, 2);
        Product product2 = new Product("Gadget", "G456", 20.0, 1);
        Product product3 = new Product("Thingamajig", "T789", 5.0, 5);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    private static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(new string('*', 10));
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 20));
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Product product1 = new Product("Laptop", "1234", 1000, 1);
        Product product2 = new Product("Headphones", "5678", 100, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Cost:");
        Console.WriteLine("$" + order1.CalculateTotalCost());

        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Product product3 = new Product("Monitor", "9876", 200, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Cost:");
        Console.WriteLine("$" + order2.CalculateTotalCost());
    }
}
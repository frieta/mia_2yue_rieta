using System;

class Program
{
    static void Main()
    {
        // first order - customer from the philippines 🇵🇭
        Address address1 = new Address("123 Rizal St", "Manila", "Metro Manila", "Philippines");
        Customer customer1 = new Customer("Juan Dela Cruz", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 1200m, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25m, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: Php" + (order1.GetTotalPrice()*55)); // using Php as peso symbol

        Console.WriteLine();

        // second order - customer from the usa 🇺🇸
        Address address2 = new Address("456 Main St", "Los Angeles", "California", "USA");
        Customer customer2 = new Customer("John Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KBD789", 50m, 1));
        order2.AddProduct(new Product("Monitor", "MON321", 200m, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}

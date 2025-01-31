using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak Ave", "Springfield", "IL", "USA");
        Address address3 = new Address("789 Pine Ln", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Joseph Peralta", address1);
        Customer customer2 = new Customer("Karen Seron", address2);
        Customer customer3 = new Customer("Maria Calixtro", address3);

        // Create products
        Product product1 = new Product("Laptop", "P001", 1200, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        Product product3 = new Product("Keyboard", "P003", 75, 3);
        Product product4 = new Product("Monitor", "P004", 300, 2);
        Product product5 = new Product("Webcam", "P005", 50, 4);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine($"Shipping Label: \n{order1.GetCustomerName()} \n{order1.GetShippingLabel()}");
        Console.WriteLine("\nTotal Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label: \n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order2.GetCustomerName()} \n{order2.GetShippingLabel()}");
        Console.WriteLine("\nTotal Cost: $" + order2.CalculateTotalCost());

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "P001", 999.99, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Address address2 = new Address("456 Oak St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product3 = new Product("Phone", "P003", 799.99, 1);
        Product product4 = new Product("Charger", "P004", 19.99, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }

    
}
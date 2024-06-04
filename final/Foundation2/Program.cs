using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address _address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer _customer1 = new Customer("John Doe", _address1);

        Product _product1 = new Product("Laptop", "P001", 999.99, 1);
        Product _product2 = new Product("Mouse", "P002", 25.50, 2);

        Order _order1 = new Order(_customer1);
        _order1.AddProduct(_product1);
        _order1.AddProduct(_product2);

        Console.WriteLine(_order1.GetPackingLabel());
        Console.WriteLine(_order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${_order1.CalculateTotalCost():0.00}\n");

        Address _address2 = new Address("456 Oak St", "Othertown", "ON", "Canada");
        Customer _customer2 = new Customer("Jane Smith", _address2);

        Product _product3 = new Product("Phone", "P003", 799.99, 1);
        Product _product4 = new Product("Charger", "P004", 19.99, 3);

        Order _order2 = new Order(_customer2);
        _order2.AddProduct(_product3);
        _order2.AddProduct(_product4);

        Console.WriteLine(_order2.GetPackingLabel());
        Console.WriteLine(_order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${_order2.CalculateTotalCost():0.00}");
    }

    
}
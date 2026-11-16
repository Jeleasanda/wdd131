using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        usaOrder.AddProduct(new Product("Mouse", "P002", 25.50, 2));

        DisplayOrder(usaOrder);

        Address internationalAddress = new Address("456 High St", "London", "England", "UK");
        Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(new Product("Keyboard", "P003", 75.00, 1));
        internationalOrder.AddProduct(new Product("Monitor", "P004", 200.00, 1));

        DisplayOrder(internationalOrder);
    }

    private static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();
    }
}

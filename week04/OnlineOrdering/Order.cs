using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private readonly List<Product> _products = new List<Product>();
    private readonly Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
    }

    public void AddProduct(Product product)
    {
        _products.Add(product ?? throw new ArgumentNullException(nameof(product)));
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total + (_customer.LivesInUSA() ? 5m : 35m);
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("PACKING LABEL:");
        foreach (Product product in _products)
        {
            label.AppendLine();
            label.Append($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}

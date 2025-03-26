using System;
using System.Collections.Generic;


/// handles an order containing multiple products

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // adds a new product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // calculates the total price including shipping cost
    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost(); // add up product costs
        }
        total += _customer.IsInUSA() ? 5 : 35; // shipping cost is 5 if usa, 35 otherwise
        return total;
    }

    // creates a packing label listing all products
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    // creates a shipping label with the customer's details
    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}

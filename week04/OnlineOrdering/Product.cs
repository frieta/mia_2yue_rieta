using System;

// represents a product that can be ordered
public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // calculates total cost of this product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // returns a simple packing label with product name and id
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}

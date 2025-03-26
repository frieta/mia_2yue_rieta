using System;

// represents a customer placing an order
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // asks the address object if this customer is in the usa
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // returns a shipping label with the customer's name and full address
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}

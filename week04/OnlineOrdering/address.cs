using System;

// holds all the details about a customer's address
public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    // checks if the customer is from the usa
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA"; 
    }

    // returns the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
}

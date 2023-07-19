using System;

public class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _zipcode;
    public Address(string street, string city, string state, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }
}


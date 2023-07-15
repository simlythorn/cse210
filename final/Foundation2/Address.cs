using System;
public class Address
{
    public string _streetAddress;
    public string _city;
    public string _stateProvince;
    public string _country;
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUsa()
    {
        return _country.ToLower() == "usa";
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}");
        Console.WriteLine($"{_stateProvince}");
        Console.WriteLine($"{_country}");
    }
}
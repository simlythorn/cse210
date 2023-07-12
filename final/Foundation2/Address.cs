using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
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
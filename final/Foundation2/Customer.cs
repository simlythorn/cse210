using System;
public class Customer
{
    public string _customerName;
    public Address _address;
    public Customer( string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

}
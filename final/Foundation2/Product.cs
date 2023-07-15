using System;
public class Product
{
    public string _productName;
    public string _productId;
    private double _price;
    private int _quantity;
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}
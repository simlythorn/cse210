using System;
public class Order
{
    private List<Product> _products;
    private Customer _customers;
    public Order(List<Product> products, Customer customers)
    {
        _products = products;
        _customers = customers;
    }

    public double GetTotalCost()
    {
        
    }

    public string GetPackingLabel()
    {
        
    }

    public string GetShippingLabel()
    {
        
    }
}
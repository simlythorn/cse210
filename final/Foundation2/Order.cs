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
        double totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }
        double shippingCost;
        if (_customers.IsInUsa())
        {
            shippingCost = 5;
        }
        else 
        {
            shippingCost = 35;
        }
        return totalCost + shippingCost;
        
    }

    public string GetPackingLabel()
    {
        string packinglabel = " ";
        foreach(Product product in _products)
        {
            packinglabel = $"  Product Name: {product._productName}\n  Product ID: {product._productId}";
        }
        return packinglabel;
    }

    public string GetShippingLabel()
    {
        string shippinglabel;
        shippinglabel = $"  Customer Name: {_customers._customerName}\n";
        shippinglabel += $"  Customer Address: {_customers._address._streetAddress}, {_customers._address._city}, {_customers._address._stateProvince}, {_customers._address._country}";
        return shippinglabel;
    }
}
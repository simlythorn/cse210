using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Simly Store");
        Console.WriteLine(" ");
        List<Order> orders = new List<Order>();
        Console.Write("Enter the number of order: ");
        int numOrder = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOrder; i++)
        {
            Console.WriteLine($"\n--Detail about the order {i + 1}--");
            Console.WriteLine(" ");
            Console.Write("Street Address: ");
            string stAddress = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Sate or Province: ");
            string stateProvince = Console.ReadLine();
            Console.Write("Country: ");
            string country = Console.ReadLine();
            Console.Write("Customer Name: ");
            string customerName = Console.ReadLine();

            Address address = new Address (stAddress, city, stateProvince, country);
            Customer customer = new Customer(customerName, address);

            List<Product> products = new List<Product>();
            Console.Write("Enter the number of product for this order: ");
            int numProduct = int.Parse(Console.ReadLine());

            for(int j = 0; j < numProduct; j++)
            {
                Console.WriteLine($"\nPRODUCT {j + 1}");
                Console.WriteLine(" ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product ID: ");
                string productID = Console.ReadLine();
                Console.Write("Price in USD($): ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity of the product: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName,productID, price, quantity);
                products.Add(product);

                Order order = new Order(products, customer);
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine($"Total cost: ${order.GetTotalCost():0.00}");

            }
        }
    
    }
}
public class Order 
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice();
        }
        return totalCost + GetShippingCost();
    }
    public double GetShippingCost()
    {
        if (_customer.IsCountryUSA())
        {
            return 5; // $5 shipping cost for USA customers
        }
        else
        {
            return 35; // $35 shipping cost for non-USA customers
        }
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Order Details");
        Console.WriteLine();
        Console.WriteLine("Products:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()}.{product.GetName()}........${product.GetPrice():0.00}");
        }
        Console.WriteLine($"Total Cost: ${CalculateTotalCost():0.00}");

    }
    public void GetShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("Customer Details:");
        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.WriteLine($"Shipping Address:\n{_customer.GetAdress()}");
    }
}
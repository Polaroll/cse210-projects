public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product> {};

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateCost()
    {
        double total = 0;
        foreach (Product item in _products)
        {
            total += item.ComputePrice();
        }
        if (_customer.InUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public void Display()
    {
        Console.WriteLine("Shipping Label:");
        _customer.Display();
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            product.Display();
        }
        Console.WriteLine();
        Console.WriteLine($"Total Price: {CalculateCost()}");
    }
}
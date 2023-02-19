public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product (string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double ComputePrice()
    {
        return _price * _quantity;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} : {_id}");
    }
}
public class Event
{
    private string _type;
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DispStandardDets()
    {
        Console.WriteLine();
        Console.WriteLine($"What: {_title}");
        Console.WriteLine(_desc);
        Console.WriteLine($"When: {_date} at {_time}");
        Console.WriteLine($"Where: {_address}");
    }
     public void DispFullDets()
    {
        Console.WriteLine();
        Console.WriteLine($"What: {_title}");
        Console.WriteLine(_desc);
        Console.WriteLine($"When: {_date} at {_time}");
        Console.Write($"Where: ");
        _address.Display();
    }
    public void DispShortDets()
    {
        Console.WriteLine();
        Console.WriteLine($"{_type}:");
        Console.WriteLine($"What: {_title}");
        Console.WriteLine($"When: {_date}");
    }
    public void SetType(string type)
    {
        _type = type;
    }
}
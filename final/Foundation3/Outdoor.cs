public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, Address address, string weather)
        : base (title, desc, date, time, address)
    {
        base.SetType("Outdoor Event");
        _weather = weather;
    }
    
    public void DispFullDets()
    {
        base.DispFullDets();
        Console.WriteLine($"Weather: {_weather}");
    }
}
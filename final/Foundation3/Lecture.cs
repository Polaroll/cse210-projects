public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, Address address, string speaker, int capacity)
        : base (title, desc, date, time, address)
    {
        base.SetType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DispFullDets()
    {
        base.DispFullDets();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Max Capacity: {_capacity}");
    }
}
public class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email)
        : base (title, desc, date, time, address)
    {
        base.SetType("Reception");
        _email = email;
    }

    public void DispFullDets()
    {
        base.DispFullDets();
        Console.WriteLine($"RSVP to: {_email}");
    }
}
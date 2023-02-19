using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("101 Wizard Way", "Hogwarts", "Idaho", "USA");
        Lecture l1 = new Lecture("Psychology", "A class for Psychology majors", "Feb 18, 2023", "10:15 AM", a1, "John Williams", 135);
        Reception r1 = new Reception("Sarah's Reception", "Come celebrate Sarah's reception!", "Feb 18, 2023", "7:00 PM", a1, "sarah.j@gmail.com");
        Outdoor o1 = new Outdoor("Fair", "It's the state fair!", "Feb 18, 2023", "12:00 PM", a1, "Sunny");

        l1.DispStandardDets();
        l1.DispFullDets();
        l1.DispShortDets();

        r1.DispStandardDets();
        r1.DispFullDets();
        r1.DispShortDets();

        o1.DispStandardDets();
        o1.DispFullDets();
        o1.DispShortDets();
    }
}
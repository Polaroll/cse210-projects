using System;

class Program
{
    static void Main(string[] args)
    {
        Running r1 = new Running("Feb 18 2023", 30, "Running", 2.4);
        Cycling c1 = new Cycling("Feb 18 2023", 120, "Cycling", 16);
        Swimming s1 = new Swimming("Feb 18 2023", 60, "Swimming", 50);

        List<Exercise> list = new List<Exercise> {r1, c1, s1};
        foreach (Exercise exercise in list)
        {
            exercise.DisplaySummary();
        }
    }
}
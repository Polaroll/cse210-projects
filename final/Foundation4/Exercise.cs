public abstract class Exercise
{
    private string _date;
    private double _length;
    private string _exercise;

    public Exercise(string date, double length, string exercise)
    {
        _date = date;
        _length = length;
        _exercise = exercise;
    }

    public abstract double CalculateDist();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} {_exercise} ({_length}) - Distance {CalculateDist()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
    }
    public double GetLength()
    {
        return _length;
    }

}
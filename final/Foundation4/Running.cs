public class Running : Exercise
{
    private double _distance;

    public Running(string date, double length, string exercise, double distance)
        : base(date, length, exercise)
    {
        _distance = distance;
    }

    public override double CalculateDist()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (_distance / GetLength()) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = GetLength() / _distance;
        return pace;
    }
}
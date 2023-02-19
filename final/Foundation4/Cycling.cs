public class Cycling : Exercise
{
    // Speed is mph
    private double _speed;

    public Cycling(string date, double length, string exercise, double speed)
        : base(date, length, exercise)
    {
        _speed = speed;;
    }

    public override double CalculateDist()
    {
        double distance = _speed * (GetLength() / 60);
        return distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}
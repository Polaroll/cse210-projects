public class Swimming : Exercise
{
    private double _numLaps;

    public Swimming(string date, double length, string exercise, double numLaps)
        : base(date, length, exercise)
    {
        _numLaps = numLaps;
    }

    public override double CalculateDist()
    {
        double distance = _numLaps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = ((_numLaps * 50 / 1000 * 0.62) / GetLength()) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = GetLength() / (_numLaps * 50 / 1000 * 0.62);
        return pace;
    }
}
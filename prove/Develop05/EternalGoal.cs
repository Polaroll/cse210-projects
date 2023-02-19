public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string name, string desc, int pointValue, bool complete)
        : base (goalType, name, desc, pointValue, complete){}

    public override void RecordEvent()
    {
        // Will not set as complete because they are eternal goals
    }

    public override int CalculatePoints()
    {
        return GetPointValue();
    }

}
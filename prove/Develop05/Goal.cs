public abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _desc;
    private int _pointValue;
    private bool _complete;

    public Goal(string goalType, string name, string desc, int pointValue, bool complete)
    {
        _goalType = goalType;
        _name = name;
        _desc = desc;
        _pointValue = pointValue;
        _complete = complete;
    }

    public virtual int CalculatePoints()
    {
        if (_complete == true)
        {
            return _pointValue;
        }
        else
        {
            return 0;
        }
    }
    public virtual bool IsComplete()
    {
        return _complete;
    }
    public void Setcomplete(bool complete)
    {
        _complete = complete;
    }
    public virtual void RecordEvent()
    {
        _complete = true;
    }
    public string LoadGoals()
    {
        string goals = "";
        return goals;
    }
    public string GetType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDesc()
    {
        return _desc;
    }
    public virtual int GetNumItems()
    {
        return 0;
    }
    public virtual int GetItemsCompleted()
    {
        return 0;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

}
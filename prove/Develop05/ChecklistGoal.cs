public class ChecklistGoal : Goal
{
    private int _numItems;
    private int _itemsCompleted;
    private int _bonusValue;
    public ChecklistGoal(string goalType, string name, string desc, int pointValue, bool complete, int numItems, int itemsCompleted, int bonusValue)
        : base (goalType, name, desc, pointValue, complete)
    {
        _numItems = numItems;
        _itemsCompleted = itemsCompleted;
        _bonusValue = bonusValue;
    }

    public override int GetNumItems()
    {
        return _numItems;
    }
    public override int GetItemsCompleted()
    {
        return _itemsCompleted;
    }
    public override void RecordEvent()
    {
        if (_itemsCompleted < _numItems)
        {
            _itemsCompleted++;
            if (_itemsCompleted == _numItems)
            {
                Setcomplete(true);
            }
        }
    }
    public override int CalculatePoints()
    {
        if (_itemsCompleted < _numItems)
        {
            return GetPointValue();
        }
        else
        {
            return GetPointValue() + _bonusValue;
        }
    }
}
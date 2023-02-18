public class Activity
{
    protected string _activityName;
    private string _startMsg;
    private string _endMsg;
    private int _duration;
    private int _breathingLog = 0;
    private int _reflectingLog = 0;
    private int _listeningLog = 0;

    public Activity(){}
    public Activity(string activityName, string startMsg)
    {
        _activityName = activityName;
        _startMsg = startMsg;
        _endMsg = "Well done!!";
    }

    public void DisplayStartMsg()
    {
        Console.WriteLine(_startMsg);
    }
    public void DisplayEndMsg()
    {
        Console.WriteLine(_endMsg);
        SpinnerPause();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of {_activityName}");
        SpinnerPause();
    }
    public void SpinnerPause()
    {
        // Initiates a 5 second pause
        for (int i = 0; i < 10; i++)
        {
            
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }
    public void CountdownPause(int pauseDuration)
    {
        for (int i = 0; i < pauseDuration; i++)
        {
            Console.Write(pauseDuration - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetEndMsg()
    {
        return _endMsg;
    }
    public void IncrementBreathingLog()
    {
        _breathingLog++;
    }
     public int GetBreathingLog()
    {
        return _breathingLog;
    }
    public void IncrementReflectingLog()
    {
        _reflectingLog++;
    }
    public int GetReflectingLog()
    {
        return _reflectingLog;
    }
    public void IncrementListeningLog()
    {
        _listeningLog++; 
    }
    public int GetListeningLog()
    {
        return _listeningLog;
    }
   
}
public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string startMsg)
        : base (activityName, startMsg){}

    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine("");
        DisplayStartMsg();
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        int dur = int.Parse(durationString);
        SetDuration(dur);
        Console.Clear();

        Console.WriteLine("Get ready...");
        SpinnerPause();

        while (dur > 0)
        {
            
            Console.WriteLine($"Duration = {dur}");
            if (dur < 5 && dur > 0)
            {
                Console.WriteLine("");
                Console.Write("Breath in... ");
                CountdownPause(5 - dur);
               
            }
            else if (dur < 0)
            {
                Console.WriteLine("");
                Console.Write("Breath in... ");
                CountdownPause(5 + dur);
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Breath in... ");
                CountdownPause(5);
            }
            dur = dur - 5;
            if (dur < 5 && dur > 0)
            {
                Console.WriteLine("");
                Console.Write("Breath out... ");
                CountdownPause(5 - dur);
            }
            else if (dur < 0)
            {
                Console.WriteLine("");
                Console.Write("Breath in... ");
                CountdownPause(5 + dur);
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Breath out... ");
                CountdownPause(5);
            }
            dur = dur - 5;
            Console.WriteLine("");
            Console.WriteLine("");
        }

        DisplayEndMsg();

    }
}
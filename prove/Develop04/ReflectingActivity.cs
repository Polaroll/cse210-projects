public class ReflectingActivity : Activity
{
    private string[] _initialPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _followUpPrompts = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string activityName, string startMsg)
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

        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        Random rnd = new Random();
        int num = rnd.Next(4);
        string prompt = _initialPrompts[num];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following quesstions as they relate to this experience.");
        CountdownPause(7);

        Console.Clear();

        while (dur > 0)
        {
            num = rnd.Next(9);
            prompt = _followUpPrompts[num];
            Console.Write($"> {prompt}");
            SpinnerPause();
            SpinnerPause();
            Console.WriteLine("");
            dur = dur - 10;
        }
        
        Console.WriteLine("");
        DisplayEndMsg();
    }
}
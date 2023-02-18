public class ListeningActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity(string activityName, string startMsg)
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
        Console.WriteLine("List as many responses as you can to the following prompt:");
       
        Random rnd = new Random();
        int num = rnd.Next(5);
        string prompt = _prompts[num];
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        CountdownPause(7);
        Console.WriteLine("");
        

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(dur);

        int items = 0;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            items++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {items} item(s)");

        Console.WriteLine("");
        DisplayEndMsg();
    }
}
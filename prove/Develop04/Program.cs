using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act = new Activity();

        string breathingActDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string reflectionActDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listeningActDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        bool menu = true;

        while (menu == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choise from the menu: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BreathingActivity actB = new BreathingActivity("Breathing Activity", breathingActDesc);
                    act.IncrementBreathingLog();
                    actB.RunActivity();
                    break;
                case "2":
                    ReflectingActivity actR = new ReflectingActivity("Reflecting Activity", reflectionActDesc);
                    act.IncrementReflectingLog();
                    actR.RunActivity();
                    break;
                case "3":
                    ListeningActivity actL = new ListeningActivity("Listening Activity", listeningActDesc);
                    act.IncrementListeningLog();
                    actL.RunActivity();
                    break;
                case "4":
                    menu = false;
                    Console.WriteLine("");
                    int breathLog = act.GetBreathingLog();
                    int reflectLog = act.GetReflectingLog();
                    int listenLog = act.GetListeningLog();
                    Console.WriteLine("Activities performed:");
                    Console.WriteLine($"    Breathing Activity: {breathLog}");
                    Console.WriteLine($"    Reflecting Activity: {reflectLog}");
                    Console.WriteLine($"    Listening Activity: {listenLog}");
                    break;
            }

        }


    }
}
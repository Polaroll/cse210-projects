using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int totalPoints = 0;
        bool menu = true;

        List<Goal> goals = new List<Goal> {};

        while (menu == true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");

                    Console.WriteLine();
                    Console.Write("What type of goal would you like to create: ");
                    string goalType = Console.ReadLine();
                    Console.Write("Name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Short description of your goal: ");
                    string desc = Console.ReadLine();
                    Console.Write("Amount of points associated with this goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case "1":
                            goalType = "simple";
                            SimpleGoal sg = new SimpleGoal(goalType, name, desc, pointValue, false);
                            goals.Add(sg);
                            break;
                        case "2":
                            goalType = "eternal";
                            EternalGoal eg = new EternalGoal(goalType, name, desc, pointValue, false);
                            goals.Add(eg);
                            break;
                        case "3":
                            goalType = "checklist";
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int numItems = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonusValue = int.Parse(Console.ReadLine());
                            ChecklistGoal cg = new ChecklistGoal(goalType, name, desc, pointValue, false, numItems, 0, bonusValue);
                            goals.Add(cg);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("the goals are:");
                    int i = 1;
                    foreach (Goal goal in goals)
                    {
                        string type = goal.GetType();
                        string goalName = goal.GetName();
                        string goalDesc = goal.GetDesc();
                        string x = " ";
                        if (goal.IsComplete() == true)
                        {
                            x = "x";
                        }
                        Console.Write($"{i}. [{x}] {goalName} ({goalDesc}) ");
                        if (type == "checklist")
                        {
                            int numItems = goal.GetNumItems();
                            int itemsCompleted = goal.GetItemsCompleted();
                            Console.Write($"-- Currently completed: {itemsCompleted}/{numItems}");
                        }
                        i++;
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    string[] saveGoals = {};
                    Console.WriteLine();
                    Console.WriteLine("This has not been implemented yet. Sorry!");

                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("This has not been implemented yet. Sorry!");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine("The goals are:");
                    int ind = 1;
                    foreach (Goal goal in goals)
                    {
                        string gName = goal.GetName();
                        Console.WriteLine($"{ind}. {gName}");
                        ind++;
                    }
                    Console.WriteLine();
                    Console.Write("Which goal did you accomplish? ");
                    int gIndex = int.Parse(Console.ReadLine()) - 1;
                    int index = 0;
                    int points = 0;
                    foreach (Goal goal in goals)
                    {
                        if (index == gIndex)
                        {
                            goal.RecordEvent();
                            points = goal.CalculatePoints();
                        }
                        index++;
                    }
                    Console.WriteLine();
                    if (points > 0)
                    {
                    Console.WriteLine($"Congratulations! You have earned {points} points.");
                    totalPoints += points;
                    Console.WriteLine($"You now have {points} points.");
                    }
                    break;
                case "6":
                    menu = false;
                    break;
            }
        }
    }
}
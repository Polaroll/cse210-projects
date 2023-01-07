using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade (%): ");
        string percent = Console.ReadLine();
        int gradePercent = int.Parse(percent);

        string gradeLetter = "";

        if (gradePercent >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }


        Console.WriteLine($"Your grade was {gradeLetter}.");
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("So close! Try again.");
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            return number;
        }

        static int SquareNumber(int number)
        {
            int sqaurenumber = number * number;
            return sqaurenumber;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int intGuess = 0;
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            intGuess = int.Parse(guess);

            if (intGuess < number)
            {
                Console.WriteLine("Too low!");
            }
            else if (intGuess > number)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }

        } while (intGuess != number);
    }
}
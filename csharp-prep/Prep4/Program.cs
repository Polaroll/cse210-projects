using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        do
        {
        Console.Write("Enter number: ");
        string stringNumber = Console.ReadLine();
        number = int.Parse(stringNumber);
        if (number != 0)
        {
            numbers.Add(number);
        }
        } while (number != 0);

        int sum = 0;
        int max = -999999999;
        foreach (int listNumber in numbers)
        {
            sum = sum + listNumber;
            if (listNumber > max)
            {
                max = listNumber;
            }
        }
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
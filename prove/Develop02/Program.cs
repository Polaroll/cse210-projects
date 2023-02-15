using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";
        Journal journal1 = new Journal();
        while (input != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            input = Console.ReadLine();
            Console.WriteLine("");
            switch(input)
            {
                case "1":
                    journal1.Write();
                    break;
                case "2":
                    journal1.Display();
                    break;
                case "3":
                    Console.Write("File name: ");
                    string fileName = Console.ReadLine();
                    journal1.SaveToFile(fileName);
                    break;
                case "4":
                    Console.Write("File name: ");
                    string fileName1 = Console.ReadLine();
                    journal1.LoadFromFile(fileName1);
                    break;
            }
        }
    }
}
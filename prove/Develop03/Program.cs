using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        scripture1.SetText(
        @"For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the understanding; for he speaketh unto men according to their language, unto their understanding.");

        Reference reference1 = new Reference("2 Nephi", "31", "3");

        string[] text = scripture1.SplitText();
        foreach (string word in text)
        {
            Word word1 = new Word(word);
            scripture1.AddWords(word1);
        }

        string usrInput = "go";
        while (scripture1.IsCompletelyHidden() == false && usrInput != "quit")
        {
            scripture1.IsCompletelyHidden();
            Console.Clear();
            scripture1.DisplayScripture(reference1.GetReference()); 
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            usrInput = Console.ReadLine();

            scripture1.HideWords();
        }

        Console.Clear();
        scripture1.DisplayScripture(reference1.GetReference()); 
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
        usrInput = Console.ReadLine();

    }
}
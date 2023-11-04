using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();

        // Create a Scripture object with reference and text.
        var scripture = new Scripture("John 3:16", "For God so loved the world...");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.HideRandomWord();
            DisplayScripture(scripture);
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"{scripture.Reference.Book} {scripture.Reference.Chapter}:{scripture.Reference.StartVerse}-{scripture.Reference.EndVerse}");
        foreach (var word in scripture.Words)
        {
            if (word.Hidden)
                Console.Write("____ ");
            else
                Console.Write(word.Word + " ");
        }
        Console.WriteLine();
    }
}

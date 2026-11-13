using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me")
        };

        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        string userInput = "";

        while (!string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase) && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to finish:");

            userInput = Console.ReadLine() ?? "";

            if (!string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
            {
                currentScripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
    }
}

// EXCEEDING REQUIREMENTS: I added a random scripture library. Instead of just one scripture, 
// the program selects a random scripture from a list of three every time it runs. 
// I also ensured the HideRandomWords method only selects words that are currently visible, 
// so the user doesn't waste a turn hiding a word that is already hidden.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: A library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me")
        };

        // Select a random scripture
        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue, or type 'quit' to finish:");
            
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                // Hide 3 words at a time
                currentScripture.HideRandomWords(3);
            }
        }

        // Final display when all words are hidden or user quits
        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
    }
}
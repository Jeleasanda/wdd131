using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What am I most grateful for right now?"
        };

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompts[Random.Shared.Next(prompts.Count)]
                    };

                    Console.WriteLine(newEntry._promptText);
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine() ?? "";

                    Console.Write("How are you feeling right now? (e.g., Happy, Tired, Motivated): ");
                    newEntry._mood = Console.ReadLine() ?? "";

                    myJournal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(saveFilename))
                    {
                        myJournal.SaveToFile(saveFilename);
                    }
                    else
                    {
                        Console.WriteLine("Filename cannot be blank.\n");
                    }
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(loadFilename))
                    {
                        myJournal.LoadFromFile(loadFilename);
                    }
                    else
                    {
                        Console.WriteLine("Filename cannot be blank.\n");
                    }
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please enter a number from 1 to 5.\n");
                    break;
            }
        }
    }
}

// EXCEEDING REQUIREMENTS: I added a "Mood Tracker" feature. When writing an entry, the user is prompted to record their current mood (e.g., Happy, Sad, Stressed), which is then saved to the file and displayed with the entry.

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
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();

                Random random = new Random();
                int index = random.Next(prompts.Count);
                newEntry._promptText = prompts[index];

                Console.WriteLine(newEntry._promptText);
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                Console.Write("How are you feeling right now? (e.g., Happy, Tired, Motivated): ");
                newEntry._mood = Console.ReadLine();

                myJournal.AddEntry(newEntry);
                Console.WriteLine(); // Empty line for readability
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
        }
    }
}

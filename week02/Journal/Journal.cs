using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        if (newEntry != null)
        {
            _entries.Add(newEntry);
        }
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        if (string.IsNullOrWhiteSpace(file))
        {
            Console.WriteLine("Filename cannot be blank.\n");
            return;
        }

        try
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(
                        $"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
                }
            }

            Console.WriteLine("Journal saved successfully.\n");
        }
        catch (IOException)
        {
            Console.WriteLine("The journal could not be saved because of a file error.\n");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to save to that file.\n");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter a valid filename.\n");
        }
    }

    public void LoadFromFile(string file)
    {
        if (string.IsNullOrWhiteSpace(file))
        {
            Console.WriteLine("Filename cannot be blank.\n");
            return;
        }

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(file);
            List<Entry> loadedEntries = new List<Entry>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(
                    new[] { "~|~" },
                    StringSplitOptions.None);

                if (parts.Length == 4)
                {
                    Entry loadedEntry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2],
                        _mood = parts[3]
                    };

                    loadedEntries.Add(loadedEntry);
                }
            }

            _entries = loadedEntries;
            Console.WriteLine("Journal loaded successfully.\n");
        }
        catch (IOException)
        {
            Console.WriteLine("The journal could not be loaded because of a file error.\n");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to read that file.\n");
        }
    }
}

using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    // NEW: Added a mood tracker to exceed requirements
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}\n");
    }
}

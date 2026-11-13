using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split the text into words and create Word objects
        string[] wordsArray = text.Split(' ');
        foreach (string w in wordsArray)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // This loop ensures we only hide words that are currently visible
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
            
            // Safety check: if all words are hidden, break out
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        
        foreach (Word word in _words)
        {
            display += word.GetRenderedText() + " ";
        }
        
        return display.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found a word that is not hidden
            }
        }
        return true; // All words are hidden
    }
}
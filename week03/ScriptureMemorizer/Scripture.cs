using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0 || _words.Count == 0)
        {
            return;
        }

        Random random = new Random();
        int hiddenCount = 0;
        List<int> availableIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndexes.Add(i);
            }
        }

        while (hiddenCount < numberToHide && availableIndexes.Count > 0)
        {
            int index = random.Next(availableIndexes.Count);
            int wordIndex = availableIndexes[index];
            availableIndexes.RemoveAt(index);

            if (!_words[wordIndex].IsHidden())
            {
                _words[wordIndex].Hide();
                hiddenCount++;
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
                return false;
            }
        }

        return true;
    }
}

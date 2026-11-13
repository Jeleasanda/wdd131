using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            // Create a string of underscores the same length as the word
            string underscores = "";
            for (int i = 0; i < _text.Length; i++)
            {
                underscores += "_";
            }
            return underscores;
        }
        else
        {
            return _text;
        }
    }
}
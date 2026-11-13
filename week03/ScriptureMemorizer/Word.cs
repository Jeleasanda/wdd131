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
        if (!_isHidden)
        {
            return _text;
        }

        char[] characters = _text.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetterOrDigit(characters[i]))
            {
                characters[i] = '_';
            }
        }

        return new string(characters);
    }
}

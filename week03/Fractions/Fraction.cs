using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor: 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with top only: 5/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with top and bottom
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _top = top;
        _bottom = bottom;

        // Keep fraction sign consistent
        if (_bottom < 0)
        {
            _top *= -1;
            _bottom *= -1;
        }
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _bottom = bottom;

        if (_bottom < 0)
        {
            _top *= -1;
            _bottom *= -1;
        }
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}

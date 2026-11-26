using System;

public abstract class Shape
{
    // Private member variable for encapsulation
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method to be overridden by derived classes
    public abstract double GetArea();
}

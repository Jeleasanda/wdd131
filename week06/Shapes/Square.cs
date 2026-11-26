using System;

public class Square : Shape
{
    private double _side;

    // Constructor passes color to base class
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Overriding the abstract method
    public override double GetArea()
    {
        return _side * _side;
    }
}

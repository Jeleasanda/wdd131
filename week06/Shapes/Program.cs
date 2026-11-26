using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes (Polymorphism in action)
        List<Shape> shapes = new List<Shape>();

        // Add a square, rectangle, and circle
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through the list and display color and area
        foreach (Shape s in shapes)
        {
            // We don't need to know if it's a square or circle to call GetArea()
            // The program figures it out at runtime (Polymorphism)
            Console.WriteLine($"Shape Color: {s.GetColor()}");
            Console.WriteLine($"Shape Area: {s.GetArea():F2}");
            Console.WriteLine("-------------------------");
        }
    }
}

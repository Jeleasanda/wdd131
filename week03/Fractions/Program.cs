using System;

class Program
{
    static void Main(string[] args)
    {
        // Test 1: Default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine($"Default: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        // Test 2: One parameter constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"One parameter: {f2.GetFractionString()} = {f2.GetDecimalValue()}");

        // Test 3: Two parameter constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Two parameters: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

        // Test 4: Another fraction
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Another fraction: {f4.GetFractionString()} = {f4.GetDecimalValue()}");

        // Bonus: using setters
        f1.SetTop(6);
        f1.SetBottom(7);

        Console.WriteLine($"After setters: {f1.GetFractionString()} = {f1.GetDecimalValue()}");
    }
}

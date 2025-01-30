using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructors
        Fraction fraction1 = new Fraction();      // 1/1
        Fraction fraction2 = new Fraction(5);     // 5/1
        Fraction fraction3 = new Fraction(3, 4);  // 3/4
        Fraction fraction4 = new Fraction(1, 3);  // 1/3

        // Test getters and setters
        fraction1.SetTop(2);
        fraction1.SetBottom(3);
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}"); // 2/3
        Console.WriteLine($"Decimal Value: {fraction1.GetDecimalValue()}"); // ~0.6667

        // Display fractions and their decimal values
        DisplayFraction(fraction1);
        DisplayFraction(fraction2);
        DisplayFraction(fraction3);
        DisplayFraction(fraction4);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}
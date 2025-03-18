using System;

class Program
{
    static void Main(string[] args)
    {
        // making a fraction with the default constructor (should be 1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); 
        Console.WriteLine(f1.GetDecimalValue());   

        // making a fraction with just a whole number (should be 5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); 
        Console.WriteLine(f2.GetDecimalValue());   

        // making a fraction with numerator and denominator (should be 3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); 
        Console.WriteLine(f3.GetDecimalValue());   

        // another fraction (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString()); 
        Console.WriteLine(f4.GetDecimalValue());   

        // changing values of f1, let’s mess with it a bit
        f1.SetTop(2); // changing numerator to 2
        f1.SetBottom(5); // changing denominator to 5 (hope this works lol)

        // printing updated fraction
        Console.WriteLine(f1.GetFractionString()); 
        Console.WriteLine(f1.GetDecimalValue());   
    }
}

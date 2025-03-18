using System;

public class Fraction
{
    // private variables for numerator (top) and denominator (bottom)
    private int _top;
    private int _bottom;

    // constructor with no parameters, sets fraction to 1/1 by default
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // constructor with one parameter, assumes denominator is 1 (example: 5 → 5/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // constructor with two parameters for numerator and denominator
    public Fraction(int top, int bottom)
    {
        if (bottom == 0) // gotta prevent divide by zero, that woud be bad
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _top = top;
        _bottom = bottom;
    }

    // getter for the numerator (top part of the fraction)
    public int GetTop()
    {
        return _top;
    }

    // getter for the denominator (bottom part of the fraction)
    public int GetBottom()
    {
        return _bottom;
    }

    // setter for the numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // setter for the denominator, make sure it’s not zero cuz that breaks math
    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _bottom = bottom;
    }

    // returns the fraction as a string like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}

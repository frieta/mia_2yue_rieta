using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // start by making a list of shapes
        List<Shape> shapes = new List<Shape>();

        // add one of each type to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // loop through the shapes and show their color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine(); // just for spacing
        }
    }
}

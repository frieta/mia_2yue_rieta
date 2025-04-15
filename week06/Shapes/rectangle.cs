// rectangle has both length and width and inherits from shape
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // constructor that sets color, length, and width
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // override the abstract method to return area of a rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}

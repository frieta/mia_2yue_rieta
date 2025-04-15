// square inherits from shape and adds a side length
public class Square : Shape
{
    private double _side;

    // constructor that sets color and side length
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // override the abstract method to return area of a square
    public override double GetArea()
    {
        return _side * _side;
    }
}

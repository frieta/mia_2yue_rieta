// circle has a radius and also inherits from shape
public class Circle : Shape
{
    private double _radius;

    // constructor that sets color and radius
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // override the abstract method to return area of a circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

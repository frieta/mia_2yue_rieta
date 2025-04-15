public abstract class Shape
{
    private string _color;

    // constructor to set the color of the shape
    public Shape(string color)
    {
        _color = color;
    }

    // getter for color
    public string GetColor()
    {
        return _color;
    }

    // setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // this is an abstract method, so derived classes must override it
    public abstract double GetArea();
}

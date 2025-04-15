public class Cycling : Activity
{
    // for biking, we just save their average speed (in kph)
    private double _speed;

    // pass in date, time, and their biking speed
    public Cycling(string date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    // return speed directly
    public override double GetSpeed() => _speed;

    // we calculate distance using speed × time
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    // pace is 60 divided by speed
    public override double GetPace()
    {
        return 60 / _speed;
    }
}

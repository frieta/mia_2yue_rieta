public class Running : Activity
{
    // we store how far the person ran (in km)
    private double _distance;

    // we set up the object using base for shared stuff, and distance for running
    public Running(string date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    // just return the distance they ran
    public override double GetDistance() => _distance;

    // speed is calculated by (distance / time) * 60 to get kph
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // pace is just how many minutes it takes to go 1 km
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}

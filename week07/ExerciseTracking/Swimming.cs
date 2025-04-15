public class Swimming : Activity
{
    // number of laps swum (each lap = 50 meters)
    private int _laps;

    // pass in date, time, and lap count
    public Swimming(string date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    // convert laps to km: laps × 50m / 1000
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    // speed = distance per hour
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // pace = minutes per km
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}

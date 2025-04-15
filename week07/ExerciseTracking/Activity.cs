public abstract class Activity
{
    // this stores the date the activity happened
    private string _date;

    // this stores how long the activity lasted (in minutes)
    private int _lengthMinutes;

    // constructor to initialize the date and length
    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    // getter for the date
    public string GetDate() => _date;

    // getter for the minutes
    public int GetMinutes() => _lengthMinutes;

    // these methods are like "placeholders"—each activity will do these differently
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // this method puts together all the info into one nice sentence
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthMinutes} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}

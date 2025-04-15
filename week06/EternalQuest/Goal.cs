using System; 

public abstract class Goal // define the goal class 
{
    protected string _name; // name of the goal, private to this class 
    protected string _description; // goal description, private as well 
    protected int _points; // the points gained when completed, private for encapsulation 
    
    public Goal(string name, string description, int points) // constructor to set up goal 
    {
        _name = name; // sets goal's name 
        _description = description; // sets goal's description 
        _points = points; // sets points for the goal 
    }

    public string GetName() // gets the goal's name 
    {
        return _name; // returns name 
    }

    public string GetDescription() // gets the goal's description 
    {
        return _description; // returns description 
    }

    public int GetPoints() // gets the goal's points 
    {
        return _points; // returns points 
    }

    public abstract void RecordEvent(); // each type of goal must implement this event 
    public abstract string GetDetailsString(); // returns a summary of the goal details 
}

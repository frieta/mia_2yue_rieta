using System;

public class EternalGoal : Goal // another type of goal, this one is never "done" 
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) // constructor 
    {
    }

    public override void RecordEvent() // every time you record an event, you get points 
    {
        Console.WriteLine($"You gained {GetPoints()} points for '{GetName()}'. Keep going!"); // gives points each time 
    }

    public override string GetDetailsString() // eternal goals don’t get marked off, but you get points 
    {
        return $"{GetName()} - {GetDescription()} - Points per event: {GetPoints()} - Ongoing goal "; // indicates ongoing goal 
    }
}

using System;

public class SimpleGoal : Goal // inherit from the Goal class
{
    private bool _isComplete; // whether the goal is complete or not 

    public SimpleGoal(string name, string description, int points) : base(name, description, points) // constructor from Goal 
    {
        _isComplete = false; // starts off as incomplete 
    }

    public override void RecordEvent() // marks the goal as complete 
    {
        _isComplete = true; // marks as complete when recorded 
        Console.WriteLine($"Goal '{GetName()}' completed! You earned {GetPoints()} points!"); // informs user 
    }

    public override string GetDetailsString() // returns the goal details in a readable format 
    {
        return $"{GetName()} - {GetDescription()} - Points: {GetPoints()} - Completed: {_isComplete}"; // includes completion status 
    }
}

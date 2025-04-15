using System; 

public class ChecklistGoal : Goal // this type of goal needs to be completed multiple times
{
    private int _timesCompleted; // counts how many times the goal has been recorded
    private int _target; // how many times to record the event for completion
    private int _bonusPoints; // points awarded for completing the checklist goal

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints) : base(name, description, points) // constructor
    {
        _timesCompleted = 0; // starts off as 0 
        _target = target; // sets the target number of completions 
        _bonusPoints = bonusPoints; // sets the bonus points for completing the goal 
    }

    public override void RecordEvent() // each time the user marks off an event 
    {
        _timesCompleted++; // adds one more to completion count 
        int totalPoints = GetPoints(); // normal points for the event 

        if (_timesCompleted == _target) // if they reach the goal, give bonus 
        {
            totalPoints += _bonusPoints; // add bonus points 🎉
            Console.WriteLine($"Goal '{GetName()}' completed! Bonus points awarded: {_bonusPoints}!"); // bonus message 
        }

        Console.WriteLine($"You gained {totalPoints} points for '{GetName()}'. Completed {_timesCompleted}/{_target} times."); // progress update 
    }

    public override string GetDetailsString() // show the goal progress 
    {
        return $"{GetName()} - {GetDescription()} - Points per event: {GetPoints()} - Completed: {_timesCompleted}/{_target}"; // shows target completion 
    }
}

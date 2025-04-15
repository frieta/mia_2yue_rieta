using System; 
using System.Collections.Generic;
using System.IO; 

public class GoalManager // this class manages all the goals in the system 
{
    private List<Goal> _goals; // list of all goals the user has 
    private int _totalPoints; // keeps track of total score 

    public GoalManager() // constructor to initialize the list 
    {
        _goals = new List<Goal>(); // initializes the list of goals
        _totalPoints = 0; // score starts at 0
    }

    public void CreateGoal() // creates a new goal based on user input
    {
        // logic to create a new goal.
    }

    public void DisplayGoals() // displays all goals
    {
        // loop through and display each goal's details.
    }

    public void SaveGoals() // saves the goals to a file
    {
        // logic to save goals to a file
    }

    public void LoadGoals() // loads goals from a file
    {
        // logic to load goals from a file
    }

    public void RecordEvent() // records a goal being completed or progressed
    {
        // logic for recording an event
    }
}

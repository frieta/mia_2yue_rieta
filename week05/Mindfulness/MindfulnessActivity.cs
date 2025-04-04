using System;
using System.Threading;

// base class for all mindfulness activities
abstract class MindfulnessActivity
{
    protected string Name; // name of the activity
    protected string Description; // description of the activity
    protected int Duration; // duration of the activity in seconds

    // constructor initializes the name and description for the activity
    protected MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    // starts the activity and asks for duration
    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {Name}..."); // display activity name
        Console.WriteLine(Description); // show activity description
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine()); // get duration from user
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3); // wait for a moment before starting
    }

    // ends the activity and displays results
    public void EndActivity()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"You completed {Name} for {Duration} seconds.");
        PauseWithAnimation(3); // pause before finishing
    }

    // simple countdown animation to show a delay
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...\r"); // show countdown
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    // abstract method to be implemented by derived classes
    public abstract void PerformActivity();
}

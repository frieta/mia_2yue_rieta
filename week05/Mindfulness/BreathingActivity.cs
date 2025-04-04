using System;
using System.Threading;

// breathing exercise to guide the user in deep breathing
class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("breathing exercise", "this activity helps you relax through deep breathing.") {}

    public override void PerformActivity()
    {
        StartActivity();  // start the activity and show instructions

        int remainingTime = Duration;  // set the remaining time to the total duration
        int totalBreaths = Duration / 6;  // number of breath cycles (breathe in + breathe out)

        for (int i = 0; i < totalBreaths; i++) // loop to match total duration
        {
            // breathing in phase with countdown
            Console.WriteLine("breathe in deeply...");
            CountdownAnimation(3, ref remainingTime);  // countdown during "breathe in" phase and update remaining time
            Console.WriteLine("now breathe out slowly...");
            CountdownAnimation(3, ref remainingTime);  // countdown during "breathe out" phase and update remaining time
        }

        EndActivity();  // end the activity and show completion message
    }

    // countdown animation that shows remaining seconds for each phase and total remaining time
    private void CountdownAnimation(int seconds, ref int remainingTime)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");  // display countdown for each breath phase
            Thread.Sleep(1000);  // wait for 1 second
            remainingTime--;  // decrease remaining time by 1 second after each countdown step
            Console.Write($"remaining time: {remainingTime} seconds\n");  // display remaining total time
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // here we’re making a list to hold all our activities
        List<Activity> activities = new List<Activity>()
        {
            // creating a running activity
            new Running("15 April 2025", 60, 4.0),

            // creating a cycling activity
            new Cycling("15 April 2025", 30, 10.0),

            // creating a swimming activity
            new Swimming("15 April 2025", 10, 10)
        };

        // loop through all activities and print out their summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

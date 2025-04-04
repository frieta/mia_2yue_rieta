using System;

// listing activity to encourage gratitude and positive thinking
class ListingActivity : MindfulnessActivity
{
    // predefined list of prompts for listing
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    // constructor initializing name and description
    public ListingActivity() : base("Listing Exercise", "This activity helps you think about the good things in life.") {}

    // perform the listing activity with user input
    public override void PerformActivity()
    {
        StartActivity(); // start the activity
        Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]); // pick a random prompt
        PauseWithAnimation(5); // pause before user starts listing
        int count = 0;
        Console.WriteLine("Start listing items (type 'done' to finish early):");
        while (true)
        {
            Console.Write($"Item {count + 1}: ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break; // stop if user types 'done'
            count++; // increment item count
        }
        Console.WriteLine($"You listed {count} items! Well done!"); // show the number of items listed
        EndActivity(); // end the activity
    }
}

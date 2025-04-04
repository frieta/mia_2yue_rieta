using System;
using System.Threading;

// reflection activity to help users think about their strengths and experiences
class ReflectionActivity : MindfulnessActivity
{
    // predefined list of prompts for reflection
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // predefined list of questions for reflection
    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    // constructor initializing name and description
    public ReflectionActivity() : base("Reflection Exercise", "This activity helps you reflect on personal strength and resilience.") {}

    // perform the reflection activity with random prompts and questions
    public override void PerformActivity()
    {
        StartActivity(); // start the activity
        Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]); // pick a random prompt
        PauseWithAnimation(5); // pause before starting questions
        for (int i = 0; i < Duration / 6; i++) // loop to match duration
        {
            Console.WriteLine(Questions[new Random().Next(Questions.Length)]); // ask reflection question
            PauseWithAnimation(5); // pause after each question
        }
        EndActivity(); // end the activity
    }
}

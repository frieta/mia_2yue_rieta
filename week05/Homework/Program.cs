using System;
class Program
{
    static void Main()
    {
        // create a basic assignment and print summary
        Assignment assignment = new Assignment("samuel bennett", "multiplication");
        Console.WriteLine(assignment.GetSummary());

        // create a math assignment and print details
        MathAssignment mathAssignment = new MathAssignment("roberto rodriguez", "fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // create a writing assignment and print details
        WritingAssignment writingAssignment = new WritingAssignment("mary waters", "european history", "the causes of world war ii");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}

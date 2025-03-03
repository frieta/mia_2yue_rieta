using System;

class Program
{
    static void Main(string[] args)
  {
        // Ask for the user's grade percentage
        Console.Write("Enter your grade percentage: ");
        string Sagot = Console.ReadLine();
        int percentage = int.Parse(Sagot);

        string letter = ""; //variable for grades corresponing letter
        string sign = ""; //variable for grades correspong sign

        // Determine the letter grade 
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Strecth Challenge - Determine the grade sign for the percentage
        int lastDigit = percentage % 10; //i use modules operator to extract the last digit of the percentage ,In percentage % 10, the modulus operation will isolates the last digit of the number. 

        if (letter != "A" && letter != "F") // No A+ or F+/F-
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && percentage < 93) // A- case
        {
            sign = "-";
        }

        // Printing the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Checking if the student passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You'll do better next time.");
        }
    }
}
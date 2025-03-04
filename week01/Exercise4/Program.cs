using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an empty list to store user input numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Ask the user for numbers until they enter 0
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine()); // Convert input to an integer

            if (number == 0)
                break; // Stop taking inputs when 0 is entered

            numbers.Add(number); // Add the number to the list
        }

        // Core Requirement 1: Compute the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num; // Add each number to sum
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core Requirement 2: Compute the average of the numbers
        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"The average is: {average}");

        // Core Requirement 3: Find the largest number in the list
        int max = numbers[0]; // Assume first number is max
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num; // Update max if a larger number is found
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // --- Stretch Challenge Starts Here ---

        // Stretch Challenge 1: Find the smallest positive number
        int smallestPositive = int.MaxValue; // Start with the largest possible value
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num; // Update smallest positive number
            }
        }

        // If no positive number was found, set default message
        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge 2: Sort the list and display it
        numbers.Sort(); // Sorts the list in ascending order
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers) // Loop through sorted list and print each number
        {
            Console.WriteLine(num);
        }
    }
}

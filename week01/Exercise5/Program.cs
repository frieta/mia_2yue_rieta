using System;

class Program
{
    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine()); // Convert string input to integer
    }

    // Function to calculate the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // Main function that calls all other functions
    static void Main()
    {
        DisplayWelcome(); //Show welcome message

        string userName = PromptUserName(); // Get user's name
        int favoriteNumber = PromptUserNumber(); //Get user's favorite number

        int squared = SquareNumber(favoriteNumber); // Calculate square

        DisplayResult(userName, squared); // Display result
    }
}

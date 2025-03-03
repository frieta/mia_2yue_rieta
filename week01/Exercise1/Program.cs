using System;

class Program
{
    static void Main(string[] args)
      {
        Console.Write("What is your first name? ");// ask the user for their first name
        string firstName = Console.ReadLine();//get the user input for first name

        Console.Write("What is your last name? ");// ask the user for their last name
        string lastName = Console.ReadLine();//get the user input for last name

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");// Display the output
    }
}
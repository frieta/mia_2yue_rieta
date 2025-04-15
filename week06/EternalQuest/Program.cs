using System; 
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager(); // creates the boss of all goal logic

        int choice = 0; // keeps track of the menu option picked by the user 
        while (choice != 6) // loop until the user wants to quit
        {
            Console.WriteLine(); // just some space for readability 
            Console.WriteLine("Menu Options:"); // shows the main menu options 
            Console.WriteLine("  1. Create New Goal"); // menu option to add a new goal 
            Console.WriteLine("  2. List Goals"); // menu option to see all goals 
            Console.WriteLine("  3. Save Goals"); // saves your goals to a file 
            Console.WriteLine("  4. Load Goals"); // loads your goals from a file 
            Console.WriteLine("  5. Record Event"); // marks a goal as completed or progressed 
            Console.WriteLine("  6. Quit"); // exits the program 
            Console.Write("Select a choice from the menu: "); // prompts the user for input 

            choice = int.Parse(Console.ReadLine()); // reads and parses the input from the user 

            if (choice == 1) // if user wants to create a new goal 
            {
                manager.CreateGoal(); // call the method to create a goal 
            }
            else if (choice == 2) // if user wants to list their goals 
            {
                manager.DisplayGoals(); // shows all current goals in detail 
            }
            else if (choice == 3) // if user wants to save goals 
            {
                manager.SaveGoals(); // writes goals and score to a file 
            }
            else if (choice == 4) // if user wants to load saved goals 
            {
                manager.LoadGoals(); // brings back goals from the file 
            }
            else if (choice == 5) // if user finished a goal or made progress 
            {
                manager.RecordEvent(); // record the event and give points 
            }
            else if (choice == 6) // if they want to quit 
            {
                Console.WriteLine("Goodbye adventurer! "); // friendly goodbye message 
            }
            else // for anything that’s not a valid menu number
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

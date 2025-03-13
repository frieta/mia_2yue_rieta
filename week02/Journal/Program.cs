using System;

class Program
{
    static void Main()
    {
        // create a journal instance to store entries
        Journal journal = new Journal();
        
        // create a prompt generator for random prompts
        PromptGenerator generator = new PromptGenerator();
        
        // file name for saving and loading the journal
        string fileName = "journal.txt";

        while (true)
        {
            // display the menu options
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine(); // get the user input

            switch (choice)
            {
                case "1": // write a new journal entry
                    string prompt = generator.GetRandomPrompt(); // get a random prompt
                    Console.WriteLine($"\nPrompt: {prompt}"); // display the prompt
                    Console.Write("Your response: ");
                    string response = Console.ReadLine(); //get user response
                    
                    // add the new entry to the journal
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        journal.AddEntry(new Entry(prompt, response));
                        Console.WriteLine("Entry added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Entry cannot be empty.");
                    }
                    break;

                case "2": // display all journal entries
                    Console.WriteLine("\n--- Journal Entries ---");
                    journal.DisplayAll();
                    break;

                case "3": // save journal to file
                    journal.SaveToFile(fileName);
                    break;

                case "4": // load journal from file
                    journal.LoadFromFile(fileName);
                    break;

                case "5": // exit the program
                    Console.WriteLine("Goodbye!");
                    return;

                default: // promt if invalid input
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

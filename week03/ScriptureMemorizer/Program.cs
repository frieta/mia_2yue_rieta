using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Scripture> _scriptures = new List<Scripture>(); // keeps track of all scriptures
    static string _filePath = "scriptures.txt"; // file where scriptures are saved
    static Random _random = new Random(); // random instance for picking scriptures

    static void Main()
    {
        LoadScriptures(); // load previously saved scriptures

        while (true)
        {
            Console.Clear(); // clean console for a fresh display
            Console.WriteLine("Scripture Memorization Program");
            Console.WriteLine("1. Add a Scripture");
            Console.WriteLine("2. Start Random Scripture Memorization");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine().Trim();

            if (choice == "1")
                AddScripture(); // user adds a new scripture
            else if (choice == "2")
                StartRandomMemorization(); // start memorizing a random scripture
            else if (choice == "3")
                break; // exit the program
        }
    }

    static void AddScripture()
    {
        Console.Write("Enter Scripture Reference (e.g., John 3:16): ");
        string reference = Console.ReadLine().Trim();
        
        Console.Write("Enter Scripture Text: ");
        string text = Console.ReadLine().Trim();

        Scripture newScripture = new Scripture(reference, text);
        _scriptures.Add(newScripture); // add to our list

        Console.Write("Do you want to save changes to scriptures.txt? (yes/no): ");
        string confirm = Console.ReadLine().Trim().ToLower();
        if (confirm == "yes")
        {
            SaveScriptures(); // save scriptures to file
            Console.WriteLine("Scripture added and saved successfully!");
        }
        else
        {
            Console.WriteLine("Scripture was added but not saved to file.");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    static void StartRandomMemorization()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available. Add a scripture first. Press Enter to continue.");
            Console.ReadLine();
            return;
        }

        Scripture scripture = _scriptures[_random.Next(_scriptures.Count)]; // pick a random scripture
        StartMemorization(scripture);
    }

    static void StartMemorization(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display(); // show current state of scripture
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3); // hide a few words at a time
        }

        Console.Clear();
        scripture.Display(); // show final hidden scripture
        Console.WriteLine("\nAll words are hidden. Program complete. Press Enter to return to menu.");
        Console.ReadLine();
    }

    static void SaveScriptures()
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            foreach (var scripture in _scriptures)
            {
                writer.WriteLine($"{scripture.GetReference()}|{scripture.GetText()}");
            }
        }
        Console.WriteLine("Scriptures saved successfully.");
    }

    static void LoadScriptures()
    {
        _scriptures.Clear(); // clear current list to avoid duplicates
        if (File.Exists(_filePath))
        {
            string[] lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    _scriptures.Add(new Scripture(parts[0], parts[1]));
                }
            }
        }
    }
}

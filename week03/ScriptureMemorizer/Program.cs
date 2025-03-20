using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static List<Scripture> scriptures = new List<Scripture>(); // list to store multiple scriptures
    static string filePath = "scriptures.txt"; // text file where scriptures are saved
    static Random random = new Random(); // random instance for selecting scriptures

    static void Main()
    {
        LoadScriptures(); // load saved scriptures from text file

        while (true)
        {
            Console.Clear(); // clears the console for a clean display
            Console.WriteLine("Scripture Memorization Program");
            Console.WriteLine("1. Add a Scripture");
            Console.WriteLine("2. Start Random Scripture Memorization");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine().Trim();

            if (choice == "1")
                AddScripture(); // lets the user add a new scripture
            else if (choice == "2")
                StartRandomMemorization(); // starts memorization with a random scripture
            else if (choice == "3")
                break; // exits the program
        }
    }

    // method to add a new scripture to the list and save it
    static void AddScripture()
    {
        Console.Write("Enter Scripture Reference (e.g., John 3:16): ");
        string reference = Console.ReadLine().Trim();
        
        Console.Write("Enter Scripture Text: ");
        string text = Console.ReadLine().Trim();

        Scripture newScripture = new Scripture(reference, text);
        scriptures.Add(newScripture); // add to list

        Console.Write("Do you want to save changes to scriptures.txt? (yes/no): ");
        string confirm = Console.ReadLine().Trim().ToLower();
        if (confirm == "yes")
        {
            SaveScriptures(); // save the updated list to file
            Console.WriteLine("Scripture added and saved successfully!");
        }
        else
        {
            Console.WriteLine("Scripture was added but not saved to file.");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    // method to start memorization with a random scripture
    static void StartRandomMemorization()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available. Add a scripture first. Press Enter to continue.");
            Console.ReadLine();
            return;
        }

        Scripture scripture = scriptures[random.Next(scriptures.Count)]; // pick a random scripture
        StartMemorization(scripture);
    }

    // method to handle the memorization process
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

            scripture.HideRandomWords(3); // hide a few words each time
        }

        Console.Clear();
        scripture.Display(); // show fully hidden scripture
        Console.WriteLine("\nAll words are hidden. Program complete. Press Enter to return to menu.");
        Console.ReadLine();
    }

    // method to save scriptures to the file
    static void SaveScriptures()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var scripture in scriptures)
            {
                writer.WriteLine($"{scripture.Reference}|{scripture.Text}");
            }
        }
        Console.WriteLine("Scriptures saved successfully.");
    }

    // method to load scriptures from file into the list
    static void LoadScriptures()
    {
        scriptures.Clear(); // clear list before loading to prevent duplicates
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    scriptures.Add(new Scripture(parts[0], parts[1]));
                }
            }
        }
    }
}

// class to represent a scripture with reference and words
class Scripture
{
    public string Reference { get; } // scripture reference like "John 3:16"
    private List<Word> words; // list of words in the scripture
    private Random random = new Random();

    public Scripture(string reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // display the scripture in its current state (hidden words included)
    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", words));
    }

    // randomly hide a given number of words
    public void HideRandomWords(int count)
    {
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden());
    }

    // get the full original text (useful for saving to file)
    public string Text => string.Join(" ", words.Select(w => w.GetOriginalText()));
}

// class to represent a single word in the scripture
class Word
{
    private string originalText; // original word text
    private string hiddenText; // hidden representation of the word
    private bool hidden; // flag to check if word is hidden

    public Word(string text)
    {
        originalText = text;
        hiddenText = new string('_', text.Length); // replaces word with underscores
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        return hidden ? hiddenText : originalText;
    }

    public string GetOriginalText()
    {
        return originalText;
    }
}

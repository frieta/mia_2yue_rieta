using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    // List to store multiple journal entries
    private List<Entry> entries = new List<Entry>();


    /// Adds a new journal entry to the list.
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    
    /// Displays all journal entries in the console.
    /// If no entries exist, it notifies the user.
    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (var entry in entries)
            {
                entry.Display();
            }
        }
    }

    
    /// Saves all journal entries to a specified file.
    /// Each entry is written as a single line using its ToString() format.
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    
    /// Loads journal entries from a specified file.
    /// Clears existing entries before loading new ones from the file.
    /// If the file does not exist, it displays an error message.
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            entries.Clear(); // Clear current entries to avoid duplicates
            string[] lines = File.ReadAllLines(file); // Read all lines from file

            foreach (var line in lines)
            {
                Entry entry = Entry.FromString(line); // Convert string to Entry object
                if (entry != null)
                {
                    entries.Add(entry); // Add valid entries to the list
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

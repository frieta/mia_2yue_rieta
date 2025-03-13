using System;

class Entry
{
    // Stores the date of the entry as a DateTime object
    public DateTime Date { get; private set; }

    // Stores the prompt text for the journal entry
    public string PromptText { get; private set; }

    // Stores the actual journal entry text
    public string EntryText { get; private set; }

    // Constructor to initialize a new journal entry with the current date
    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now; // Automatically assigns the current date
        PromptText = promptText; // Assigns the given prompt text
        EntryText = entryText; // Assigns the given entry text
    }

    // Converts the entry into a formatted string for storage or display
    public override string ToString()
    {
        return $"{Date:yyyy-MM-dd}|{PromptText}|{EntryText}";
        // Stores date in YYYY-MM-DD format for easier readability and parsing
        // Uses '|' as a delimiter to separate values
    }

    // Static method to reconstruct an Entry object from a formatted string
    public static Entry? FromString(string data)
    {
        // Splits the string into parts based on the '|' delimiter
        string[] parts = data.Split('|');

        //this will ensures the format is correct and attempts to parse the date
        if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime parsedDate))
        {
            return new Entry(parts[1], parts[2]) { Date = parsedDate };
        }

        // Validating the format: if parsing fails, return null
        Console.WriteLine("Invalid entry format.");
        return null;
    }

    // Displays the journal entry in a readable format
    public void Display()
    {
        Console.WriteLine($"Date: {Date:yyyy-MM-dd}"); // Shows formatted date
        Console.WriteLine($"Prompt: {PromptText}"); // Displays the prompt
        Console.WriteLine($"Entry: {EntryText}"); // Displays the entry text
        Console.WriteLine(new string('-', 30)); // Prints a separator for readability
    }
}

using System;

class Entry
{
    // stores the date of the entry as a DateTime object
    public DateTime Date { get; private set; }

    // stores the prompt text for the journal entry
    public string PromptText { get; private set; }

    // stores the actual journal entry text
    public string EntryText { get; private set; }

    // constructor to initialize a new journal entry with the current date
    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now; // automatically assigns the current date
        PromptText = promptText; //assigns the given prompt text
        EntryText = entryText; // assigns the given entry text
    }

    // converts the entry into a formatted string for storage or display
    public override string ToString()
    {
        return $"{Date:yyyy-MM-dd}|{PromptText}|{EntryText}";
        // stores date in YYYY-MM-DD format for easier readability and parsing
        // uses '|' as a delimiter/seperator to separate values
    }

    // method to reconstruct an Entry object from a formatted string
    public static Entry? FromString(string data)
    {
        // splits the string into parts based on the '|' delimiter
        string[] parts = data.Split('|');

        //this will ensures the format is correct and attempts to parse the date
        if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime parsedDate))
        {
            return new Entry(parts[1], parts[2]) { Date = parsedDate };
        }

        // validating the format: if parsing fails, return null
        Console.WriteLine("Invalid entry format.");
        return null;
    }

    // displays the journal entry in a readable format
    public void Display()
    {
        Console.WriteLine($"Date: {Date:yyyy-MM-dd}"); // shows formatted date
        Console.WriteLine($"Prompt: {PromptText}"); // displays the prompt
        Console.WriteLine($"Entry: {EntryText}"); // displays the entry text
        Console.WriteLine(new string('-', 30)); // prints a separator for readability
    }
}

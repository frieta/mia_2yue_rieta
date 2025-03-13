using System;
using System.Collections.Generic;

class PromptGenerator
{
    // List of predefined journal prompts
    private List<string> _prompts = new List<string>
    {
        "Describe a memorable childhood experience.",
        "What are your goals for the next year?",
        "If you could travel anywhere, where would you go and why?",
        "Write about a time you faced a challenge and overcame it.",
        "Describe your perfect day."
    };

    // Random instance to generate random indices for selecting prompts
    private Random _random = new Random();

    /// Retrieves a random prompt from the list.
    /// If no prompts are available, it returns a default message.
    /// it will return a random prompt string.
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        int index = _random.Next(_prompts.Count); // this will generate a random index
        return _prompts[index]; // Return the corresponding prompt using the generated index from random index
    }

    /// Adds a new prompt to the list dynamically.
    /// this will add a new prompt
    public void AddPrompt(string newPrompt)
    {
        if (!string.IsNullOrWhiteSpace(newPrompt) && !_prompts.Contains(newPrompt))
        {
            _prompts.Add(newPrompt);
            Console.WriteLine("Prompt added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid or duplicate prompt. Please try again.");
        }
    }

    
    /// Displays all available prompts.
    public void DisplayPrompts()
    {
        if (_prompts.Count == 0)
        {
            Console.WriteLine("No prompts available.");
            return;
        }

        Console.WriteLine("Available Prompts:");
        foreach (var prompt in _prompts)
        {
            Console.WriteLine($"- {prompt}");
        }
    }
}

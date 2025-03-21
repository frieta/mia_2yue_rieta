using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string _scriptureReference; // holds the scripture reference (e.g., john 3:16)
    private List<Word> _words; // stores the words of the scripture
    private Random _random = new Random();

    public Scripture(string reference, string text)
    {
        _scriptureReference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList(); // break the text into words
    }

    public void Display()
    {
        Console.WriteLine(_scriptureReference);
        Console.WriteLine(string.Join(" ", _words)); // show the scripture with hidden words
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide(); // hide a random word
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden()); // check if all words are hidden
    }

    public string GetReference()
    {
        return _scriptureReference;
    }

    public string GetText()
    {
        return string.Join(" ", _words.Select(w => w.GetOriginalText())); // get the full scripture text
    }
}
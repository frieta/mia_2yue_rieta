using System;
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // constructor - takes extra details specific to math assignments
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // returns the list of homework problems
    public string GetHomeworkList()
    {
        return $"section {_textbookSection} problems {_problems}";
    }
}
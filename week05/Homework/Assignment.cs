using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // constructor - takes student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // returns a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // lets derived classes access student name
    public string GetStudentName()
    {
        return _studentName;
    }
}
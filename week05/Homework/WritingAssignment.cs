using System;

public class WritingAssignment : Assignment
{
    private string _title;

    // constructor - takes extra details specific to writing assignments
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // returns writing assignment details
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}

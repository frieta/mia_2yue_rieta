using System;

// this class represents a comment on a video
// it just holds the name of the person who commented and the actual comment text
class Comment
{
    public string Name { get; set; } // name of the commenter
    public string Text { get; set; } // comment text

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
using System;
using System.Collections.Generic;

// this class is all about videos, keeping track of details and comments
class Video
{
    public string Title { get; set; } // title of the video
    public string Author { get; set; } // who uploaded this masterpiece
    public int Length { get; set; } // length of the video in seconds
    private List<Comment> _comments; // a list to store all comments

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>(); // initializing the comment list
    }

    // method to let people add their thoughts on the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // get the total number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // display video details and all the comments it got
    public void Display()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine("-----------------------------");
    }
}
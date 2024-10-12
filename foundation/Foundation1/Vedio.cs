using System;
using System.Collections.Generic;

public class Video
{
    // Attributes
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to list comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}

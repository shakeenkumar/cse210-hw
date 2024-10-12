using System;
using System.Collections.Generic;

public class Video
{
    // Properties
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; } // Length in seconds
    private List<Comment> _comments; // List to store comments

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>(); // Initialize the comments list
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count; // Return the count of comments
    }

    // Method to retrieve all comments
    public List<Comment> GetComments()
    {
        return _comments; // Return the list of comments
    }
}

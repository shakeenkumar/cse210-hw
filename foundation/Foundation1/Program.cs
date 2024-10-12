using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Creating Video objects
        Video video1 = new Video("Understanding Abstraction", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        
        Video video2 = new Video("Encapsulation in C#", "Jane Smith", 450);
        video2.AddComment(new Comment("Charlie", "This is awesome!"));
        video2.AddComment(new Comment("David", "Really insightful."));

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);

        // Displaying video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> _videos = new List<Video>();

        // Create some videos and add them to the list
        Video video1 = new Video("Understanding C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "I learned a lot."));
        video1.AddComment(new Comment("Charlie", "Thanks for the tips!"));

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "This helped me with my project."));
        video2.AddComment(new Comment("Eve", "Very informative."));
        video2.AddComment(new Comment("Frank", "I need to practice more."));

        Video video3 = new Video("C# for Beginners", "Emily Johnson", 600);
        video3.AddComment(new Comment("George", "Fantastic video!"));
        video3.AddComment(new Comment("Hannah", "Looking forward to the next part."));

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (var video in _videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line for better readability
        }
    }
}

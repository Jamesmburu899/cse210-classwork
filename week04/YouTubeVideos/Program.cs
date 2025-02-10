using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>
        {
            new Video("C# Tutorial for Beginners", "Programming with Mosh", 600),
            new Video("ASP.NET Core Crash Course", "Traversy Media", 1200),
            new Video("Learn Python in 10 Minutes", "Tech With Tim", 600)
        };

        // Add comments to videos
        videos[0].AddComment(new Comment("John", "Great tutorial!"));
        videos[0].AddComment(new Comment("Alice", "Very helpful, thanks!"));
        videos[0].AddComment(new Comment("Bob", "I learned a lot."));

        videos[1].AddComment(new Comment("Charlie", "Awesome crash course!"));
        videos[1].AddComment(new Comment("Dave", "Loved the explanation."));
        videos[1].AddComment(new Comment("Eve", "Perfect for beginners."));

        videos[2].AddComment(new Comment("Frank", "Short and sweet."));
        videos[2].AddComment(new Comment("Grace", "Python is amazing!"));
        videos[2].AddComment(new Comment("Heidi", "Thanks for the quick guide."));

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); // Add a blank line for readability
        }
    }
}

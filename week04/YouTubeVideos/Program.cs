using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videoList = new List<Video>();

        // Video 1
        Video vid1 = new Video("C# Tutorial for Beginners", "CodeAcademy", 3600);
        vid1.AddComment(new Comment("Alice", "Great tutorial, very helpful!"));
        vid1.AddComment(new Comment("Bob", "I finally understand classes."));
        vid1.AddComment(new Comment("Charlie", "Can you do one on Python next?"));
        videoList.Add(vid1);

        // Video 2
        Video vid2 = new Video("Top 10 Big 5 Animals", "SafariLife", 600);
        vid2.AddComment(new Comment("Dave", "The leopard is my favorite!"));
        vid2.AddComment(new Comment("Eve", "South Africa is beautiful."));
        vid2.AddComment(new Comment("Frank", "I want to visit someday."));
        vid2.AddComment(new Comment("Grace", "Amazing footage."));
        videoList.Add(vid2);

        // Video 3
        Video vid3 = new Video("How to Build an AI", "TechVision", 1200);
        vid3.AddComment(new Comment("Heidi", "The future is here."));
        vid3.AddComment(new Comment("Ivan", "This is a bit scary but exciting."));
        vid3.AddComment(new Comment("Judy", "Thanks for the explanation."));
        videoList.Add(vid3);

        // Iterate through the list and display everything
        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine("\n-------------------------\n"); // Separator
        }
    }
}

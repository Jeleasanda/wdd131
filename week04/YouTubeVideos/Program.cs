using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("C# Tutorial for Beginners", "CodeAcademy", 3600),
            new Video("Top 10 Big 5 Animals", "SafariLife", 600),
            new Video("How to Build an AI", "TechVision", 1200)
        };

        videos[0].AddComment(new Comment("Alice", "Great tutorial, very helpful!"));
        videos[0].AddComment(new Comment("Bob", "I finally understand classes."));
        videos[0].AddComment(new Comment("Charlie", "Can you do one on Python next?"));

        videos[1].AddComment(new Comment("Dave", "The leopard is my favorite!"));
        videos[1].AddComment(new Comment("Eve", "South Africa is beautiful."));
        videos[1].AddComment(new Comment("Frank", "I want to visit someday."));
        videos[1].AddComment(new Comment("Grace", "Amazing footage."));

        videos[2].AddComment(new Comment("Heidi", "The future is here."));
        videos[2].AddComment(new Comment("Ivan", "This is a bit scary but exciting."));
        videos[2].AddComment(new Comment("Judy", "Thanks for the explanation."));

        foreach (Video video in videos)
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

            Console.WriteLine("\n-------------------------\n");
        }
    }
}

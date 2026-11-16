using System;
using System.Collections.Generic;

public class Video
{
    private readonly string _title;
    private readonly string _author;
    private readonly int _lengthInSeconds;
    private readonly List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        if (lengthInSeconds < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(lengthInSeconds), "Video length cannot be negative.");
        }

        _title = title ?? string.Empty;
        _author = author ?? string.Empty;
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment ?? throw new ArgumentNullException(nameof(comment)));
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _lengthInSeconds;
    }

    public IReadOnlyList<Comment> GetComments()
    {
        return _comments.AsReadOnly();
    }
}

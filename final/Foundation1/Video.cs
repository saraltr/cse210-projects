using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} by {_author}");
        Console.WriteLine($"Length of the video: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumComments()}");
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

}
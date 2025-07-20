using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;
    public Video(string title, string author, string length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} : {_author} Length:{_length}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}
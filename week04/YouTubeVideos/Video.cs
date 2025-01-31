class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    public string GetVideoDetails()
    {
        return $"{_title} by {_author} ({_lengthInSeconds} seconds)";
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> Comments()
    {
        return _comments;
    }
}
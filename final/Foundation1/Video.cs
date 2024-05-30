class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment._name + ": " + comment._message);
        }
    }
}
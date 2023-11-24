class Video
{
    private string _title;
    private string _author;
    private int _vidLength;
    private List<Comment> _comments = new();

    // CONSTRUCTOR
    public Video(string _title, string _author, int _vidLength)
    {
        this._title = _title;
        this._author = _author;
        this._vidLength = _vidLength;
    }
    public void AddComment()
    {
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Comment");
        string textComment = Console.ReadLine();
        Comment comment = new Comment(name, textComment);
        _comments.Add(comment);
    }
    public void AddComment(string name, string textComment)
    {
        Comment comment = new Comment(name, textComment);
        _comments.Add(comment);
    }

    // METHODS
    public void Display()
    {
        Console.WriteLine($"\nTitle of Video: {_title}\nAuthor: {_author}\nVideo Length: {_vidLength} seconds");
        Console.WriteLine($"number of comments: {DisplayNumComments()}\nComments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
    }
    public int DisplayNumComments()
    {
        return _comments.Count;
    }
}
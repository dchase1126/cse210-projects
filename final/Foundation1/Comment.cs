class Comment
{
    private string _name;  // name of person that made the comment
    private string _textComment;   //Comment of person

    // CONSTRUCTOR
    public Comment(string _name, string _textComment)
    {
        this._name = _name;
        this._textComment = _textComment;

    }
    public string DisplayComment()
    {
        return $"\tName: {_name}\n\tComment: {_textComment}\n";

    }
}
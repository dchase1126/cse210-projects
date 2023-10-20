class Reference  // Keeps track of the book, chapter, and verse information.
{
    private string _book;
    private string _chapter;
    private string _startverse;
    private string _endverse;

    // CONSTRUCTOR
    public Reference(string _book, string _chapter, string _startverse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._startverse = _startverse;
        _endverse = null;
    }
    public Reference(string _book, string _chapter, string _startverse, string _endverse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._startverse = _startverse;
        this._endverse = _endverse;
    }

    // METHODS
    public void Display()
    {
        if (_endverse == null)
        {
            Console.WriteLine($"{_book} {_chapter} {_startverse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter} {_startverse} {_endverse}");
        }
    }

}
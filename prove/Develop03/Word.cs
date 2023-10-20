class Word  // Keeps track of a single word and whether it is shown or hidden.
{
    private Random random = new Random();

    private string _word;
    private string _hiddenWord;
    private bool _hidden;

    //constructor
    public Word(string _word)
    {
        this._word = _word;
        _hidden = false;
        foreach (char letter in _word)
        {
            _hiddenWord += "_";
        }
    }

    public void HideWord() { _hidden = true; }
    public void ShowWord() { _hidden = false; }
    public bool GetStatus() { return _hidden; } // checks if word is already hidden

    public void Display()
    {
        if (_hidden)
            Console.Write($"{_hiddenWord} ");
        else
            Console.Write($"{_word} ");
    }
}
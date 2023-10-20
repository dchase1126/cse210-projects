class Scripture   //Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random random = new Random();

    // CONSTRUCTOR
    public Scripture(string _text, Reference reference)
    {
        _reference = reference;
        string[] words = _text.Split();
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

    //Methods
    public void DisplayWords()
    {
        _reference.Display();

        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public void HideWord()
    {
        int index = random.Next(_words.Count);

        while (_words[index].GetStatus())  // Check if the word is already hidden.
        {
            index = random.Next(_words.Count);   //gets another word and hides it.
        }

        _words[index].HideWord(); // This is hidding a single word.
    }

    public bool WordsHidden()
    {
        // Checks if all the words in the list are hidden. 
        // Return True if all are hidden or False, otherwise.
        foreach (Word word in _words) // Checks if the word is already hidden.
        {
            // If there is a word that is not hidden. The loop is not over. 
            if (word.GetStatus() == false)
            {
                return false;
            }
        }
        // I have finished checking the words and they are all hidden. 
        return true;
    }
}


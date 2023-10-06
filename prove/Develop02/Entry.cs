public class Entry
{
    private PromptGenerator promptGenerator = new PromptGenerator();
    private DailyQuotes dailyQuotes = new DailyQuotes();
    private string _date;
    private string _quote;
    private string _prompt;
    private string _response;

    // PROPTERTIES
    // (Access Type) (Return Type) (Property Name) {}
    public string Date { get { return _date; } }
    public string Quote { get { return _quote; } }
    public string Prompt { get { return _prompt; } }
    public string Response { get { return _response; } }

    // CONSTRUCTOR
    public Entry() { }
    public Entry(string _date, string _quote, string _prompt, string _response)
    {
        this._date = _date;
        this._quote = _quote;
        this._prompt = _prompt;
        this._response = _response;
    }

    // METHODS
    public void Write()
    {
        _date = DateTime.Now.ToShortDateString();
        _quote = dailyQuotes.GetRandomQuote();
        _prompt = promptGenerator.GetRandomQuestion();

        Console.WriteLine(_quote);
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Today's Date: {_date}\nDaily Quote: {_quote}\nToday's Journal Prompt: {_prompt}\nWrite Your Response: {_response}");

    }

    // Using getters and setters allow us to set up more robust checks or add additional logic when altering or returning field data.
    public string GetResponse()
    {
        return _response; // Only returns a copy of the field.
    }

    public void SetResponse(string _response)
    {
        this._response = _response;
    }

    // public ref string GetResponseRef() // Returns the root variable
    // {
    //     return ref response;
    // }

}
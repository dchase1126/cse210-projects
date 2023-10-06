public class Entry
{
    private PromptGenerator _promptGenerator = new PromptGenerator();
    private DailyQuotes _dailyQuotes = new DailyQuotes();
    private string _date;
    private string _quote;
    private string _prompt;
    private string _response;

    // PROPTERTIES
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
        _quote = _dailyQuotes.GetRandomQuote();
        _prompt = _promptGenerator.GetRandomQuestion();

        Console.WriteLine(_quote);
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Today's Date: {_date}\nDaily Quote: {_quote}\nToday's Journal Prompt: {_prompt}\nWrite Your Response: {_response}");

    }

}
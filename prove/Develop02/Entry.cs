public class Entry
{
    private PromptGenerator promptGenerator = new();
    private DailyQuotes dailyQuotes = new();
    private string date;
    private string quote;
    private string prompt;
    private string response;

    // METHODS
    public void Write()
    {
        date = DateTime.Now.ToShortDateString();
        quote = dailyQuotes.GetRandomQuote();
        prompt = promptGenerator.GetRandomQuestion();

        Console.WriteLine(quote);
        Console.WriteLine(prompt);

        response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        response = Console.ReadLine();
    }
}
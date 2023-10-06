public class DailyQuotes
{
    private Random rand = new Random();
    private List<string> _quoteList = new List<string>
    {
       "All our dreams can come true, if we have the courage to pursue them. —Walt Disney",
       "The secret of getting ahead is getting started. —Mark Twain",
       "It is hard to beat a person who never gives up. —Babe Ruth",
       "You gotta dance like there is nobody watching, sing like there is nobody listening, and live like it is heaven on earth. —William W. Purkey",
       "Do what you feel in your heart to be right―for you will be criticized anyway. ―Eleanor Roosevelt",
       "Whatever you are, be a good one. ―Abraham Lincoln",
       "If we have the attitude that it is going to be a great day it usually is. —Catherine Pulsifier",
       "If something is important enough, even if the odds are stacked against you, you should still do it. —Elon Musk",
       "Hold the vision, trust the process. —Unknown",
       "One day or day one. You decide. —Unknown",
       "Some people want it to happen, some wish it would happen, others make it happen. ―Michael Jordan",
       "Motivation often comes after starting not before, action produces momentum. ―James Clear",
    };

    public string GetRandomQuote()
    {
        int index = rand.Next(_quoteList.Count);
        return _quoteList[index];
    }
}
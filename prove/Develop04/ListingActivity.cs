class ListingActivity : Activity  //derived or sub class
{

    private Random rand = new Random();
    //private string _prompts;
    //private string _answers;

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    private List<string> _answers = new List<string>()
    {

    };


    // constructors

    public ListingActivity(string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public ListingActivity(string prompts, string answers, string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public List<ListingActivity> prompts = new List<ListingActivity>();

    public string GetRandomPrompt()
    {
        int index = rand.Next(prompts.Count);
        return _prompts[index];
    }

    public void DisplayPromptInfo()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (startTime < futureTime)
        {
            {
                Console.WriteLine(GetRandomPrompt());
                Thread.Sleep(3000);
            }
        }
    }

    /* public List<ListingActivity> answers = new List<ListingActivity>();

     public string GetAnswers()
    {
        int index = rand.Next(answers.Count);
        return _answers[index];
    }

    public void DisplayAnswerInfo()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (startTime < futureTime)
        {
            {
                Console.WriteLine(GetAnswers());
                Thread.Sleep(3000);
            }*
        }
    }*/


}
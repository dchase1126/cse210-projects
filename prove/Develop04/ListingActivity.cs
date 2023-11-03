class ListingActivity : Activity  //derived or sub class
{

    private Random random = new Random();

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    // constructors

    public ListingActivity()
    {
        _name = "Listing ";
        _description = "This activity will help you think of all the good things in your life by having you 'List' as many things as you can in a certain area.";
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void BeginActivity()
    {
        StartMessage();
        {
            int counter = 0;
            Console.WriteLine(GetRandomPrompt());
            DateTime futureTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                string input = Console.ReadLine();
                counter++;
            }

            EndMessage();
            {
                Console.WriteLine($"You entered {counter} items! \n You have completed the activity!");
            }
        }
    }
}
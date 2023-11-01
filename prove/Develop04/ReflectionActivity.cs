using System.Transactions;

class ReflectionActivity : Activity  //derived or sub class
{
    private Random rand = new Random();
    private List<string> _messages = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?.",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    //constructors
    public ReflectionActivity(string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public ReflectionActivity(string messages, string questions, string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public string GetRandomMessage()
    {
        int index = rand.Next(_messages.Count);
        return _messages[index];
    }

    public void DisplayPromptInfo()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (startTime < futureTime)
        {
            {
                Console.WriteLine(GetRandomMessage());
                Thread.Sleep(3000);
            }
        }
    }

    public string GetRandomQuestion()
    {
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayQuestionInfo()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (startTime < futureTime)
        {
            {
                Console.WriteLine(GetRandomQuestion());
                Thread.Sleep(3000);
            }
        }
    }

    /*public void StartReflection()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (startTime < futureTime)
        {
            {
                Console.WriteLine(StartReflection());
                Thread.Sleep(3000);
            }
        }
    }*/



}
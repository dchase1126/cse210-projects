using System.Transactions;
//Inheritance - class ReflectionActivity is the child, derived or Sub class : Activity is the parent, base  or Super class 
class ReflectionActivity : Activity  
{
    private Random random = new Random();
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
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    //constructors
    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string GetRandomMessage()
    {
        int index = random.Next(_messages.Count);
        return _messages[index];
    }

    public string GetRandomQuestion()
    {
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void BeginActivity()
    {
        StartMessage();
        Console.WriteLine("Consider the following statement: ");
        Console.WriteLine(GetRandomMessage());
        Spinner(5);

        Console.WriteLine("When you have something in mind press 'Enter' to continue");
        string choice = Console.ReadLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            Spinner(5);
        }

        EndMessage();
    }

}
class Activity //Inheritance -This is the parent, base  or Super class 
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private string[] _animation = new[] { "|", "/", "-", "\\" };


    //constructors
    public Activity() { }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How many seconds would you like to do the activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Counter(5);
        Console.Clear();
    }
    public void EndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Great Job!\nYou have completed {_duration} seconds of the {_name} activity.");
        Spinner(5);
        Console.Clear();
    }

    public void Counter(int duration)
    {

        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i <= 9)
            {
                Console.Write("\b \b");
                Console.CursorVisible = false;
            }
            else if (i >= 10 && i < 100)
            {
                Console.Write("\b\b  \b\b");
                Console.CursorVisible = false;
            }
        }

        Console.CursorVisible = true;
    }

    public void Spinner(int duration)
    {

        for (int i = duration; i > 0; i--)
        {
            foreach (string symbol in _animation)
            {
                Console.Write(symbol);
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.CursorVisible = false;
            }
        }

        Console.CursorVisible = true;
    }
}

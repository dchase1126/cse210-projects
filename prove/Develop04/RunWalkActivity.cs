class RunWalkActivity : Activity  //derived or sub class
{
    //private int _run;
    //private int _walk;

    //constructors
    public RunWalkActivity(string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public RunWalkActivity(int run, int walk, string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public RunWalkActivity(int run, int walk)
    {
        Console.WriteLine("Run in place...");
        Console.WriteLine("Walk in place...");
    }
}
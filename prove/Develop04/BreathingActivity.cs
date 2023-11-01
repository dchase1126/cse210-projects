class BreathingActivity : Activity  //derived or sub class
{
    private int _breathIn;
    private int _breathOut;

    //constructors
    public BreathingActivity(string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public BreathingActivity(int breatIn, int breathOut, string name, string description, int durationPauseTime, int duration) : base(name, description, durationPauseTime, duration)
    {

    }

    public BreathingActivity(int breathIn, int breathOut)
    {
        Console.WriteLine("Breathe in...");
        Console.WriteLine("Breathe out...");
    }
}
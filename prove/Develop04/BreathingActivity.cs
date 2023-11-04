class BreathingActivity : Activity  //derived or sub class
{
    //constructors
    public BreathingActivity()
    {
        _name = "Breathing ";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BeginActivity()
    {
        StartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Counter(6);
            Console.Write("\nBreathe out...");
            Counter(4);

        }
        EndMessage();
       
    }
}
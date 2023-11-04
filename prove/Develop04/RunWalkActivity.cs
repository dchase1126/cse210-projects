class RunWalkActivity : Activity  //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{

    //constructors
    public RunWalkActivity()
    {
        _name = "Run and Walk ";
        _description = "This activity will help you move your body by doing 10 second intervals of running and walking in place. Get ready. Let's get moving!.";
    }

    public void BeginActivity()
    {
        StartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nRun in place...");
            Counter(10);
            Console.Write("\nWalk in place...");
            Counter(10);

        }
        EndMessage();
    }
}
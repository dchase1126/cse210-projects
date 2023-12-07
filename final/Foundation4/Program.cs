using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello! Welcome to 'Polymorphism with Exercise Tracking' final program.\n");

        List<Activity> activity = new List<Activity>();
        DateTime dateTime = DateTime.Now;

        Running running = new Running(30.0f, dateTime, 2.0f, 6.0f, 3.0f );
        activity.Add(running);

        Swimming swimming = new Swimming(30.0f, dateTime, 66.0f);
        activity.Add(swimming);

        Cycling cycling = new Cycling(30.0f, dateTime, 20.0f);
        activity.Add(cycling);

        foreach (Activity style in activity)
        {
            Console.WriteLine(style.GetSummary());
           
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int _choice = 0;

        while (_choice != 5)
        {
            // Display the menu options
            Console.WriteLine("\nHello, Welcome to your Mindfulness Activtities!");
            Console.WriteLine("What activity would you like to do?\n");
            Console.WriteLine("1. Reflection Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Breathing Activity");
            Console.WriteLine("4. Run & Walk Activity");
            Console.WriteLine("5. Quit");

            // get the users choice

            _choice = int.Parse(Console.ReadLine());


            switch (_choice)
            {
                case 1:
                    ReflectionActivity reflecting = new();
                    reflecting.BeginActivity();
                    break;
                case 2:
                    ListingActivity listing = new();
                    listing.BeginActivity();
                    break;
                case 3:
                    BreathingActivity breathing = new();
                    breathing.BeginActivity();
                    break;
                case 4:
                    RunWalkActivity running = new();
                    running.BeginActivity();
                    break;
                case 5:
                    Console.WriteLine("Bye! Have a great day!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("If you want to do an activity, please choose an option 1-5.");
                    break;
            }
        }
    }
}

// Exceeding requirements by adding a "RunWalk.cs" file  per "Adding another kind of activity" 
// Exceeding requirements by adding a "default" in the switch and case in the menu.
// Exceeding requirement  by hiding the cursor for the spinner and countdown.
// I also cleared the console so it would look cleaner while showing the count down and activity.  
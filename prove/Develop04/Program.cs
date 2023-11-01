using System;

class Program
{


    static void Main(string[] args)
    {
        Activity activity = new Activity();

        int _menuChoice = 0;
        {
            // Display the menu options
            Console.WriteLine("\nHello, Welcome to your Mindfulness Activtities!");
            Console.WriteLine("What activity would you like to do?\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. ReflectionActivity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Run & Walk Activity");
            Console.WriteLine("5. Quit");

            // get the users choice
            string _choice = Console.ReadLine();
            int _menuchoice = int.Parse(Console.ReadLine());

            switch (_menuChoice)
            {
                case 1:
                    //activity.BreathingActivity();
                    break;
                case 2:
                    //activity.ReflectionActivity();
                    break;
                case 3:
                    //activity.ListingActivity();
                    break;
                case 4:
                    // activity.RunWalkActivity();
                    break;
                case 5:
                    Environment.Exit(0);
                    Console.WriteLine("Great Job! Have a great day!");
                    break;
                default:
                    Console.WriteLine("Want to do another Activity? Please choose an option 1-5.");
                    break;
            }
        }
    }
}
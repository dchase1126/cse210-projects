using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!\nWelcome to the Eternal Goals Quest.\nPlease select fom the menu.\n\n\tEternal Goals Quest");
        int _choice = 0;
        GoalsManager _goalsmanager = new GoalsManager();
        string _menuChoice = " ";
        while (_choice != 6)
        {
            // Display the menu options
            Console.WriteLine($"Score: {_goalsmanager.Score}");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Display all Goals");
            Console.WriteLine("3. Load all Goals");
            Console.WriteLine("4. Save all Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("\nWhat would you like to do?\n");

            // get the users choice
            _menuChoice = Console.ReadLine();
            _choice = int.Parse(_menuChoice);

            switch (_choice)
            {
                case 1:  // Create a Goal

                    _goalsmanager.AddGoal();
                    break;

                case 2:  // Display all Goals

                    _goalsmanager.DisplayGoals();
                    break;

                case 3:  // Load all Goals
                    Console.WriteLine("What is the file you want to load? (myGoals.txt) ");
                    string _goalFile = Console.ReadLine();
                    _goalsmanager.Load(_goalFile);
                    break;

                case 4:  // Save all Goals
                    Console.Write("Enter File name (myGoals.txt) ");
                    _goalFile = Console.ReadLine();
                    _goalsmanager.Save(_goalFile);
                    break;

                case 5:  // Record Event

                    _goalsmanager.RecordEvent();
                    break;

                case 6:  // Quit
                    Console.WriteLine("Have a good day!");
                    Environment.Exit(0);

                    break;
                default:
                    Console.WriteLine("In valid input. Please choose an option 1-6.\n");
                    break;

            }
        }
    }
}

// Exceeding Requirments by.....  
//
// Exceeding requirements by adding a "FitnessGoal.cs" file  per "Adding another kind of goal" 
// Exceeding requirements by adding a "default" in the switch and case in the menu.
// Exceeding requirement  by hiding the cursor for the spinner and countdown.
// I also cleared the console so it would look cleaner while showing the count down and activity. 
//
// Add additional kinds of goals, such as the ability to make progress towards a large goal 
// (such as getting value for working towards running a marathon), or "negative goals" where they lose points for bad habits.                

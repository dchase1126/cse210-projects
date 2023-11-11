using System;

 class Program
{
    static void Main(string[] args)
    {
        
        int _choice = 0;
        GoalsManager _goalsmanager;

        string _message = "Hello!\nWelcome to the Eternal Goals Quest.\nPlease select fom the menu.\n\n\tEternal Goals Quest";

        
        while (_choice != 5)
        {
            // Display the menu options
            Console.WriteLine(_message);
          
            Console.WriteLine("1. Create a Simple Goal");
            Console.WriteLine("2. Create a Eternal Goal");
            Console.WriteLine("3. Create a Checklist Goal");
            Console.WriteLine("4. Display all Goals");
            Console.WriteLine("5. Load all Goals");
            Console.WriteLine("6. Save all Goals");
            Console.WriteLine("7. Record Event");
            Console.WriteLine("8. Quit");
            Console.WriteLine("\nWhat would you like to do?\n");

            // get the users choice
          string _menuChoice = Console.ReadLine();
            _choice = int.Parse(_menuChoice);

            switch (_choice)
            {
                case 1:  // Create a Simple Goal
                    
                    Goal simple = new SimpleGoals();
                    _goalsmanager.AddNewGoal(simple);

                    break;

                case 2:  // Create a Eternal Goal
                     Goal eternal = new EternalGoal();
                    _goalsmanager.AddNewGoal(eternal);

                    break;

                case 3: // Create a Checklist Goal
                    Goal checklist = new ChecklistGoal();
                    _goalsmanager.AddNewGoal(checklist);

                    break;

                case 4:  // Display all Goals
                
                    _goalsmanager.DisplayGoal();

                    break;

                case 5:  // Load all Goals
                    Console.WriteLine("What is the file you want to load? (myGoals.txt) ");
                    string _goalFile = Console.ReadLine();
                    _goalsmanager.LoadGoalFromFile(_goalFile);
                    break;

                case 6:  // Save all Goals
                    Console.Write("Enter File name (myGoals.txt) ");
                    _goalFile = Console.ReadLine();
                    _goalsmanager.SaveGoalToFile(_goalFile);
                    break;

                case 7:  // Record Event

                    _goalsmanager.RecordEvent();

                    break;

                case 8:  // Quit
                    Environment.Exit(0);
                    Console.WriteLine("Have a good day!");
                    break;
                default:
                    Console.WriteLine("Please choose an option 1-8.");
                    break;

            }
        }

    }

}   
                
                   
                    
using System;
using System.IO;

public class GoalsManager  //The Goals Manager is to keep track of the goals and scores. Which means once a goal is created you add the goal to the goal list.

{
    private int _score;
    private List<Goal> _goals = new List<Goal>();


    public void AddGoal()
    {
        // get the users choice
        int _choice = 0;
        string _menuChoice = Console.ReadLine();
        _choice = int.Parse(_menuChoice);

        Console.WriteLine("1. Create a Simple Goal");
        Console.WriteLine("2. Create a Eternal Goal");
        Console.WriteLine("3. Create a Checklist Goal");
        Console.WriteLine("4. Create a Fitness Goal");

        switch (_choice)
        {
            case 1:  // Create a Simple Goal

                Console.WriteLine("What is the Name of your Goal?");
                string description = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                string name = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal simple = new SimpleGoal(description, name, points);
                _goals.Add(simple);

                break;

            case 2:  // Create a Eternal Goal

                Console.WriteLine("What is the Name of your Goal?");
                description = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                name = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                points = int.Parse(Console.ReadLine());

                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);

                break;

            case 3: // Create a Checklist Goal

                Console.WriteLine("What is the Name of your Goal?");
                description = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                name = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your target?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your Bonus points?");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklist);

                break;

            case 4: // Create a Fitness Goal

                Console.WriteLine("What is the Name of your Goal?");
                description = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                name = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your target?");
                int targetWeight = int.Parse(Console.ReadLine());
                Console.WriteLine("How may Reps do you want to do?");
                int reps = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Sets do you want to do?");
                int sets = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Bonus Points do you want to achieve?"); 
                bonus = int.Parse(Console.ReadLine());

                FitnessGoal fitness = new FitnessGoal(name, description, points, targetWeight, reps, sets, bonus);
                _goals.Add(fitness);

                break;

            default:
                Console.WriteLine("In valid input. Please try again by Choosing 1-4");
                break;
        }


    }

    public void RecordEvent()  ///??????
    {
        List<int> indexes = new();
        int i = 0;
        int counter = 1;
        for (i = 0; i < _goals.Count; i++)
        {
            if (!_goals[i].IsComplete)
            {
                indexes.Add(i);
                Console.WriteLine($"{counter} {_goals[i].Name}");
                counter++;

                Console.WriteLine($"Select a goal");
                //option = Get.AddGoal();
                _score += _goals[indexes[counter - 1]].RecordEvent();
            }
        }
    }
    public void Load(string filename) { }

    public void DisplayGoals()
    {
        foreach (Goal goals in _goals)
        {
            goals.DisplayGoal();
        }
    }

    public void Save(string _fileName)
    {
        Console.WriteLine("Saving to file...");
        try
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName, true))
            {
                foreach (FitnessGoal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetSaveString());
                }
            }

            _goals.Clear();
        }
        catch
        {
            Console.WriteLine("Error: Unable to save to file.");
        }

    }

}

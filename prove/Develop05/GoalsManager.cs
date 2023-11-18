using System;
using System.IO;

public class GoalsManager  //The Goals Manager is to keep track of the goals and scores. Which means once a goal is created you add the goal to the goal list.

{
    private int _score;
    public int Score { get { return _score; } }
    private List<Goal> _goals = new List<Goal>();


    public void AddGoal()
    {
        // get the users choice
        int _choice = 0;

        Console.WriteLine("1. Create a Simple Goal");
        Console.WriteLine("2. Create a Eternal Goal");
        Console.WriteLine("3. Create a Checklist Goal");
        Console.WriteLine("4. Create a Fitness Goal");

        string _menuChoice = Console.ReadLine();
        _choice = int.Parse(_menuChoice);

        Console.WriteLine("What is the Name of your Goal?");
        string name = Console.ReadLine();
        Console.WriteLine("Describe your Goal?");
        string description = Console.ReadLine();
        Console.WriteLine("How many Points is this Goal worth?");
        int points = int.Parse(Console.ReadLine());

        switch (_choice)
        {
            case 1:  // Create a Simple Goal

                SimpleGoal simple = new SimpleGoal(name, description, points);
                _goals.Add(simple);

                break;

            case 2:  // Create a Eternal Goal

                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);

                break;

            case 3: // Create a Checklist Goal

                Console.WriteLine("What is your target?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your Bonus points?");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklist);

                break;

            case 4: // Create a Fitness Goal

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

    public void RecordEvent()
    {
        List<int> indexes = new();
        int counter = 1;
        for (int i = 0; i < _goals.Count; i++)
        {
            if (!_goals[i].IsComplete)
            {
                indexes.Add(i);
                Console.WriteLine($"{counter} {_goals[i].Name}");
                counter++;
            }
        }

        Console.WriteLine($"Select a Goal to record");
        int option = int.Parse(Console.ReadLine());
        _score += _goals[indexes[option - 1]].RecordEvent();
    }

    public void Load(string fileName)
    {
        Console.Write("Save all entries before loading. Press 'Enter' to continue.\n> ");

        _goals.Clear();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "Simple")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool iscomplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points, iscomplete);
                _goals.Add(goal);
            }

            else if (parts[0] == "Eternal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            else if (parts[0] == "Fitness")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool iscomplete = bool.Parse(parts[4]);
                int currentWeight = int.Parse(parts[5]);
                int targetWeight = int.Parse(parts[6]);
                int reps = int.Parse(parts[7]);
                int sets = int.Parse(parts[8]);
                int bonus = int.Parse(parts[9]);


                FitnessGoal goal = new FitnessGoal(name, description, points, iscomplete, currentWeight, targetWeight, reps, sets, bonus);
                _goals.Add(goal);
            }

            else if (parts[0] == "Checklist")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool iscomplete = bool.Parse(parts[4]);
                int current = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, iscomplete, current, target, bonus);
                _goals.Add(goal);
            }

            else if (parts[0] == "Score")
                _score = int.Parse(parts[1]);
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goals in _goals)
        {
            Console.WriteLine(goals.DisplayGoal());
        }
    }

    public void Save(string _fileName)
    {
        Console.WriteLine("Saving to file...");
        try
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName, true))
            {

                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetSaveString());
                }

                outputFile.WriteLine($"Score|{_score}");
            }

        }
        catch
        {
            Console.WriteLine("Error: Unable to save to file.");
        }

    }

}

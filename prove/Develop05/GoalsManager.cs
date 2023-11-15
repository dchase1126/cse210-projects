using System.Security.Cryptography.X509Certificates;

public class GoalsManager  //The Goals Manager is to keep track of the goals and scores. Which means once a goal is created you add the goal to the goal list.

{
    private int _score;
    private List<Goal> _goals = new List<Goal>();


    public void AddGoal()
    {
        // get the users choice
        int _choice2 = 0;
        string _menuChoice = Console.ReadLine();
        _choice2 = int.Parse(_menuChoice);

        Console.WriteLine("1. Create a Simple Goal");
        Console.WriteLine("2. Create a Eternal Goal");
        Console.WriteLine("3. Create a Checklist Goal");
        Console.WriteLine("4. Create a Fitness Goal");

        switch (_choice2)
        {
            case 1:  // Create a Simple Goal

                Console.WriteLine("What is the Name of your Goal?");
                string description = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                string name = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("Did You complete this Goal?");
                bool isComplete = bool.Parse(Console.ReadLine());


                SimpleGoal simple = new SimpleGoal(description, name, points, isComplete);
                _goals.Add(simple);

                break;

            case 2:  // Create a Eternal Goal

                Console.WriteLine("What is the Name of your Goal?");
                string description2 = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                string name2 = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                int points2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Did You complete this Goal?");
                bool isComplete2 = bool.Parse(Console.ReadLine());

                EternalGoal eternal = new EternalGoal(description2, name2, points2, isComplete2);
                _goals.Add(eternal);

                break;

            case 3: // Create a Checklist Goal

                Console.WriteLine("What is the Name of your Goal?");
                string description3 = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                string name3 = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                int points3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Did You complete this Goal?");
                bool isComplete3 = bool.Parse(Console.ReadLine());
                Console.WriteLine("What is your target?");
                int target3 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your current goal?");
                int current3 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your Bonus?");
                int bonus3 = int.Parse(Console.ReadLine());

                ChecklistGoal checklist = new ChecklistGoal(description3, name3, points3, isComplete3, target3, current3, bonus3);
                _goals.Add(checklist);

                break;

            case 4: // Create a Fitness Goal

                Console.WriteLine("What is the Name of your Goal?");
                string description4 = Console.ReadLine();
                Console.WriteLine("Describe your Goal?");
                string name4 = Console.ReadLine();
                Console.WriteLine("How many Points is this Goal worth?");
                int points4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Did You complete this Goal?");
                bool isComplete4 = bool.Parse(Console.ReadLine());
                Console.WriteLine("What is your target?");
                int targetWeight4 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your current goal?");
                int currentWeight4 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your Bonus weight?");
                int bonus4 = int.Parse(Console.ReadLine());
                Console.WriteLine("How may Reps do you want to do?");
                int reps4 = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Sets do you want to do?");
                int sets4 = int.Parse(Console.ReadLine());

                FitnessGoal fitness = new FitnessGoal(description4, name4, points4, isComplete4, bonus4, targetWeight4, currentWeight4, reps4, sets4);
                _goals.Add(fitness);

                break;

            default:
                Console.WriteLine("In valid input. Please Choose 1-4");
                break;
        }
        
        
    }

    public virtual void RecordEvent(){}

    public void Save(string filename){}

    public void Load(string filename){}

    public virtual void DisplayGoal(){}
        

        






      
}

// Ideas
// Make a list of 4-6 lifting exercise goals. (Bench Press, Squats, Leg Press, Bicep Curls, Tricep Extentions, Shoulder Press )
// Give a point value for amount of weight lifted or sets for specific exercise. 
// Give points for completing sets of exercise.
// Make progress towards a larger lifting goal and getting a value for working towards it.

public class FitnessGoal : Goal //Inheritance - derived or sub class
{
    private int _targetWeight;
    private int _currentWeight;
    private int _reps;
    private int _sets;
    private int _bonus;

    // constructor    
    public FitnessGoal(string name, string description, int points, int targetWeight, int reps, int sets, int bonus) : base(name, description, points)
    {
        _targetWeight = targetWeight;
        _currentWeight = 0;
        _reps = reps;
        _sets = sets;
        _bonus = bonus;
    }
    public FitnessGoal(string name, string description, int points, bool isComplete, int currentWeight, int targetWeight, int reps, int sets, int bonus) : base(name, description, points, isComplete)
    {
        _targetWeight = targetWeight;
        _currentWeight = currentWeight;
        _reps = reps;
        _sets = sets;
        _bonus = bonus;
    }

    // METHODS
    public override int RecordEvent()  //Polymorphism
    {
        Console.WriteLine($"What is your current lifting weight?"); 
        _currentWeight = int.Parse(Console.ReadLine());

        if (_currentWeight >= _targetWeight)
        {
            _isComplete = true;

            Console.WriteLine($"Congratulations you completed the goal and earned {_points + _bonus} points!");

            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"You have earned {_points} points!");

            return _points;
        }

    }


    public override string GetSaveString()  //Polymorphism
    {
        return $"Fitness|{_name}|{_description}|{_points}|{_isComplete}|{_currentWeight}|{_targetWeight}|{_sets}|{_reps}|{_bonus}";
    }

    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()}\tCurrent Weight: {_currentWeight}/{_targetWeight}\n\tSet: {_sets}\n\tReps: {_reps}\n";

    }

}

// Exceeding Requirments by.....  
// Add additional kinds of goals, such as the ability to make progress towards a large goal 
// (such as getting value for working towards running a marathon), or "negative goals" where they lose points for bad habits.  
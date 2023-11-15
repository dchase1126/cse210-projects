// Make a list of 4-6 lifting exercise goals. (Bench Press, Squats, Leg Press, Bicep Curls, Tricep Extentions, Shoulder Press )
// Give a point value for amount of weight lifted or sets for specific exercise. 
// Give points for completing sets of exercise.
// Make progress towards a larger lifting goal and getting a value for working towards it.

public class FitnessGoal : Goal //Inheritance - derived or sub class
{
    private List<FitnessGoal> _liftingGoals = new List<FitnessGoal>();

    private int _targetWeight; 
    private int _currentWeight;
    private int _reps;
    private int _sets;


    // constructor
    public FitnessGoal(string description, string name, int points, bool isComplete, int bonus, int targetWeight, int currentWeight, int reps, int sets) : base(description, name, points, isComplete)
    {

    }

    public override int RecordEvent()  //Polymorphism
    {
        return 0;
    }


    public override string GetSaveString()  //Polymorphism
    {
        return "${}";
    }

}

// Exceeding Requirments by.....  
// Add additional kinds of goals, such as the ability to make progress towards a large goal 
// (such as getting value for working towards running a marathon), or "negative goals" where they lose points for bad habits.  
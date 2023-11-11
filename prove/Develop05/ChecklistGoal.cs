public class ChecklistGoal : Goal //Inheritance - derived or sub class
{
    private int _target;
    private int _current;
    private int _bonus;

    // constructor
    public ChecklistGoal(string description, string name, int points, bool isComplete, int target, int current, int bonus) : base(description, name, points, isComplete)
    {
        _target = target;
        _current = current;
        _bonus = bonus;
    }


   /* public override string DisplayGoal()
    {

        Console.WriteLine($"{_name} - {_description} | Points: {_points}");
    }*/
    public override string GetSaveString()  //Polymorphism
    {
        return "${}";
    }
}
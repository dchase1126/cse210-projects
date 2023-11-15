using System.Security.Cryptography.X509Certificates;

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

    public override int RecordEvent()  //Polymorphism
    {
        return 0;
    }

    public override string GetSaveString()  //Polymorphism
    {
        return "${}";
    }

    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()}\tBonus: {_bonus}\n\tProgress: [{_current}/{_target}]";
    }

}
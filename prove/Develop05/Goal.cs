using System;
using System.IO;
public abstract class Goal  //base/super class
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;


    public bool IsComplete { get { return _isComplete; } }
    public string Name { get { return _name; } }


    // constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }


    public virtual string DisplayGoal()  //polymorphism
    {
        return $"[{GetIsCompleteChar()}] {_name} - {_description}\n\tPoints: {_points}\n";
    }
    private char GetIsCompleteChar()
    {
        if (_isComplete)
            return 'X';
        else
            return ' ';
    }

    public abstract int RecordEvent(); //polymorphism

    public abstract string GetSaveString(); //polymorphism

}

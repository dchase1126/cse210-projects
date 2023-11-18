using System;
using System.IO;

public class ChecklistGoal : Goal //Inheritance - derived or sub class
{
    private int _target;
    private int _current;
    private int _bonus;

    // constructor 
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, bool isComplete, int current, int target, int bonus) : base(name, description, points, isComplete)
    {
        _target = target;
        _current = current;
        _bonus = bonus;
    }

    public override int RecordEvent()  //Polymorphism
    {
        _current++;

        if (_current == _target)
        {
            _isComplete = true;
            Console.WriteLine($"You completed the goal and earned {_points + _bonus} points!");
            return _points + _bonus;
        }

        else
        {
            Console.WriteLine($"You earned {_points} points!");
            return _points;
        }
    }

    public override string GetSaveString()  //Polymorphism
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_isComplete}|{_current}|{_target}|{_bonus}";
    }

    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()}\tBonus: {_bonus}\n\tProgress: [{_current}/{_target}]";
    }

}
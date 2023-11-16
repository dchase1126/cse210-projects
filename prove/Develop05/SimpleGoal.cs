public class SimpleGoal : Goal //Inheritance - derived or sub class
{

    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoal(string name, string description, int points, bool iscomplete) : base(name, description, points, iscomplete)
    {

    }

    public override int RecordEvent()  //Polymorphism
    {
        _isComplete = true;
        Console.WriteLine($"Awesome Job! You earned {_points} points!");
        return _points;
        
    }

    public override string GetSaveString()//Polymorphism
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }

}

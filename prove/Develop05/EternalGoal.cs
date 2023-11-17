public class EternalGoal : Goal // Inheritance - derived or sub class
{

    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()  //Polymorphism
    {
        Console.WriteLine($"Congrats, you earned {_points} points!");
        return _points;
    }
    public override string GetSaveString()  //Polymorphism
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }

}
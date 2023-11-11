
public abstract class Goal  //base super class
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    // constructor
    public Goal(string name, string description, int points, bool isComplete )
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }


    public abstract string GetSaveString();
{
    return 0;
}

    //public virtual string DisplayGoal();
   /* {
    Console.WriteLine($"{_name} - {_description} | Points: {_points}");
    }*/

}

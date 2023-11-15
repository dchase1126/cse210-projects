
public abstract class Goal  //base super class
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;


    // constructor
    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }


    public virtual string DisplayGoal()
    {
        return $"[{GetIsCompleteChar()}] {_name} - {_description}\n\tPoints: {_points}\n";
    }
    private char GetIsCompleteChar()
    {
        if(_isComplete)
            return 'X';
        else
            return ' ';
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    
    public abstract int RecordEvent();
    public abstract string GetSaveString();

}

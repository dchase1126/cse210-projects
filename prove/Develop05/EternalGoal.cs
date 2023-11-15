public class EternalGoal : Goal // Inheritance - derived or sub class
{

    // constructor
    public EternalGoal(string description, string name, int points, bool isComplete) : base(description, name, points, isComplete)
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
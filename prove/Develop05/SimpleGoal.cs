public class SimpleGoal : Goal //Inheritance - derived or sub class
{

// constructor
    public SimpleGoal(string description, string name, int points, bool isComplete) : base(description, name, points, isComplete)
    {
       
    }

    //public int RecordEvent()

    public override string GetSaveString()//Polymorphism
    {
        return "${}";
    }

}

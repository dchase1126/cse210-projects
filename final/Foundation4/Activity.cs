using System.Data;
public abstract class Activity  //base or super class 
{
    protected float _activeTime;
   
    private DateTime _dateTime;

    // constructor
    public Activity(float activeTime, DateTime dateTime)
    {
        _activeTime = activeTime;
        _dateTime = dateTime;
    }

    // Methods

    public string GetDate()
    {
        return $"{_dateTime.ToShortDateString()}";
    }

    //polymorphism
    public abstract float GetSpeed();
    
    public abstract float GetPace(); 

    public abstract float GetDistance(); 

    public virtual string GetSummary()  
    {
         return $"{GetDate()} Running: ({_activeTime} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}
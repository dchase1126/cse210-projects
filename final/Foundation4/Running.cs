public class Running : Activity  // Inhertitance - derived or sub class
{
    private float _distance;  //Encapsulation

    // constructor
    public Running(float activeTime, DateTime dateTime, float distance) : base(activeTime, dateTime)
    {
        _distance = distance;
    }

    // Methods
    public override float GetDistance() //polymorphism 
    {
        return _distance;
    }
    public override float GetSpeed() //polymorphism
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return _distance / _activeTime * 60f;
    }
    public override float GetPace()  //polymorphism  
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _activeTime / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running: ({_activeTime} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph,  Pace: {GetPace()} min per mile";
    }
}
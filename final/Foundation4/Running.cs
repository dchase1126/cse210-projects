public class Running : Activity  // derived or sub class
{
    private float _distance;

    // constructor
    public Running(float activeTime, DateTime dateTime, float numLaps, float speed, float distance) : base(activeTime, dateTime)
    {
        _distance = distance;
        
    }

    // Methods

    public override float GetSpeed() //polymorphism
    {
         //Speed (mph or kph) = (distance / minutes) * 60
        return 20f / 60f * 60f; 
    }

    public override float GetPace()   //polymorphism
    {
        // Pace (min per mile or min per km)= minutes / distance
        return 60 / 10; 
    }

     public override float GetDistance()
    {
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return 5f * 50 / 1000f * 0.62f;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running: ({_activeTime} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph,  Pace: {GetPace()} min per mile";
    }
    

}
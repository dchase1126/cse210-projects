public class Cycling : Activity  // derived or sub class
{
    private float _speed;

    // constructor
    public Cycling(float activeTime, DateTime dateTime, float speed ) : base(activeTime, dateTime)
    {
        _speed = speed;
    }

    // Methods

    public override float GetPace()   //polymorphism
    {
        // Pace (min per mile or min per km)= minutes / distance
        return 60 / 10;  
    }

    public override float GetDistance()  //polymorphism
    {
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return 5f * 50 / 1000f * 0.62f;
    }

    public override float GetSpeed() //polymorphism
    {
       //Speed (mph or kph) = (distance / minutes) * 60
        return 20f / 60f * 60f; 
    }

    public override string GetSummary()
    { 
         return $"{GetDate()} Cycling: ({_activeTime} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph,  Pace: {GetPace()} min per mile";
    }




}
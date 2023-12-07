public class Swimming : Activity  // derived or sub class
{
    private float _numLaps;

    // constructor
    public Swimming(float activeTime, DateTime dateTime, float numLaps) : base(activeTime, dateTime)
    {
        _numLaps = numLaps;
    }

    // Methods
    public override float GetSpeed() //polymorphism
    {
         //Speed (mph or kph) = (distance / minutes) * 60
        return 20f / 60f * 60f; 
    }
    public float GetnumLaps()
    {
        return _numLaps;
    }

    public override float GetPace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return 60 / 10; 
    }

    public override float GetDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return (_numLaps * 50f) / 1000f * 0.62f;
    }

    public override string GetSummary()
    {
        //return $"{GetDate()} Swimming: ({_activeTime}) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        return $"{GetDate()} Swimming: ({_activeTime} min) - Number of Laps: {GetnumLaps()}, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}
public class Swimming : Activity  // Inhertitance - derived or sub class
{
    private float _numLaps; //Enacapsulation

    // constructor
    public Swimming(float activeTime, DateTime dateTime, float numLaps) : base(activeTime, dateTime)
    {
        _numLaps = numLaps;
    }

    // Methods
    public float GetnumLaps()
    {
        return _numLaps;
    }
    public override float GetDistance()  //polymorphism
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return _numLaps * 50f / 1000f * 0.62f;
    }
    public override float GetSpeed() //polymorphism
    {
        //Speed = 60 / pace
        return 60 / GetPace();
    }
    public override float GetPace()  //polymorphism
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _activeTime / GetDistance(); /// round the number/////
    }
    public override string GetSummary()  //polymorphism
    {
        return $"{GetDate()} Swimming: ({_activeTime} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile, Number of Laps: {GetnumLaps()},";
    }
}
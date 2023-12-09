public class Cycling : Activity  // Inhertitance - derived or sub class
{
    private float _speed;  //Encapsulation

    // constructor
    public Cycling(float activeTime, DateTime dateTime, float speed) : base(activeTime, dateTime)
    {
        _speed = speed;
    }

    // Methods
    public override float GetSpeed() //polymorphism
    {
        return _speed;
    }
    public override float GetDistance()  //polymorphism
    {
        //return _activeTime * _speed / 60f;
        return _activeTime * GetSpeed() / 60f;
    }
    public override float GetPace()   //polymorphism
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _activeTime / GetDistance();
    }
    public override string GetSummary() // Polymorphism
    {
        return $"{GetDate()} Cycling: ({_activeTime} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph,  Pace: {GetPace()} min per mile";
    }
}
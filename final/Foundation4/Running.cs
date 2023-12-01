class Running : Activity
{
    private float _distance;

    // constructor
    public Running(float activeTime, string date, float distance) :base( activeTime, date)
    {
        _distance = distance;
    }

    
}
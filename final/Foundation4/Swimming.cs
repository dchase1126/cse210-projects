class Swimming : Activity
{
    private float _numLaps;

    public Swimming(float activeTime, string date, float numLaps) :base( activeTime, date)
    {
        _numLaps= numLaps; 
    }
}
class Cycling : Activity
{
    private float _speed;

    public Cycling(float activeTime, string date, float speed) :base( activeTime, date)
    {
        _speed = speed;
    }
}
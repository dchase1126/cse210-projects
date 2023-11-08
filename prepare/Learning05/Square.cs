
public class Square : Shape //derived or sub class
{
    private double _side;
   

    // constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()  
    {
        return _side * _side;
    }
}

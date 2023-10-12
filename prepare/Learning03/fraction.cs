public class Fraction
{
    //Attributes
    private int _top;
    private int _bottom;

    public int Top { get { return _top; } set { _top = value; } }  //getter and setters
    public int Bottom { get { return _bottom; } set { _bottom = value; } } //getter and setter

    //construcors
    public Fraction()
    {
        this.Top = 1;
        this.Bottom = 1;
    }
    public Fraction(int _top)
    {
        this.Top = _top;
        this.Bottom = 1;
    }
    public Fraction(int _top, int _bottom)
    {
        this.Top = _top;
        this.Bottom = _bottom;
    }

    // METHODS
    public string GetFractionString()
    {
        return $"{Top}/{Bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)Top / (double)Bottom;
    }
}
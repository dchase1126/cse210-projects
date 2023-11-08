

public abstract class Shape
{
    private string _color;

    // constructor
    public Shape(string color) 
    {
        _color = color;
    }

    public string GetColor()  
    {
        return _color;
    }

    public void SetColor(string color)
    {
         _color = color;
    }

   public abstract double GetArea();
    
}


// virtual GetArea()
//      return L x W

//  override GetArea()
//      

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Pink", 2, 4);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Yellow", 5);
        shapes.Add(shape3);

        foreach (Shape style in shapes)
        {
            string color = style.GetColor();

            double area = style.GetArea();

            Console.WriteLine($"The area is {area} and the color is {color}.");
        }

    }
}
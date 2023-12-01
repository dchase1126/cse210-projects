using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello! Welcome to 'Inheritance with Event Planning' final program.\n");

        Lectures lectures = new Lectures();
        Console.WriteLine(lectures.GetFullDetail());
    }
}
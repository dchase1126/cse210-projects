using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentFromUser = Console.ReadLine();
        int x = int.Parse(percentFromUser);
         
        if (x >= 90)
        {
            Console.WriteLine("A");   
        }
        else if (x >= 80)
        {
            Console.WriteLine("B");  
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");      
        }
        else if (x >= 60)
        {
            Console.WriteLine("D");           
        }
        else
        {
            Console.WriteLine("F");
        }

        if (x >= 70)
        {
            Console.Write("Congratulations you passed!");
        }
        else if (x <= 69)
        {
            Console.Write("You can do this! Keep trying!");
        }
    }
}
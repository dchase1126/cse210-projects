using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = PromptUserName;
        double userNumber = PromptUserNumber;

        // static void DisplayWelcome()
        Console.WriteLine("Welcome to the Program!");


        //static void PromptUserName(string userName)
        {
            Console.WriteLine("Please enter your name: ");
        }

        // static void PromptUserNumber(int userNumber)
        {
            Console.WriteLine("Please enter your favorite number: ");
        }

        //SquareNumber
        Console.WriteLine($"{userName} the square of your number is: {userNumber}");

        //DisplayResult


    }
}

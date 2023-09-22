using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    // Declare Variables
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    //Display Welcome Message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Prompt User for their Name
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    //Prompt User for a Number
    static int PromptUserNumber()
    {
        int number;
        Console.WriteLine("Please enter your favorite number: ");
        number = int.Parse(Console.ReadLine());

        return number;
    }

    //Square Number 
    static int SquareNumber(int number)    
    {
        int square = number * number; 
        return square;
     
    }

    //Display Results
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName} the square of your number is: {square}");
    }
 
}

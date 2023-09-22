using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = PromptUserName();
        Double userNumber = PromptUserNumber();
        DisplayWelcomeMessage();

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
        static Double PromptUserNumber()
        {
            Double number;
            Console.WriteLine("Please enter your favorite number: ");
            number = Double.Parse(Console.ReadLine());

            return number;
        }

        //Square Number
           

        //DisplayResult
            Console.WriteLine($"{userName} the square of your number is: {userNumber}");

    }
}

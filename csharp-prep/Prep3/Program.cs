using System;

class Program
{
    static void Main(string[] args) // Functions Methods Behaviours
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 100);
        int guess;

        do
        {
            Console.Write("What is your guess between 1-100? ");
            guess = int.Parse(Console.ReadLine());


            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        }
        while (guess != number);

        Console.WriteLine("You guessed it!");

    }
}
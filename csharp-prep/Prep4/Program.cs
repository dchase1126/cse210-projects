using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        List<double> numbers = new List<double>(); // [2, 5, 3, 4]
        double number;
        double sum = 0;
        double average;
        double largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (true)
        {
            Console.Write("Enter a number: ");
            number = double.Parse(Console.ReadLine());
            if (number == 0)
                break;
            numbers.Add(number);
        }

        foreach (double n in numbers)
        {
            sum += n; // sum = sum + n  
            if (n > largest)
                largest = n;
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    DateTime theCurrentTime = DateTime.Now;
    //string dateText = theCurrentTime.ToShortDateString();


    static void Main(string[] args)
    {
        // Journal object
        string choice = "";

        while (choice != "5")
        {
            // Display the menu options
            Console.WriteLine("   Journal Menu   ");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a New Journal Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Load Journal Entries");
            Console.WriteLine("4. Save Journal Entry");
            Console.WriteLine("5. Quit");

            choice = Console.ReadLine();

            // get the users choice
            int menuChoice = 0;
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine();
                    //Console.WriteLine(Journal.NewJournalEntry());
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Have a good day!");
                    break;

            }
        }
    }
}
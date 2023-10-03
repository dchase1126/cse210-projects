using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        string choice = "";
        string message = "\tHello!\nWelcome to your Journal. Please select fom the menu.\n\n\tJournal Menu";

        while (choice != "5")
        {
            // Display the menu options
            Console.WriteLine(message);
            Console.WriteLine("1. Write a New Journal Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Load Journal Entries");
            Console.WriteLine("4. Save Journal Entry");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nWhat would you like to do?");

            choice = Console.ReadLine();

            // get the users choice
            int menuChoice = 0;
            switch (menuChoice)
            {
                case 1:
                    journal.AddNewJournalEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    journal.LoadJournalFromFile();
                    break;
                case 4:
                    journal.SaveJournalToFile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose an option 1-5. Have a good day!");
                    break;

            }
        }
    }
}

// Exceeding requirements by adding a "Quote of the Day" in the program per "Save other information in the journal entry".
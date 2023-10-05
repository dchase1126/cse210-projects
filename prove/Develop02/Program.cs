using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuChoice = 0;
        string message = "Hello!\nWelcome to your Journal.\nPlease select fom the menu.\n\n\tJournal Menu";

        while (menuChoice != 5)
        {
            // Display the menu options
            Console.WriteLine(message);
            Console.WriteLine("1. Write a New Journal Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Load Journal Entries");
            Console.WriteLine("4. Save Journal Entry");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nWhat would you like to do?");


            // get the users choice
            string choice = Console.ReadLine();
            menuChoice = int.Parse(choice);


            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine(">");
                    journal.AddNewJournalEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    Console.WriteLine("What is the file you want to load? ");
                    string fileName = Console.ReadLine();
                    journal.LoadJournalFromFile(fileName);
                    break;
                case 4:
                    Console.WriteLine("Save Entry");
                    fileName = Console.ReadLine();
                    journal.SaveJournalToFile(fileName);
                    break;
                case 5:
                    Environment.Exit(0);
                    Console.WriteLine("Have a good day!");
                    break;
                default:
                    Console.WriteLine("Please choose an option 1-5.");
                    break;

            }
        }
    }
}

// Exceeding requirements by adding a "Quote of the Day" in the program per "Save other information in the journal entry".
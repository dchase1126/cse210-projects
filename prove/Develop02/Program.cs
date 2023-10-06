class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int _menuChoice = 0;
        string _message = "Hello!\nWelcome to your Journal.\nPlease select fom the menu.\n\n\tJournal Menu";

        while (_menuChoice != 5)
        {
            // Display the menu options
            Console.WriteLine(_message);
            Console.WriteLine("1. Write a New Journal Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Load Journal Entries");
            Console.WriteLine("4. Save Journal Entry");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nWhat would you like to do?\n");

            // get the users choice
            string _choice = Console.ReadLine();
            _menuChoice = int.Parse(_choice);

            switch (_menuChoice)
            {
                case 1:
                    journal.AddNewJournalEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    Console.WriteLine("What is the file you want to load? (myJournal.txt) ");
                    string _fileName = Console.ReadLine();
                    journal.LoadJournalFromFile(_fileName);
                    break;
                case 4:
                    Console.Write("Enter File name (myJournal.txt) ");
                    _fileName = Console.ReadLine();
                    journal.SaveJournalToFile(_fileName);
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

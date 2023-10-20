using System;
class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator SGen = new();
        Reference reference;
        Scripture scripture;

        string _message = "\nHello!\nWelcome to Scripture Memorizing!";
        Console.WriteLine(_message);
        Console.WriteLine("\nWhat scripture would you like to memorize?\n");

        // Display the menu options
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. John 13:34-35");
        Console.WriteLine("3. Proverbs 10:12");
        Console.WriteLine("4. John 15:13");


        // get the users choice
        int _choice = int.Parse(Console.ReadLine());
        string[] data = SGen.GetScripture(_choice - 1);
        if (data.Length == 4)
        {
            reference = new Reference(data[0], data[1], data[2]);
            scripture = new Scripture(data[3], reference);
        }
        else
        {
            reference = new Reference(data[0], data[1], data[2], data[3]);
            scripture = new Scripture(data[4], reference);
        }

        while (true)
        {
            Console.Clear();
            scripture.DisplayWords();

            Console.WriteLine("\n\nPress Enter to continue memorization or type 'Q' to exit?");

            string menuChoice = Console.ReadLine();
            // Check if all the words in the list are hidden. 
            if (menuChoice == "" && !scripture.WordsHidden())
            {
                // Hide Words
                scripture.HideWord();
            }
            else if (menuChoice == "")
            {
                // once all words are hidden =  Congratulations! end program
                scripture.WordsHidden();

                Console.Write("Congratulations! You finished memorizing this scripture!");
                Console.WriteLine("\nChose a new scripture to memorize!");
                break;
            }
            else if (menuChoice.ToUpper() == "Q")
            {
                break;
            }

        }
    }
}

// Exceeding Requirements
// 1. Added a seperate ScriptureGenerator.cs file to store a list of scriptures to pull from, 
// per the assignment "Have the program to load scriptures from a file or "Anything else you can think of!"
// 2. Added .ToUpper() == "Q" as a "catch" in case the user typed in a lower case q to still be accepted per the assignment "Anything else you can think of!"



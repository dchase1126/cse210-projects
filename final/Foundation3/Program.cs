using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello! Welcome to 'Inheritance with Event Planning' final program.\n");

        Lecture lecture = new Lecture("Test Lecture", "Test", new DateTime(2023, 12, 1, 12, 0, 0), new Address("123 Main Street", "Rexburg,", "ID", "USA"), "Mr. Parrish. ", 32);
        Console.WriteLine(lecture.GetFullDetail());
        Console.WriteLine(lecture.GetStandardDetail());
        Console.WriteLine(lecture.GetShortDescription());


        OutdoorGathering outdoorGathering = new OutdoorGathering("Play Date", "Playing at the Park with unlimited friends!", new DateTime(2023, 12, 1, 12, 0, 0), new Address("Hogan Park", "Woods Cross,", "UT", "USA"), "Sunny", 76, "No");
        Console.WriteLine(outdoorGathering.GetFullDetail());
        Console.WriteLine(outdoorGathering.GetStandardDetail());
        Console.WriteLine(outdoorGathering.GetShortDescription());


        Reception reception = new Reception("50th Wedding Reception", "Mr. and Mrs. Johnson's 50th Wedding Reception", new DateTime(2023, 12, 1, 12, 0, 0), new Address("454 Columbia River Ave", "Astoria,", "OR", "USA"), "party@gmail.com");
        Console.WriteLine(reception.GetfullDetail());
        Console.WriteLine(reception.GetStandardDetail());
        Console.WriteLine(reception.GetShortDescription());
    }

}

public class Journal
{

    private List<Entry> entries = new();
    public void AddNewJournalEntry()
    {
        Entry entry = new Entry();
        entry.Write();
        entries.Add(entry);
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayJournalEntry();
        }
    }


    //????????????????
    //SaveToFile(entries);  ???Where do I put this? jouDo I need this ?
    public void SaveJournalToFile(string fileName)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry);
                // You can add text to the file with the WriteLine method
                //outputFile.WriteLine("This will be the first line in the file.");
            }


            // You can use the $ and include variables just like with Console.WriteLine
            //string color = "Blue";
            //outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public void LoadJournalFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[0];
        }
    }


}
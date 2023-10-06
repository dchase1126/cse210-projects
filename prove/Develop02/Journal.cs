public class Journal
{
    private List<Entry> _entries = new();
    public void AddNewJournalEntry()
    {
        Entry _entry = new Entry();
        _entry.Write();
        _entries.Add(_entry);
    }
    public void DisplayJournalEntries()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.DisplayJournalEntry();
        }
    }

    private void ExecuteSave(string _fileName)
    {
        Console.WriteLine("Saving to file...");
        try
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName, true))
            {
                foreach (Entry _entry in _entries)
                {
                    outputFile.WriteLine($"{_entry.Date}|{_entry.Quote}|{_entry.Prompt}|{_entry.Response}");
                }
            }

            _entries.Clear();
        }
        catch
        {
            Console.WriteLine("Error: Unable to save to file.");
        }
    }
    
    public void SaveJournalToFile(string _fileName)
    {
        if (File.Exists(_fileName))
        {
            ExecuteSave(_fileName);
        }
        else
        {
            Console.WriteLine("File does not exist");
            Console.Write("Do you want to create a new file (Y/N)? ");
            string answer = Console.ReadLine();
            if(answer.ToUpper() == "Y")
                ExecuteSave(_fileName);
        }
    }

    public void LoadJournalFromFile(string _fileName)
    {
        Console.Write("Save all entries before loading. Press 'Enter' to continue or '0' to abort.\n> ");
        string userInput = Console.ReadLine();
        if (userInput == "0")
        {
            return;
        }
        else
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(_fileName);

            foreach (string _line in lines)
            {
                string[] parts = _line.Split("|");
                string _date = parts[0];
                string _quote = parts[1];
                string _prompt = parts[2];
                string _response = parts[3];

                Entry entry = new Entry(_date, _quote, _prompt, _response);
                _entries.Add(entry);
            }
        }
    }
}
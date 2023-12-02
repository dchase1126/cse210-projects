class Lecture : Event  //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{
    private string _speakerName;
    private int _capacity;

    // Constructor
    public Lecture(string eventTitle, string description, DateTime dateTime, Address address, string speakerName, int capacity) : base(eventTitle, description, dateTime, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    //Methods
    public string GetFullDetail()
    {
        return $"{GetStandardDetail()}Speaker: {_speakerName}\nCapacity: {_capacity}\n";
    }
}
class Event  //Inheritance -This is the parent, base  or Super class 
{
    private string _eventTitle;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    // Constructor
    public Event(string eventTitle, string description, DateTime dateTime, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    // Methods
    public string GetStandardDetail()
    {
        return $"{_eventTitle}\n{_dateTime.ToShortDateString()} @ {_dateTime.ToShortTimeString()} - {_description}\nAddress: {_address.GetAddressString()}\n";
    }
    public string GetShortDescription()
    {
        return $"{GetType()} - {_eventTitle} on {_dateTime.ToShortDateString()}\n";
    }
}
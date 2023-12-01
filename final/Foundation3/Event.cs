using Microsoft.VisualBasic;

class Event  //Inheritance -This is the parent, base  or Super class 
{
    private string _eventTitle;
    private string _description;
    private string _messagePrompt;
    private DateAndTime  _date; 
    private Address _address;
    private TimeOnly _time;

    // Constructors
    public Event(string eventTitle, string description, string messagePrompt)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._messagePrompt = messagePrompt;
        
    }

    // Methods
     public Address GetAddress() { return _address; }

    //public string GetEmailAddress() { return _email;}

    public string GetStandardDetail() 
    {
        return $"{_eventTitle} {_description} {_date} {_time} {_address}";
    }

    public string GetFullDetail() 
    {
        return $"{_eventTitle} {_description} {_time} {_address}";
    }

    public string GetShortDetail() 
    {
        return $"{_eventTitle} {_date}";
    } 

    //public void Display() {return}
}
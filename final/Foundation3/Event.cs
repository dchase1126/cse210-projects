using Microsoft.VisualBasic;

class Event
{
    private string _eventTitle;
    private string _description;
    private string _messagePrompt;
    private DateAndTime  _date; 
    private Address _address;
    private TimeOnly _time;

    Event(string eventTitle, string description, string messagePrompt)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._messagePrompt = messagePrompt;
        
    }


     public Address GetAddress() { return _address; }
}
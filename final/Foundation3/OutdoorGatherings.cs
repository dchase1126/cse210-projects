class OutdoorGatherings : Event   //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{
    private int _weather;

    // Constructors
    public OutdoorGatherings(string eventTitle, string description, string messagePrompt, int weather) : base(eventTitle, description, messagePrompt)
    {
        this._weather = weather;
    }

    
}
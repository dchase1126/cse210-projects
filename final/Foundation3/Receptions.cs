class Reception : Event  //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{
    private string _email;

    // Constructor
    public Reception(string eventTitle, string description, DateTime dateTime, Address address, string email) : base(eventTitle, description, dateTime, address)
    {
        _email = email;
    }

    // Method
    public string GetfullDetail()
    {
        return $"\n{GetStandardDetail()}RSVP: {_email}\n";
    }
}



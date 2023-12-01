class Receptions : Event  //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{
    private string _email;

    // Constructors
    public Receptions(string eventTitle, string description, string messagePrompt, string email) :base(eventTitle, description, messagePrompt)
    {
        this._email = email;
    }
    
}
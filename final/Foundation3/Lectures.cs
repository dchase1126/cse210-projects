class Lectures : Event  //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{
    private string _speakerName;
    private int _capacity;

    // Constructors
    public Lectures(string eventTitle, string description, string messagePrompt, string speakerName, int capacity) : base(eventTitle, description,  messagePrompt)
    {
        this._speakerName = speakerName;
        this._capacity = capacity;
    }

    //Methods
    public string GetSpeakerName()  ////????
    {
        return $"{_speakerName} {_capacity} {GetFullDetail()} ";
    }

    public void GetCapacity() ///????
    {
        int capacity = int.Parse(Console.ReadLine()); 
        
    }

    /* public string GetFullDetail() 
    {
        return $"{_speakerName} {_capacity}";
    }*/

}
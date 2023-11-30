class Address
{
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;

    //constructor
    public
    Address(string streetName, string city, string state, string country)
    {
        this._streetName = streetName;
        this._city = city;
        this._state = state;
        this._country = country;
    }
    // Methods
    public void Display()
    {
        Console.WriteLine($"{_streetName} {_city} {_state} {_country}");
    }

    public bool GetUSA()
    {
        return _country == "USA";
    }

    public string GetAddressString()
    {
        return $"{_streetName} {_city} {_state} {_country}";
    }

}
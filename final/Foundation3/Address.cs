class Address
{
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;

    //contructor
    public
    Address(string streetName, string city, string state, string country)
    {
        _streetName = streetName;
        _city = city;
        _state = state;
        _country = country;
    }

    //method
    public string GetAddressString()
    {
        return $"{_streetName} {_city} {_state} {_country}";
    }

}
class OutdoorGathering : Event   //Inheritance - This is the child, derived or Sub class : parent, base  or Super class 
{
    private string _weather;
    private int _temperature;
    private string _rain;

    // Constructor
    public OutdoorGathering(string eventTitle, string description, DateTime dateTime, Address address, string weather, int temperature, string rain) : base(eventTitle, description, dateTime, address)
    {
        _weather = weather;
        _temperature = temperature;
        _rain = rain;
    }

    // Method
    public string GetFullDetail()
    {
        return $"{GetStandardDetail()}Forecast:\n\tWeather: {_weather}\n\tTemperature: {_temperature} Degrees\n\tExpecting Rain: {_rain}\n";
    }

}
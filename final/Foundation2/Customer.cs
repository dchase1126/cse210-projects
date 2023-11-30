class Customer
{
    private string _custName;
    private Address _address;

    //constructor
    public Customer(string custName, Address address)
    {
        _custName = custName;
        _address = address;
    }

    public Address GetAddress() { return _address; }

    public string GetName() { return _custName; }

    public bool GetUSA()
    {
        return _address.GetUSA();
    }
}
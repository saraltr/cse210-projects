public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsCountryUSA()
    {
        return _address.CheckCountry();
    }
    public string GetName()
    {
        return _name;
    }

    public string GetAdress()
    {
        return _address.GetFullAddress();
    }
}
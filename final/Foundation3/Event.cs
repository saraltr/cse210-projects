public abstract class Event
{
    private string _type;
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;

    // address info
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    // constructor
    public Event(string type, string title, string description, DateTime date, TimeSpan time, string street, string city, string state, string zipCode)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public virtual void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToString()}\nAddress: {GetAddressString()}");
    }



    public virtual void FullDetails()
    {
        StandardDetails();
    }

    public void ShortDescription()
    {
        Console.WriteLine("Short description");
        Console.WriteLine($"Type: {_type}\nTitle: {_title}\nDate: {_date.ToShortDateString()}");
    }

    private string GetAddressString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}
public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, DateTime date, TimeSpan time, string street, string city, string state, string zipCode, string rsvp)
        : base("Reception", title, description, date, time, street, city, state, zipCode)
    {
        _rsvp = rsvp;
    }

    public override void FullDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Full details");
        base.FullDetails();
        Console.WriteLine($"RSVP: {_rsvp}");
        Console.WriteLine();
    }
}
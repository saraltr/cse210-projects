public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, string street, string city, string state, string zipCode, string speaker, int capacity)
        : base("Lecture", title, description, date, time, street, city, state, zipCode)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Full details");
        base.FullDetails();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
        Console.WriteLine();
    }
}
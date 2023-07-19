public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, string street, string city, string state, string zipCode, string weatherForecast)
        : base("Outdoor Gathering", title, description, date, time, street, city, state, zipCode)
    {
        _weatherForecast = weatherForecast;
    }

    public override void FullDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Full details");
        base.FullDetails();
        Console.WriteLine($"Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}");
        Console.WriteLine();
    }
}
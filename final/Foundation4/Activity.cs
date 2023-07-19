public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;
    private string _type;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }
    public void SetActivityName(string activityName)
    {
        _type = activityName;
    }
    public string GetActivityType()
    {
        return _type;
    }

    public int GetMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = GetActivityType();
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        // sets default distance, speed, and pace units to miles
        string distanceUnit = "miles";
        string speedUnit = "mph";
        string paceUnit = "min/mile";

        // creates the summary in the desired format
        return $"{_date:dd MMM yyyy} {activityType} ({_lengthInMinutes} min) - " +
        $"Distance: {distance:F1} {distanceUnit}, Speed: {speed:F1} {speedUnit}, Pace: {pace:F1} {paceUnit}";
    }
}
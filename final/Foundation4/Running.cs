public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        this.SetActivityName("Running");
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetMinutes() / 60.0);
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        this.SetActivityName("Swimming");
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetMinutes() / 60.0);
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
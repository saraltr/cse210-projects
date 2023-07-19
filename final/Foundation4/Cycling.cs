public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        // sets the activity name
        this.SetActivityName("Cycling");
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}
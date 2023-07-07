public class EternalGoal : Goal
{
        private string _type = "Eternal Goal";

    public EternalGoal(string name = "", string description = "", int points = 0, bool complete = false)
        : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        IsComplete();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        string representation = $"{_type}: {GetName()}, {GetDescription()}, Points: {GetPoints()}, Completed: {IsComplete()}";
        return representation;
    }
}
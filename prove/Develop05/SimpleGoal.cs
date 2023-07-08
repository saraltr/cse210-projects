public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _type = "Simple Goal";

    public SimpleGoal(string name = "", string description = "", int points = 0, bool complete = false)
        : base(name, description, points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        // mark the goal as complete
        _isComplete = true;
    }

    public override bool IsComplete()
    {   
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"{_type}: {GetName()}, {GetDescription()}, Points: {GetPoints()}, Completed: {IsComplete()}";
        return representation;
    }
}

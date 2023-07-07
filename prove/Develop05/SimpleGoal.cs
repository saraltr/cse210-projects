public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
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
        string representation = $"Simple Goal:{GetName()}, {GetDescription()}, Points: {GetPoints()}, Completed: {IsComplete()}";
        return representation;
    }

    public override void CreatGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        SetGoalName(goalName);
        Console.WriteLine();
        Console.Write("What is a Short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);
    }
}

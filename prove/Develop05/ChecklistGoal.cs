public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private string _type = "Checklist Goal";

    public ChecklistGoal(string name = "", string description = "", int points = 0, int target = 0, int bonus = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        // increases the amount of the times the goal was completed everytime the RecordEvent() is called
        _amountCompleted++;

        // check if the target is achieved
        if (_amountCompleted >= _target)
        {
            // add the bonus points if the target is achieved
            SetPoints(_bonus);
            IsComplete();
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        string completionStatus = (_amountCompleted >= _target) ? "true" : "false";
        string representation = $"{_type}: {GetName()}, {GetDescription()}, Points: {GetPoints()}, Completed: {completionStatus}, Number of times completed: {_amountCompleted}/{_target}";
        return representation;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus?");
        int.TryParse(Console.ReadLine(), out int target);
        _target = target;

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int.TryParse(Console.ReadLine(), out int bonus);
        _bonus = bonus;
    }
    public override string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "[x]" : "[ ]";
        string details = $"{statusSymbol} {GetName()} ({GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{_target}, Bonus points: {_bonus}";
        return details;
    }
}
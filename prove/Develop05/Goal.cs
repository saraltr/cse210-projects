public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    // constructor
    public Goal(string name = "", string description = "", int points = 0)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void SetGoalName(string name)
    {
        _shortName = name;
    }

    public string GetName()
    {
        return _shortName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[x]" : "[ ]";
        string details = $"{completionStatus} {_shortName} ({_description}) ";
        return details;
    }
    public abstract string GetStringRepresentation();
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());

        Console.Write("What is a short description of it? ");
        SetDescription(Console.ReadLine());

        Console.Write("How many points is the goal worth? ");
        int.TryParse(Console.ReadLine(), out int points);
        SetPoints(points);
    }
    
}
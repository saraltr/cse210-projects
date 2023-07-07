public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    // constructor
    public Goal(string name, string description, int points)
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

    public void SetPoins(int points)
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
        string details = $"[ ] {_shortName} ({_description}) ";
        return details;
    }
    public abstract string GetStringRepresentation();
    public abstract void CreatGoal();
    
}
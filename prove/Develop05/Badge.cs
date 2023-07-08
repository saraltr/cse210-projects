public class Badge
{
    private string _id;
    private string _name;
    private string _description;

    public Badge(string id, string name, string description)
    {
        _id = id;
        _name = name;
        _description = description;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    public string GetId()
    {
        return _id;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

}
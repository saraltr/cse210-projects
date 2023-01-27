public class Entry
{
    public string _userEntry;
    public string _date;
    public string _question;
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_question} - Entry: {_userEntry}");
    }
}
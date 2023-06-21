public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // constructor with 3 parameters
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // constructor with 4 parameters
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // method to display the reference in the console
    public void DisplayReference()
    {
        if (_endVerse != 0)
        {
            Console.WriteLine(_book + " " + _chapter + ":" + _verse + "-" + _endVerse);
        }
        else
        {
            Console.WriteLine(_book + " " + _chapter + ":" + _verse);
        }
    }

}
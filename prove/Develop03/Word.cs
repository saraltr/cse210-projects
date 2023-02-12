public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            return "*";
        }
        else
        {
            return _word;
        }
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public void UnhideWord()
    {
        _hidden = false;
    }
}

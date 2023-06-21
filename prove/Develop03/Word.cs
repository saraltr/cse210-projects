class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        this._word = word;
        this._hidden = false;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            return "_";
        }
        return _word;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public void UnhideWord()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}
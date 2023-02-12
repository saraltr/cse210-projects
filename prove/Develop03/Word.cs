class Word
{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        this.hidden = false;
    }

    public string GetWord()
    {
        if (hidden)
        {
            return "_";
        }
        return word;
    }

    public void HideWord()
    {
        hidden = true;
    }

    public void UnhideWord()
    {
        hidden = false;
    }

    public bool IsHidden()
    {
        return hidden;
    }
}

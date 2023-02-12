class Scripture
{
    private Reference _reference;
    private List<Word> text;
    private int hiddenWordCount = 0;

    private static readonly Random random = new Random();

    public Scripture(Reference reference, List<string> text)
    {
        this._reference = reference;
        this.text = new List<Word>();
        foreach (string line in text)
        {
            string[] lineWords = line.Split(' ');
            foreach (string word in lineWords)
            {
                this.text.Add(new Word(word));
            }
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.ToString());
        foreach (Word word in text)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        int numberOfWordsToHide = random.Next(1, text.Count - hiddenWordCount + 1);
        int count = 0;
        while (count < numberOfWordsToHide)
        {
            int index = random.Next(0, text.Count);
            if (!text[index].IsHidden())
            {
                text[index].HideWord();
                hiddenWordCount++;
                count++;
            }
        }
    }


    public bool AllWordsHidden()
    {
        return hiddenWordCount >= text.Count;
    }
}

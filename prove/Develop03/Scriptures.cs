class Scripture
{
    private Reference _reference;
    private List<Word> _text;
    private int hiddenWordCount = 0;

    private static readonly Random random = new Random();

    // Constructor
    public Scripture(Reference reference, List<string> text)
    {
        this._reference = reference;
        this._text = new List<Word>();
        foreach (string line in text)
        {
            string[] lineWords = line.Split(' ');
            foreach (string word in lineWords)
            {
                this._text.Add(new Word(word));
            }
        }
    }

    // Method to display the scripture in the console
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.ToString());
        foreach (Word word in _text)
        {
            Console.Write(word.GetWord() + " "); // adds spaces between the words
        }
        Console.WriteLine();
    }

    // Method to hide words in the scripture text
    public void HideWords()
    {
        int numberOfWordsToHide = random.Next(1, _text.Count - hiddenWordCount + 1);
        int count = 0;
        while (count < numberOfWordsToHide)
        {
            int index = random.Next(0, _text.Count);
            if (!_text[index].IsHidden())
            {
                _text[index].HideWord();
                hiddenWordCount++;
                count++;
            }
        }
    }

    // Method to check if all words have been hidden
    public bool AllWordsHidden()
    {
        return hiddenWordCount >= _text.Count;
    }
}
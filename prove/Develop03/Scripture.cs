class Scripture
{
    private Reference reference;
    private List<string> text;
    private List<string> words;
    private int hiddenWordCount = 0;
    private static readonly Random random = new Random();

    public Scripture(Reference reference, List<string> text)
    {
        this.reference = reference;
        this.text = text;
        this.words = GetWords();
    }

    public int GetHiddenWordCount()
    {
        return hiddenWordCount;
    }

    public int GetWordCount()
    {
        return words.Count;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference.ToString());
        foreach (string line in text)
        {
            Console.WriteLine(line);
        }
    }

    public void HideWords()
    {
        int index = random.Next(0, words.Count);
        words[index] = new string('_', words[index].Length);
        hiddenWordCount++;
    }

    private List<string> GetWords()
    {
        List<string> words = new List<string>();
        foreach (string line in text)
        {
            string[] lineWords = line.Split(' ');
            foreach (string word in lineWords)
            {
                words.Add(word);
            }
        }

        return words;
    }
}

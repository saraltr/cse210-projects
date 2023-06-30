public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    // list to keep track of used prompts
    private List<string> _usedPrompts = new List<string>();
    // list to keep track of used questions
    private List<string> _usedQuestions = new List<string>();

    // constructor
    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        // random prompt for reflection
        DisplayPrompt();
        Console.Write("When you have something in mind, press enter to continue ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions, as they relate to this experience");
        Console.Write("You may begin in: ");
        // countdown before starting the questions
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Clear();
        DisplayQuestions();
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomNum = new Random();
        // get a random index within the range of available prompts
        int rndIndex = randomNum.Next(0, _prompts.Count);
        // get the random prompt at the selected index
        string randomPrompt = _prompts[rndIndex];
        // remove the prompt from the list of available prompts
        _prompts.RemoveAt(rndIndex);
        // add the used prompt to the list of used prompts
        _usedPrompts.Add(randomPrompt);
        // if all prompts have been used, reset the list
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomNum = new Random();
        int rndIndex = randomNum.Next(0, _questions.Count);
        string randomQuestion = _questions[rndIndex];
        _questions.RemoveAt(rndIndex);
        _usedQuestions.Add(randomQuestion);
        if (_questions.Count == 0)
        {
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        
        // get random prompt
        string currentPrompt = GetRandomPrompt();
        Console.WriteLine($"-- {currentPrompt} --");
    }

    public void DisplayQuestions()
    {
        int duration = GetDuration();
        int questionIndex = 0;

        while (duration > 0)
        {
            string randomQuestion = GetRandomQuestion();
            Console.WriteLine();
            Console.WriteLine($"Question {questionIndex + 1}:");
            Console.Write($"{randomQuestion} ");

            // calculate the time to display the question
            int questionDuration = Math.Min(duration, 5);

            // show spinner for the remaining question duration
            ShowSpinner(questionDuration);

            // update the remaining duration
            duration -= questionDuration;

            // break the loop if the total duration is reached
            if (duration <= 0)
                break;

            questionIndex++;
        }
    }
}

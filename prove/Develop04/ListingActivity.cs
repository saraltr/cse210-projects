public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");

        // get a random prompt
        string currentPrompt = GetRandomPrompt();
        Console.WriteLine(currentPrompt);

        Console.Write("You may begin in: ");
        // countdown before starting the questions
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

        // get the list of the user's responses
        List<string> userResponses = new List<string>();
        userResponses = GetListFromUser();
        _count = userResponses.Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
    
    public string GetRandomPrompt()
    {
        Random randomNum = new Random();
        int listSize = _prompts.Count;
        int rndIndex = randomNum.Next(0, listSize);
        string prompt = _prompts[rndIndex];
        return $"-- {prompt} --";
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();

        int duration = GetDuration();
        while (duration > 0)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            // add each response to the userResponses list
            userResponses.Add(response);

            // calculate the time to display the prompt
            int promptDuration = Math.Min(duration, 5);
            duration -= promptDuration;

            if (duration <= 0)
                break;
        }
        
        return userResponses;
    }
}
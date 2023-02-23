public class Activity
{
    protected int _duration;
    protected int _description;
    protected string _activityName;
    private int _initialPauseDuration;
    private int _finalPauseDuration;
    protected string _endingMessage;
    List<string> _descriptions = new List<string> {
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };


    public Activity(int duration, int description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage)
    {
        _duration = duration;
        _description = description;
        _activityName = activityName;
        _initialPauseDuration = initialPauseDuration;
        _finalPauseDuration = finalPauseDuration;
        _endingMessage = endingMessage;
    }

    public void DisplayStartingMessage(int description)
    {
        Console.WriteLine(_descriptions[description]);
    }

    public void DisplayHoldAnnimation(int duration)
    {
        var startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        while ((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) - startTime < duration)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void InitialPause()
    {
        DisplayHoldAnnimation(_initialPauseDuration * 1000);
    }

    public void Start()
    {
        InitialPause();
        DisplayStartingMessage(_description);
    }

    public void EndingMessage()
    {
        Console.WriteLine(_endingMessage);
        Console.WriteLine($"You have completed the {_activityName} activity. Take a moment to reflect on your experience and how you can use what you learned in your daily life.");
        DisplayHoldAnnimation(_finalPauseDuration * 1000);
    }
}

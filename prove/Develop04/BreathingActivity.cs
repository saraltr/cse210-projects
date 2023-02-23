public class BreathingActivity : Activity
{
    private int _breatheInSeconds;
    private int _breatheOutSeconds;

    public BreathingActivity(int duration, int description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage, int breathIn, int breathOut) : base(duration, description, activityName, initialPauseDuration, finalPauseDuration, endingMessage)
    {
        _breatheInSeconds = breathIn;
        _breatheOutSeconds = breathOut;
    }

    public void BreathAcivityStart()
    {
        Console.WriteLine("How long do you want to do the breathing exercise for? (in seconds)");
        int duration = Int32.Parse(Console.ReadLine());

        int breathCount = duration / (_breatheInSeconds + _breatheOutSeconds);

        Console.WriteLine("Get ready to start!");

        InitialPause();

        for (int i = 0; i < breathCount; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(_breatheInSeconds);
            Console.WriteLine("Breathe out...");
            Countdown(_breatheOutSeconds);
        }

        EndingMessage();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

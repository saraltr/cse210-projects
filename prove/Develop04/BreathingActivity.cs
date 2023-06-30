public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this.SetActivityName("Breathing Activity");
        this.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = this.GetDuration() / 6;
        for (int i = 0; i <=2; i ++)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(interval);
            Console.Write("Breathe out...");
            ShowCountDown(interval);
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}
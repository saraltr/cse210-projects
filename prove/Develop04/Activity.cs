using System.Collections.Generic;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _spinnerCounter;
    public Activity()
    {
        _spinnerCounter = _duration = 0;
    }

    public void SetActivityName(string activityName)
    {
        _name = activityName;
    }

    public void SetDescription(string description)
    {
        _description = description;
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.WriteLine($"How long do you want to do the {_name} exercise for? (in seconds)");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> annimationStrings = new List<string>()
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string a = annimationStrings[i];
            Console.Write(a);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= annimationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public string GetName()
    {
        return _name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write(string.Format("{0}", i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.WriteLine(" ");
    }

}
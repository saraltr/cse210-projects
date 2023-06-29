using System;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _spinnerCounter;

    // constuctor
    // public Activity(string name, string description, int duration)
    // {
    //     _name = name;
    //     _description = description;
    //     _duration = duration = 0;
    // }

    public Activity(){

        _spinnerCounter = _duration = 0;
    }

    public void SetActivityName(string activityName)
    {
        _name = activityName;
    }

    public void SetDescription(string description)
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.WriteLine("How long do you want to do the breathing exercise for? (in seconds)");
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
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} of the {_name}");


    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("'\'");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.WriteLine("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.WriteLine("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.WriteLine("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.WriteLine("'\'");
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
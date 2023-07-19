using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking");

        List<Activity> activities = new List<Activity>();

        // creating activities
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3));
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 25, 6));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 45, 96));

        Console.WriteLine("Logs:");
        // summaries for each different activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create lists to store activity names, counts, and durations
        List<string> _activityNames = new List<string>();
        List<int> _activityCounts = new List<int>();
        List<int> _activityDurations = new List<int>();

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();

        int userMenuInput = 0;
        List<string> menu = new List<string>
        {
            "Please select one of the following activities:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit"
        };

        while (userMenuInput != 4)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("> ");
            userMenuInput = int.Parse(Console.ReadLine());

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();

                    // gets the activity name
                    string breathingActivityName = breathingActivity.GetName();

                    // check if the activity name already exists in the list
                    if (_activityNames.Contains(breathingActivityName))
                    {
                        // if it exists, find the index and increase the count
                        int index = _activityNames.IndexOf(breathingActivityName);
                        _activityCounts[index]++;
                    }
                    else
                    {
                        // if it doesn't exist, add the name, count, and duration to each list
                        _activityNames.Add(breathingActivityName);
                        _activityCounts.Add(1);
                        _activityDurations.Add(breathingActivity.GetDuration());
                    }
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    string reflectingActivityName = reflectingActivity.GetName();
                    if (_activityNames.Contains(reflectingActivityName))
                    {
                        int index = _activityNames.IndexOf(reflectingActivityName);
                        _activityCounts[index]++;
                    }
                    else
                    {
                        _activityNames.Add(reflectingActivityName);
                        _activityCounts.Add(1);
                        _activityDurations.Add(reflectingActivity.GetDuration());
                    }
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    string listingActivityName = listingActivity.GetName();
                    if (_activityNames.Contains(listingActivityName))
                    {
                        int index = _activityNames.IndexOf(listingActivityName);
                        _activityCounts[index]++;
                    }
                    else
                    {
                        _activityNames.Add(listingActivityName);
                        _activityCounts.Add(1);
                        _activityDurations.Add(listingActivity.GetDuration());
                    }
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program!");

        // display the activity log for the session
        if (_activityNames.Count > 0)
        {
            Console.WriteLine("Here is your activity log for this session:");
            for (int i = 0; i < _activityNames.Count; i++)
            {
                Console.WriteLine($"{_activityNames[i]}: {_activityDurations[i]} seconds ({_activityCounts[i]} times)");
            }
        }
    }

}
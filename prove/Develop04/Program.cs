using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program");

        List<string> menu_options = new List<string> {
            "1. Start breathing activity",
            "2. Quit"
        };

        while (true)
        {
            foreach (string option in menu_options)
            {
                Console.WriteLine(option);
            }

            int userInput = Int32.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(5, 0, "Breathing", 3, 3, "Great job! You have completed the breathing activity.", 4, 4);
                breathingActivity.Start();
                breathingActivity.BreathAcivityStart();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

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
            foreach (string menuItem in menu){
                Console.WriteLine(menuItem);
            }
            Console.Write("> ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
            }
        }
    }
}
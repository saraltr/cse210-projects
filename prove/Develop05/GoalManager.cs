using System;
using System.Collections.Generic;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int userMenuInput = 0;
        List<string> menuOptions = new List<string>
        {
            "Menu Options:",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        while (userMenuInput !=6)
        {
            foreach(string option in menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("Select a choice from the menu:");
            Console.Write("> ");
            if (!int.TryParse(Console.ReadLine(), out userMenuInput))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }            
            switch (userMenuInput)
            {
                case 1:
                        List<string> goalType = new List<string>
                        {
                            "1. Simple Goal",
                            "2. Eternal Goal",
                            "3. Checklist Goal"
                        };

                        foreach(string goal in goalType)
                        {
                            Console.WriteLine(goal);
                        }
                        Console.Write("> ");
                        if (!int.TryParse(Console.ReadLine(), out int choice))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            break;
                        }

                        switch (choice)
                        {
                            case 1:
                                CreateGoal(out string goalName, out string description, out int points);
                                SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points, false);
                                _goals.Add(simpleGoal);
                            break;
                            // case 2:
                            //     CreateGoal(out string goalName, out string description, out int points);



                        }
                    break;
                case 2:
                    int index = 1;
                    foreach(Goal goal in _goals)
                    {
                        string goalsString = goal.GetDetailsString();
                        Console.WriteLine($"{index}. {goalsString}");
                        index++;
                    }
                break;
            }
        }
    }

    public void CreateGoal(out string goalName, out string description, out int points)
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();

        Console.Write("How many points is the goal worth? ");
        int.TryParse(Console.ReadLine(), out points);
    }
    

}
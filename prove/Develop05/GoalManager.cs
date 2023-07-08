using System.IO; 
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals; // list to store the user's goals
    private int _score; // user's score
    private int _level; 

    public GoalManager()
    {
        _goals = new List<Goal>(); // initialize the list of goals
        _score = 0; // initialize the score to 0
        _level = 1;
    }

    public void Start()
    {
        int userMenuInput = 0;

        while (userMenuInput != 6)
        {
            Console.WriteLine();
            // displays the current score
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine($"Current Level: {_level}");
            Console.WriteLine();
            // display the menu options
            DisplayMenu();
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
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using the Eternal Quest Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
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

        foreach(string option in menuOptions)
        {
            Console.WriteLine(option);
        }
    }

    private void CreateGoal()
    {
        // creates different goals from type selected by the user
        List<string> goalType = new List<string>
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };

        Console.WriteLine("Select the goal type:");
        foreach (string type in goalType)
        {
            Console.WriteLine(type);
        }
        Console.Write("> ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid input. Please try again!");
            return;
        }

        Goal goal;
        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(); // create a new SimpleGoal
                break;
            case 2:
                goal = new EternalGoal(); // create a new EternalGoal
                break;
            case 3:
                goal = new ChecklistGoal(); // create a new ChecklistGoal
                break;
            default:
                Console.WriteLine("Invalid goal type. Please select a valid option.");
                return;
        }

        goal.CreateGoal();
        _goals.Add(goal); // adds the goal to the list
        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}"); // display goal details
            index++;
        }
    }

    private void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Current Score: {_score}");

            foreach(Goal goal in _goals)
            {
                string goalString = goal.GetStringRepresentation();
                outputFile.WriteLine(goalString);

            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please enter a valid file name.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        bool isFirstLine = true;

        foreach (string line in lines)
        {
            // first line should be the score
            if (isFirstLine)
            {
                if (line.StartsWith("Current Score: "))
                {
                    string[] parts = line.Split(':');

                    int score = int.Parse(parts[1]);
                    _score = score;
                }
                isFirstLine = false;
            }
            else
            {
                string[] parts = line.Split(':', ',', '/');

                // gets the different parts of the string
                string goalType = parts[0].Trim();
                string goalName = parts[1].Trim();
                string goalDescription = parts[2].Trim();
                int goalPoints = int.Parse(parts[4].Trim());
                bool goalCompletion = bool.Parse(parts[6].Trim());

                Goal goal;

                switch (goalType)
                {
                    case "Simple Goal":
                        goal = new SimpleGoal(goalName, goalDescription, goalPoints, goalCompletion);
                        break;
                    case "Eternal Goal":
                        goal = new EternalGoal(goalName, goalDescription, goalPoints, goalCompletion);
                        break;
                    case "Checklist Goal":
                        int goalAmountCompleted = int.Parse(parts[8].Trim());
                        int goalTarget = int.Parse(parts[9].Trim());
                        int goalBonus = int.Parse(parts[11].Trim());
                        goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                        ((ChecklistGoal)goal).SetAmountCompleted(goalAmountCompleted);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type found in the file. Skipping the goal.");
                        continue;
                }

                // adds the loaded goals to the list
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    private void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoals();
        Console.Write("Enter the goal number: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber))
        {

            if (goalNumber > 0 && goalNumber <= _goals.Count)
            {
                Goal goal = _goals[goalNumber - 1]; // get the selected goal
                goal.RecordEvent(); // gecord the event for the goal
                if (goal.IsComplete())
                {
                    Console.WriteLine("Congratulations you have completed your goal!");
                }
                _score += goal.GetPoints(); // add the points earned for the goal to the score
                CheckLevelUp(); // check level status
                Console.WriteLine($"You earned {goal.GetPoints()} points");
            }
        }
    }

    private void CheckLevelUp()
    {
        int nextLevelScore = _level * 100; // calculate the score required for the next level

        if (_score >= nextLevelScore)
        {
            _level++; // increase the level
            Console.WriteLine();
            Console.WriteLine($"Congratulations! You reached Level {_level}!");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        int userInt = 0;
        Console.WriteLine("Hello Develop02 World!");

        try
        {
            while (userInt != 7)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write (get prompt)");
                Console.WriteLine("2. Write a new entry");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Save");
                Console.WriteLine("6. Delete");
                Console.WriteLine("7. Quit");
                Console.Write("What would you like to do? ");
                userInt = int.Parse(Console.ReadLine());

                if (userInt == 1)
                {
                    Entry newEntry = new Entry();
                    Prompt currentPrompt = new Prompt();
                    newEntry._question = currentPrompt.GetPrompt();
                    currentPrompt.DisplayPrompt();
                    newEntry._userEntry = Console.ReadLine();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    journal._entries.Add(newEntry);
                }

                if (userInt == 2)
                {
                    Entry newEntry = new Entry();
                    Console.Write("> ");
                    newEntry._userEntry = Console.ReadLine();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    journal._entries.Add(newEntry);
                }

                else if (userInt == 3)
                {
                    journal.DisplayEntries();
                }

                else if (userInt == 4)
                {
                    journal.LoadFile();
                }

                else if (userInt == 5)
                {
                    journal.SaveFile();
                }

                else if (userInt == 6)
                {
                    Console.WriteLine("Would you like to delete all of your enties? Or one scpescific? ");
                    Console.WriteLine("1. Delete All");
                    Console.WriteLine("2. Delete One");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        journal._entries.Clear();
                        Console.WriteLine("You have deleted all of your entries");
                    }
                    else if (choice == 2)
                    {
                        journal.DeleteEntry();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, try again.");
                    }
                }
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Please enter a number");
        }

    }
}
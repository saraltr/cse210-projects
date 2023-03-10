using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        int userInt = 0;
        Console.WriteLine("Hello Develop02 World!");

        while (userInt != 7)
        {
            try
            {
                // displays the menu
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write (get prompt)");
                Console.WriteLine("2. Write (without prompt)");
                Console.WriteLine("3. Display journal entries");
                Console.WriteLine("4. Load journal from file ");
                Console.WriteLine("5. Save journal to file");
                Console.WriteLine("6. Delete journal entry");
                Console.WriteLine("7. Exit");
                Console.Write("> ");
                userInt = Convert.ToInt32(Console.ReadLine());

                if (userInt == 1)
                {
                    // calls the Prompt class
                    Entry newEntry = new Entry();
                    Prompt currentPrompt = new Prompt();
                    newEntry._question = currentPrompt.GetPrompt();
                    currentPrompt.DisplayPrompt();
                    newEntry._userEntry = Console.ReadLine();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    // stores the user's entry into alist inside of the journal class
                    journal._entries.Add(newEntry);
                }
                else if (userInt == 2)
                {
                    // calls only the Entry class so the user can write without a random prompt
                    Entry newEntry = new Entry();
                    Console.Write("> ");
                    newEntry._userEntry = Console.ReadLine();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    journal._entries.Add(newEntry);
                }

                else if (userInt == 3)
                {
                    // displays every entry so far
                    journal.DisplayEntries();
                }

                else if (userInt == 4)
                {
                    // loads enties from external text file
                    journal.LoadFile();
                }

                else if (userInt == 5)
                {
                    // saves new file
                    journal.SaveFile();
                }

                else if (userInt == 6)
                {
                    // delete one of every entry
                    Console.WriteLine("Do you want to remove every one of your entries? Or one in the scpescic? ");
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
            catch (FormatException)
            {
                // handles wrong input from the user
                Console.WriteLine("Invalid input, please enter a number between 1 and 7.");
            }
            catch (Exception ex)
            {
                // handles everyother exception
                Console.WriteLine(ex.Message);
            }
        }

    }

}
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Reference reference = new Reference("John", 3, 16);
        List<string> text = new List<string>
        {
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
            "For God did not send his Son into the world to condemn the world, but to save the world through him."
        };

        Scripture scripture = new Scripture(reference, text);
        reference.DisplayReference();
        scripture.DisplayScripture();

        Console.WriteLine("\nPress enter to continue of type 'quit' to finish");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            Console.Clear();
            reference.DisplayReference();
            scripture.HideWords();
            scripture.DisplayScripture();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words have been hidden. The program will now end.");
                break;
            }

            Console.WriteLine("\nPress enter to continue of type 'quit' to finish:");
            input = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("John", 3, 16);
        List<string> text = new List<string>
        {
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
            "For God did not send his Son into the world to condemn the world, but to save the world through him."
        };

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("Scripture:");
        scripture.DisplayScripture();

        while (scripture.GetHiddenWordCount() < scripture.GetWordCount())
        {
            Console.WriteLine("\nPress enter to hide a random word:");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Scripture:");
            scripture.HideWords();
            scripture.DisplayScripture();
        }

        Console.WriteLine("\nAll words have been hidden. The program will now end.");
    }
}

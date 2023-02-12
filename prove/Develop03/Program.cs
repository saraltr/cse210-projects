using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Reference> references = new List<Reference>
    {
        new Reference("John", 3, 16),
        new Reference("Matthew", 5, 44),
        new Reference("Mark", 12, 31),
        new Reference("Alma", 7, 11, 12)
    };
        List<List<string>> texts = new List<List<string>>
    {
        new List<string>
        {
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
            "For God did not send his Son into the world to condemn the world, but to save the world through him."
        },
        new List<string>
        {
            "Therefore, I tell you, love your enemies and pray for those who persecute you,",
            "so that you may be children of your Father in heaven."
        },
        new List<string>
        {
            "Love the Lord your God with all your heart and with all your soul and with all your mind.",
            "This is the first and greatest commandment."
        },
        new List<string>
        {
            "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities"
        }
    };

        Random random = new Random();
        int index = random.Next(references.Count);
        Reference reference = references[index];
        List<string> text = texts[index];
        Scripture scripture = new Scripture(reference, text);

        reference.DisplayReference();
        scripture.DisplayScripture();
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            Console.Clear();
            reference.DisplayReference();
            scripture.HideWords();
            scripture.DisplayScripture();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Do you want a new scripture? (yes/no)");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    index = random.Next(references.Count);
                    reference = references[index];
                    text = texts[index];
                    scripture = new Scripture(reference, text);
                    Console.WriteLine("\nHere is your new scripture: ");
                    reference.DisplayReference();
                    scripture.DisplayScripture();
                }
                else
                {
                    Console.WriteLine("\nThe program will now end.");
                    break;
                }
            }

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // list of scripture references
        List<Reference> references = new List<Reference>();
        // List of the scripture text
        List<List<string>> texts = new List<List<string>>();

        try
        {
            using (StreamReader reader = new StreamReader("scriptures.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('%'); // the reference elements are divided by % on the text file
                    string[] referenceParts = parts[0].Split('|'); // the text is defined by the "|" symbol

                    // create a new reference object
                    Reference refs;
                    if (referenceParts.Length == 3) // if the reference has 3 parts, create a Reference object with 3 parameters
                    {
                        refs = new Reference(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]));
                    }
                    else if (referenceParts.Length == 4) // if the reference has 4 parts, create a Reference object with 4 parameters
                    {
                        refs = new Reference(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]), int.Parse(referenceParts[3]));
                    }
                    else
                    {
                        throw new Exception("Invalid reference format");
                        // if the reference has any other number of parts, throw an exception
                    }
                    references.Add(refs);
                    texts.Add(new List<string>(parts[1].Split('|')));
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file does not exist.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            return;
        }

        // Create a random number generator
        Random random = new Random();
        // Get a random index to choose a scripture
        int index = random.Next(references.Count);
        // Get the reference and text at the random index
        Reference reference = references[index];
        List<string> text = texts[index];
        // Create a new Scripture object using the reference and text
        Scripture scripture = new Scripture(reference, text);

        // Display the reference
        reference.DisplayReference();
        // Display the scripture
        scripture.DisplayScripture();
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
        string input = Console.ReadLine();

        // Continuously show the scripture until the user types 'quit'
        while (input != "quit")
        {
            // uses the various methods to display, and hide the scriptures
            Console.Clear();
            reference.DisplayReference();
            scripture.HideRandomWords();
            scripture.DisplayScripture();
            if (scripture.AllWordsHidden())
            {
                // when every word have been hiden, ask the user if he wants to display a new scripture
                Console.WriteLine("\nAll words have been hidden. Do you want a new scripture? (yes/no)");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    index = random.Next(references.Count); // get a new random scripture
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

            // when the user types "quit" the program ends
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
        }
    }
}
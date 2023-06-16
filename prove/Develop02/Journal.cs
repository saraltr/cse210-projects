using System;
using System.Collections.Generic;
public class Journal
{
    Entry entry = new Entry();
    public List<Entry> _entries = new List<Entry>();
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("-");
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._question = parts[1];
                newEntry._userEntry = parts[2];
                _entries.Add(newEntry);
            }
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("Sorry we could not find your file");
        }

    }

    public void SaveFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} - {entry._question} - {entry._userEntry}");
            }
        }
    }

    public void EntiresIn()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_entries[i]._date} - {_entries[i]._question} - {_entries[i]._userEntry}");
        }
    }

    public void DeleteEntry()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to delete.");
            return;
        }
        EntiresIn();
        Console.WriteLine("Select the entry you want to delete by entering the corresponding number:");
        int index;
        if (int.TryParse(Console.ReadLine(), out index))
        {
            index = index - 1;
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a valid number");
            return;
        }
        if (index < 0 || index >= _entries.Count)
        {
            Console.WriteLine("Invalid index. Please provide a valid index.");
            return;
        }
        _entries.RemoveAt(index);
        Console.WriteLine("The entry has been deleted.");
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine(); 
        int percent = int.Parse(grade);
        string sign = null;

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (percent % 10 >= 7)
        {
            if (letter == "B" || letter == "C" || letter == "D"){
                sign = "+";
            }
        }
        else if (percent % 10 < 3)
        {
            if (letter == "A" ||letter == "B" || letter == "C" || letter == "D"){
                sign = "-";
            }
        }
        else
        {
            sign = null;
        }

        Console.WriteLine($"Your grade is {letter}{sign}"); 

        if (percent >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep working hard and you'll improve!");
        }
    }
}
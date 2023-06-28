using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string assignment1 = assignment.GetSummary();
        Console.WriteLine(assignment1);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string assignment2 = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine($"{assignment2} | {homeworkList} ");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string assignment3 = writingAssignment.GetSummary();
        string title = writingAssignment.GetWritingInformation();
        Console.WriteLine($"{assignment3} | {title}");
    }
}
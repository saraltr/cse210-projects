using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        string info = assignment.GetSummary();
        // Console.WriteLine(info);

        MathAssignment math = new MathAssignment("Samuel Bennet", "Multiplication", "7.3", "8-19");
        string info1 = math.GetSummary();
        string courseinfo = math.GetHomeworkList();
        Console.WriteLine(info1);
        Console.WriteLine(courseinfo);

        WrittingAssignment writing = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string info2 = writing.GetSummary();
        string courseinfo1 = writing.GetWritingInformation();
        Console.WriteLine(info2);
        Console.WriteLine(courseinfo1);

    }
}
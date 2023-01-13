using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
    }
}
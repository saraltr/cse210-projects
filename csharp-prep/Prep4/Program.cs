using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        do
        {
            Console.Write("Enter a number: ");
            string unserResponse = Console.ReadLine();
            userNumber = int.Parse(unserResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        // Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum, or largest, number in the list.
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        // Sort the numbers in the list and display the new, sorted list.
        numbers.Sort();
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }

    }
}
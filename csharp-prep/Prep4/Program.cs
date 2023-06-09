using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float userNumber = -1;

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

        // compute the sum of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        // compute the average of the numbers in the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // find the largest number in the list.
        float largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {largest}");
        float smallestPositive = float.MaxValue;
        foreach (float number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
        numbers.Sort();
        foreach (float x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}
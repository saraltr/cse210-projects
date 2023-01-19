using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);


        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number (as an integer): ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");

        }

    }

}
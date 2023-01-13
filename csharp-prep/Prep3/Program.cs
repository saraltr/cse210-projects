using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userNumber = 0;
        int guessCount = 1;

        bool game = true;

        while (game)
        {
            do
            {
                Console.Write("What is the magic number? ");
                userNumber = int.Parse(Console.ReadLine());

                if (magicNumber > userNumber)
                {
                    Console.WriteLine("Higher");
                    guessCount += 1;
                }
                else if (magicNumber < userNumber)
                {
                    Console.WriteLine("Lower");
                    guessCount += 1;

                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} times.");
                    Console.WriteLine("Would you like to play again? Enter yes or no: ");
                    string option = Console.ReadLine();

                    if (option == "yes")
                    {
                        game = true;
                    }
                }

            } while (userNumber != magicNumber);
        }
    }
}
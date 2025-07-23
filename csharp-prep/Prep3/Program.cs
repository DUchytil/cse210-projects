using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int guess = 0;
        int guesses = 0;
        Console.Write("What is the magic number? ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine();


        bool guessed = false;

        while (!guessed)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine();
            guesses++;
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                guessed = true;
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine($"You guessed {guesses} times.");



    }
}
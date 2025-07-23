using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        DisplayWelcome();
        DisplayResult(SquareNumber(PromptUserNumber()), PromptUserName());
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(int squaredNumber, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first name: ");
        String firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        String lastName = Console.ReadLine();
        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");
    }
}
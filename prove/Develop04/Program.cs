using System;

class Program
{

    static void Main(string[] args)
    {
        bool _finished = false;
        string _userChoice;


        while (!_finished)
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice form the menu: ");
            _userChoice = Console.ReadLine();

            switch (_userChoice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    _finished = true;
                    break;
                default:
                    Console.WriteLine("Error: invalid entry.");
                    break;
            }

        }

    }
}
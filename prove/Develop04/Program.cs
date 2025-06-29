using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

class Program
{

    static void Main(string[] args)
    {
        bool _finished = false;
        string _userChoice;


        while (!_finished)
        {
            Console.Clear();
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
                    // ReflectionActivity reflectionActivity = new ReflectionActivity("Reflecting Activity", "This activity will help you relax providing you with meaningful prompts to get you thinking. Get ready, and clear your mind!");
                    // RunActivity(reflectionActivity);
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflecting Activity", "This activity will help you relax providing you with meaningful prompts to get you thinking. Get ready, and clear your mind!");
                    RunActivity(reflectionActivity);
                    break;
                case "3":
                    // ReflectionActivity reflectionActivity = new ReflectionActivity("Reflecting Activity", "This activity will help you relax providing you with meaningful prompts to get you thinking. Get ready, and clear your mind!");
                    // RunActivity(reflectionActivity);
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

    private static void RunActivity(BaseActivity activity)
    {
        Console.Clear();
        activity.DisplayGreeting();
        activity.DisplayDescription();
        activity.SetDuration();
        activity.ExecuteActivity();
    }
}
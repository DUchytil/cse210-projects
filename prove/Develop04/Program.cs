/*
ABOVE AND BEYOND: I went above and beyond by implementing a system to keep track of when a string or prompt has already been used. 
This makes it so that only unique prompts will be displayed every time the program is run. No duplicates. I did this through the FlaggedString class.
*/

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
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    RunActivity(breathingActivity);
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflecting Activity", "This activity will help you relax providing you with meaningful prompts to get you thinking. Get ready, and clear your mind!");
                    RunActivity(reflectionActivity);
                    break;
                case "3":
                    ListeningActivity listeningActivity = new ListeningActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    RunActivity(listeningActivity);
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
        activity.DisplayEnding();
    }
}
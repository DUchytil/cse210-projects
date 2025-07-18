using System;

class Program
{
    static void Main(string[] args)
    {

        List<BaseGoal> goalList = new List<BaseGoal>();

        int points = 0;

        bool isFinished = false;
        Menu mainMenu = new Menu();
        mainMenu.AddMenuItem("1. Create New Goal");
        mainMenu.AddMenuItem("2. List Goals");
        mainMenu.AddMenuItem("3. Save Goals");
        mainMenu.AddMenuItem("4. Load Goals");
        mainMenu.AddMenuItem("5. Record Goals");
        mainMenu.AddMenuItem("6. Quit");
        Menu goalMenu = new Menu();
        goalMenu.AddMenuItem("1. Simple Goal");
        goalMenu.AddMenuItem("2. Eternal Goal");
        goalMenu.AddMenuItem("3. Checklist Goal");
        while (!isFinished)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {points} points. ");
            Console.WriteLine();
            mainMenu.DisplayMenu("Menu Options:");
            int choice = mainMenu.GetUserChoice("Select a chocie from the menu:");
            switch (choice)
            {
                case 1:
                    goalMenu.DisplayMenu("The types of goals are:");
                    switch (goalMenu.GetUserChoice("Which type of goal would you like to create?"))
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal();
                            goalList.Add(simpleGoal);
                            break;
                        case 2:
                        //IMPLEMENT THIS NEXT
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid goal type.");
                            break;
                    }
                    break;
                case 2:
                    // TODO: Implement List Goals logic
                    break;
                case 3:
                    // TODO: Implement Save Goals logic
                    break;
                case 4:
                    // TODO: Implement Load Goals logic
                    break;
                case 5:
                    // TODO: Implement Record Goals logic
                    break;
                case 6:
                    isFinished = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid menu option.");
                    break;
            }
        }
    }
}
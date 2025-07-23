//ABOVE AND BEYOND: I added code to automatically save goals to a file when the program exits, and to automatically load goals from a file when the program starts.
//To make this work better, I also added a 7th option to erase all goals and points.
//You can still load and save from costum files.
//I also added a dedicated filehandler class to manage file operations, which makes the code cleaner and more modular.
using System.IO;
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
        mainMenu.AddMenuItem("5. Record Event");
        mainMenu.AddMenuItem("6. Quit");
        mainMenu.AddMenuItem("7. Clear All Goals");
        Menu goalMenu = new Menu();
        goalMenu.AddMenuItem("1. Simple Goal");
        goalMenu.AddMenuItem("2. Eternal Goal");
        goalMenu.AddMenuItem("3. Checklist Goal");

        // Automatically load info from fileSave.txt if it exists
        string autoSaveFile = "fileSave.txt";
        if (File.Exists(autoSaveFile))
        {
            FileHandler fileHandler = new FileHandler(autoSaveFile);
            string[] lines = fileHandler.ReadStringsFromFile();
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(true);
                        simpleGoal.LoadInfo(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        goalList.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(true);
                        eternalGoal.LoadInfo(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        goalList.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(true);
                        checklistGoal.LoadInfo(parts[1], parts[2], int.Parse(parts[3]), false, int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        goalList.Add(checklistGoal);
                        break;
                    default:
                        if (parts.Length == 1)
                        {
                            try
                            {
                                points = int.Parse(parts[0]);
                            }
                            catch (FormatException)
                            {
                                throw new FormatException($"Invalid points line: '{parts[0]}' is not an integer.");
                            }
                        }
                        else
                        {
                            throw new FormatException($"Invalid line format: '{line}'");
                        }
                        break;
                }
            }
        }

        while (!isFinished)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {points} points. ");
            Console.WriteLine();
            mainMenu.DisplayMenu("Menu Options:");
            int choice = mainMenu.GetUserChoice("Select a choice from the menu:");
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
                            EternalGoal eternalGoal = new EternalGoal();
                            goalList.Add(eternalGoal);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            goalList.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid goal type.");
                            break;
                    }
                    break;
                case 2:
                    DisplayGoalsAndInfo(goalList);
                    break;
                case 3:
                    Console.Write("What is the filename for your goal file? ");
                    string filenameToWriteTo = Console.ReadLine();
                    FileHandler fileHandler1 = new FileHandler(filenameToWriteTo);
                    fileHandler1.SaveStringToFile($"{points}"); // Save points to the file
                    foreach (BaseGoal goal in goalList)
                    {
                        fileHandler1.SaveStringToFile(goal.PackageInfoForFile()); // Save each goal's info
                    }
                    break;
                case 4:
                    Console.Write("What is the filename for your goal file? ");
                    string filenameToReadFrom = Console.ReadLine();
                    FileHandler fileHandler = new FileHandler(filenameToReadFrom);
                    string[] lines = fileHandler.ReadStringsFromFile();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        switch (parts[0])
                        {
                            case "SimpleGoal":
                                SimpleGoal simpleGoal = new SimpleGoal(true);
                                simpleGoal.LoadInfo(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                                goalList.Add(simpleGoal);
                                break;
                            case "EternalGoal":
                                EternalGoal eternalGoal = new EternalGoal(true);
                                eternalGoal.LoadInfo(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                                goalList.Add(eternalGoal);
                                break;
                            case "ChecklistGoal":
                                ChecklistGoal checklistGoal = new ChecklistGoal(true);
                                checklistGoal.LoadInfo(parts[1], parts[2], int.Parse(parts[3]), false, int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                                goalList.Add(checklistGoal);
                                break;
                            default:
                                if (parts.Length == 1)
                                {
                                    try
                                    {
                                        points = int.Parse(parts[0]);
                                    }
                                    catch (FormatException)
                                    {
                                        throw new FormatException($"Invalid points line: '{parts[0]}' is not an integer.");
                                    }
                                }
                                else
                                {
                                    throw new FormatException($"Invalid line format: '{line}'");
                                }
                                break;
                        }
                    }
                    break;
                case 5:
                    // Print out all goals here
                    ListGoals(goalList, "The goals are:");
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    switch (goalList[goalIndex].GetGoalType())
                    {
                        case "SimpleGoal":
                            if (goalList[goalIndex].IsCompleted())
                            {
                                Console.WriteLine("This goal has already been completed.");
                                break;
                            }
                            goalList[goalIndex].ProcessCompletion();
                            points += goalList[goalIndex].GetGoalPoints();
                            break;
                        case "EternalGoal":
                            if (goalList[goalIndex].IsCompleted())
                            {
                                Console.WriteLine("This goal has already been completed.");
                                break;
                            }
                            goalList[goalIndex].ProcessCompletion();
                            points += goalList[goalIndex].GetGoalPoints();
                            break;
                        case "ChecklistGoal":
                            if (goalList[goalIndex].IsCompleted())
                            {
                                Console.WriteLine("This goal has already been completed.");
                                break;
                            }
                            goalList[goalIndex].ProcessCompletion();
                            points += goalList[goalIndex].GetGoalPoints();
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                    break;
                case 6:
                    // Automatically save goals to fileSave.txt and overwrite if it exists
                    // Overwrite the file by not using append mode
                    using (StreamWriter writer = new StreamWriter(autoSaveFile, false))
                    {
                        writer.WriteLine(points); // Save points first
                        foreach (BaseGoal goal in goalList)
                        {
                            writer.WriteLine(goal.PackageInfoForFile()); // Save each goal's info
                        }
                    }
                    isFinished = true;
                    break;
                case 7:
                    goalList.Clear();
                    points = 0;
                    Console.WriteLine("All goals and points have been cleared.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid menu option.");
                    break;
            }
        }
    }

    static void DisplayGoalsAndInfo(List<BaseGoal> goals)
    {
        Console.WriteLine("The Goals Are:");
        int count = 1;
        foreach (BaseGoal goal in goals)
        {
            Console.WriteLine($"  {count}. [{goal.GetCompletionIndicator()}] {goal.GetGoalInfoToPrint()}");
            count++;
        }
    }

    static void ListGoals(List<BaseGoal> goals, string listHeader)
    {
        Console.WriteLine(listHeader);
        int count = 1;
        foreach (BaseGoal goal in goals)
        {
            Console.WriteLine($"  {count}. {goal.GetGoalName()}");
            count++;
        }
    }
}
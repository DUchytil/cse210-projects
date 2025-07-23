/*
ABOVE AND BEYOND: I added functionality count the number of words in the entry and prompt the user to write at least 20 words to encourage more detailed journaling.
However, the user can type "no" to skip this requirement and instead input an entry of any length.
*/

class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        Menu mainMenu = new Menu();
        Journal journal = new Journal();
        mainMenu.AddMenuItem("1. Write");
        mainMenu.AddMenuItem("2. Display");
        mainMenu.AddMenuItem("3. Load");
        mainMenu.AddMenuItem("4. Save");
        mainMenu.AddMenuItem("5. Quit");

        Console.Clear();

        Console.WriteLine("Welcome to the Journal Program!");

        while (!quit)
        {
            mainMenu.DisplayMenu("Please select one of the following choices:");
            int choice = mainMenu.GetUserChoice("What would you like to do? ");

            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("What is the filename?");
                    string readFileName = Console.ReadLine(); // You can change this to your desired file name
                    journal.LoadEntries(readFileName);
                    break;
                case 4:

                    Console.WriteLine("What is the filename?");
                    string writeFileName = Console.ReadLine(); // You can change this to your desired file name
                    journal.SaveEntries(writeFileName);
                    break;
                case 5:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
}
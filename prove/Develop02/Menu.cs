class Menu
{
    List<String> _menuItems = new List<String>();

    public void AddMenuItem(string item)
    {
        _menuItems.Add(item);
    }

    public void DisplayMenu(string menuPrompt)
    {
        Console.WriteLine(menuPrompt);
        foreach (var item in _menuItems)
        {
            Console.WriteLine($"  {item}");
        }
    }
    
    public int GetUserChoice(string prompt = "Please enter your choice:")
    {
        Console.Write($"{prompt} ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        return choice;
    }
}


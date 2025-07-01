class ListeningActivity : BaseActivity
{
    private List<FlaggedString> _availablePrompts = new List<FlaggedString>
    {
        new FlaggedString("Who are people that you appreciate? "),
        new FlaggedString("What are personal strengths of yours? "),
        new FlaggedString("Who are people that you have helped this week? "),
        new FlaggedString("When have you felt the Holy Ghost this month? "),
        new FlaggedString("Who are some of your personal heroes? ")
    };
    private List<string> _userEntries = new List<string>();

    public ListeningActivity(string name, string description) : base(name, description)
    {

    }

    public override void ExecuteActivity()
    {

        Console.Clear();
        Console.WriteLine("Get ready... ");
        base.DisplaySpinner(4);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {base.GetRandomUnusedStringFromFlaggedStringList(_availablePrompts)} ---");
        Console.Write("You may begin in: ");
        base.RunCountDown(5);
        Console.WriteLine();
        base.StartTime(base.GetDuration());

        while (!base.HasTimerExpired())
        {
            Console.Write(">");
            _userEntries.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_userEntries.Count()} items.");
    }
}

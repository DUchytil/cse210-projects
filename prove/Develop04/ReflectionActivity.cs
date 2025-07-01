class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _availablePrompts = new List<FlaggedString>
    {
        new FlaggedString("Think of a time when you stood up for someone else."),
        new FlaggedString("Think of a time when you did something really difficult."),
        new FlaggedString("Think of a time when you helped someone in need."),
        new FlaggedString("Think of a time when you did something truly selfless.")
    };
    private List<FlaggedString> _availableReflectionQuestions = new List<FlaggedString>
    {
        new FlaggedString("Why was this experience meaningful to you? "),
        new FlaggedString("Have you ever done anything like this before? "),
        new FlaggedString("How did you get started? "),
        new FlaggedString("How did you feel when it was complete? "),
        new FlaggedString("What made this time different than other times when you were not as successful? "),
        new FlaggedString("What is your favorite thing about this experience? "),
        new FlaggedString("What could you learn from this experience that applies to other situations? "),
        new FlaggedString("What did you learn about yourself through this experience? "),
        new FlaggedString("How can you keep this experience in mind in the future? ")
    };
    public ReflectionActivity(string name, string description) : base(name, description)
    {
        
    }

    public override void ExecuteActivity()
    {
        Random rand = new Random();
        Console.Clear();
        Console.WriteLine("Get ready... ");
        base.DisplaySpinner(4);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {base.GetRandomUnusedStringFromFlaggedStringList(_availablePrompts)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.RunCountDown(5);
        Console.Clear();

        // Starting countdown
        base.StartTime(base.GetDuration());

        // Will loop until timer has expired
        while (!base.HasTimerExpired())
        {
            Console.Write($"> {base.GetRandomUnusedStringFromFlaggedStringList(_availableReflectionQuestions)}");
            base.DisplaySpinner(15);
            Console.WriteLine();
        }
        ;
    }

    private void SetPromptsAndQuestions()
    {

    }
    private void ResetPromptsUsage() // Likely not going to be used
    {
        
    }
}
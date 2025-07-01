abstract class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _currentTime;
    private DateTime _endTime;


    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {_name} activity.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine("");
        Console.WriteLine(_description);
    }

    public void DisplayEnding()
    {
        Console.WriteLine($"\nWell Done!!");
        DisplaySpinner(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        DisplaySpinner(5);
    }

    public void RunCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b");
            seconds--;
        }
        Console.Write(" ");
        Console.Write("\b");

    }

    public void DisplaySpinner(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;

        string animationString = @"|/-\";
        int index = 0;
        while (DateTime.Now < endTime)
        {
            if (index > animationString.Length - 1)
                index = 0;
            Console.Write(animationString[index]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            index++;
        }
        Console.Write(" ");
        Console.Write("\b");
    }

    public void StartTime(int duration)
    {
        _currentTime = DateTime.Now;
        _endTime = _currentTime.AddSeconds(duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void SetDuration()
    {
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        bool isNumber = int.TryParse(Console.ReadLine(), out _duration);


        if (!isNumber)
        {
            Console.WriteLine("Error, invalid entry.");
            return;
        }

        Console.WriteLine(_duration);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void GetPromptString()
    {

    }

    public string GetRandomUnusedStringFromFlaggedStringList(List<FlaggedString> flaggedStringList)
    {
        Random rand = new Random();
        bool isAlreadyUsed = true;
        FlaggedString unusedString = new FlaggedString("Error, no string found.");
        while (isAlreadyUsed)
        {
            FlaggedString promptToDisplay = flaggedStringList[rand.Next(0, flaggedStringList.Count() - 1)];
            unusedString = promptToDisplay;
            if (promptToDisplay.GetUsedStatus() == false)
            {
                isAlreadyUsed = false;
            }
        }
        return unusedString.GetString();
    }

    public void ResetStringStatusFromFlaggedStringList(List<FlaggedString> flaggedStringList)
    {
        foreach (FlaggedString flaggedString in flaggedStringList)
        {
            flaggedString.ResetStringStatus();
        }
    }
    public abstract void ExecuteActivity();

       
}
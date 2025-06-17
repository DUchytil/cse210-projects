using System.Runtime.CompilerServices;

abstract class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;

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

    }

    public void RunCountDown(string message, int seconds)
    {

    }

    public void DisplaySpinner(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;

        string animationString = @"|/-\";

        while (DateTime.Now < endTime) //Countdown code 
        {
            Console.Write(animationString[0..1]); //Puts down first five characters
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animationString[1..2]); //put down last five characeters
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animationString[2..3]); //put down last five characeters
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animationString[3..4]); //put down last five characeters
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }

    public void StartTime()
    {

    }

    public void HasTimerExpired()
    {

    }

    public void GetDuration()
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

    public void GetPromptString()
    {

    }

    public abstract void RunActivity();
    
}
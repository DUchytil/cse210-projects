class BreathingActivity : BaseActivity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public override void ExecuteActivity()
    {
        Random random = new Random();

        // Starting timer
        base.StartTime(base.GetDuration());
        Console.Clear();
        Console.WriteLine("Get ready... ");
        base.DisplaySpinner(random.Next(2, 7));
        while (!base.HasTimerExpired())
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in..."); // Should be displayed for 2 seconds
            base.RunCountDown(random.Next(2, 7));
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            base.RunCountDown(random.Next(2, 7));
        }
        Console.WriteLine("");
    }
}

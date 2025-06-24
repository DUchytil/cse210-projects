class ReflectionActivity : BaseActivity
{
    private List<string> _availablePrompts = new List<string>();
    private List<string> _availableReflectionQuestions = new List<string>();

    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public override void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready... ");
        base.DisplaySpinner(5);
        Console.WriteLine("Consider the following prompt: ");
    }

    private void SetPromptsAndQuestions()
    {

    }
    private void ResetPromptsUsage() // Likely not going to be used
    {
        
    }
}
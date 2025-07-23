

class JournalEntry
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me smile or laugh today?",
        "What challenge did I overcome today?",
        "What is something new I learned today?",
        "Who did I help or serve today?",
        "What am I grateful for right now?",
        "What is one thing I wish I understood better?",
        "What surprised me today?",
        "What is a goal I am working towards?",
        "What is something I want to remember from today?",
        "How did I show kindness today?",
        "What is something I am looking forward to?",
        "What was the most peaceful moment of my day?",
        "What is a lesson I learned from a mistake today?",
        "Who inspired me today and why?",
        "What is something I did outside today?",
        "What is a small victory I had today?",
        "What is something I want to improve tomorrow?",
        "What is a memory from today I want to share with someone?"
    };
    private string _prompt;
    private string _entryText;
    private DateTime _entryDateAndTime;

    public JournalEntry() // Default constructor to create a new entry
    {
        GenerateAndDisplayPrompt();
        GetEntryInput();
    }

    public JournalEntry(string entryDateAndTime, string prompt, string entry) // Constructor to create an entry with specific values
    {
        _entryText = entry;
        _entryDateAndTime = DateTime.Parse(entryDateAndTime);
        _prompt = prompt;
    }


    public void GetEntryInput(bool minimumWordCount = true)
    {
        Console.Write("> ");
        _entryText = Console.ReadLine();
        _entryDateAndTime = DateTime.Now;

        int wordCount = _entryText.Split(" ").Length; // Count the number of words in the entry
        if (_entryText == "no" || _entryText == "No")
        {
            minimumWordCount = false;
            Console.WriteLine("Okay, no worries! You can always come back later to write more.");
            GetEntryInput(false); // Recursively call to allow for no minimum word count
        }
        if (wordCount < 20 && minimumWordCount)
        {
            Console.WriteLine("Come on, you can do better than that! Journaling about your day is a great way to reflect and grow. See if you can write just a little more (at least 20 words).");
            Console.WriteLine("If you'd prefer to override this, just type 'no' and press enter.");
            GetEntryInput(); // Recursively call until valid input is provided
        }
    }

    public void DisplayEntry() // include parameter of type 'JournalEntry'
    {
        Console.WriteLine($"{_entryDateAndTime.ToShortDateString()} - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    private void GenerateAndDisplayPrompt()
    {
        _prompt = _prompts[new Random().Next(_prompts.Count)]; // Randomly select a prompt from the list
        Console.WriteLine(_prompt);
    }

    public string PackageForSaving()
    {
        return $"{_entryDateAndTime.ToShortDateString()}|{_prompt}|{_entryText}";
    }

}
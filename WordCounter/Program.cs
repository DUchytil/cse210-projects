class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Bonjour tout le monde.");
        WordCounter wordCounter = new WordCounter("This is a test sentence to allow testing my new class");
        wordCounter.DisplayWords();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference("John", 3, 5);
        Scripture scripture = new Scripture(reference, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        scripture.displayScripture();
    }

}


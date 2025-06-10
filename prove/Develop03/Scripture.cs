using System;
class Scripture
{
    private string _reference;
    private Word[] _words;


    public Scripture(string scriptureText, string scriptureReference) //Professor had scirpture-related data passed in through here (probably the way to go)
    {

    }

    public void displayScripture()
    {
        bool firstWord = true;
        foreach (Word word in _words)
        {
            if (firstWord)
            {
                Console.Write($"{word.getWord()}");
                firstWord = false;
            }
            else
            {
                Console.Write($" {word.getWord()}");
            }
        }
    }

    public void hideRandomWords()
    {
        Random rn = new Random();
        int randomNumber1 = rn.Next();//Should be bounded
        int randomNumber2 = rn.Next();
        int randomNumber3 = rn.Next();
    }



}


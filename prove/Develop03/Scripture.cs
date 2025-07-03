class Scripture
{
    // private string _reference;
    private List<Word> _wordObjectList = new List<Word>();
    private string _wordsAsString;
    private string[] _stringList;


    public Scripture(Reference scriptureReference, string scriptureText) //Professor had scirpture-related data passed in through here (probably the way to go)
    {
        _wordsAsString = scriptureText;
        _stringList = _wordsAsString.Split(" ");

        foreach (string word in _stringList)
        {

            Word newWord = new Word(word);
            _wordObjectList.Add(newWord);
        }
        // foreach (string word in _stringList)
        // {
        //     Console.WriteLine(word);    
        // }
    }

    public void displayScripture()
    {
        bool firstWord = true;
        foreach (Word word in _wordObjectList)
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


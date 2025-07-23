class Scripture
{
    // private string _reference;
    private List<Word> _wordObjectList = new List<Word>();
    private string _wordsAsString;
    private string[] _stringList;
    private Reference _scriptureReference;
    private bool _allWordsHidden = false;


    public Scripture(Reference scriptureReference, string scriptureText) //Professor had scirpture-related data passed in through here (probably the way to go)
    {
        _wordsAsString = scriptureText;
        _stringList = _wordsAsString.Split(" ");
        _scriptureReference = scriptureReference;

        foreach (string word in _stringList)
        {
            Word newWord = new Word(word);
            _wordObjectList.Add(newWord);
        }
    }

    public void DisplayScripture()
    {
        //Display the reference here using the Reference class
        _scriptureReference.DisplayReference();
        bool firstWord = true;
        foreach (Word word in _wordObjectList)
        {
            if (firstWord)
            {
                Console.Write($"{word.GetWord()}");
                firstWord = false;
            }
            else
            {
                Console.Write($" {word.GetWord()}");
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _allWordsHidden;
    }


    public void HideRandomWords()
    {
        // Console.WriteLine("Flag");
        Random rn = new Random();

        int numberOfWordsToHide = _wordObjectList.Count;

        foreach (Word word in _wordObjectList)
        {
            if (word.IsWordHidden())
            {
                numberOfWordsToHide--;
            }
        }

        if (numberOfWordsToHide == 0)
        {
            _allWordsHidden = true;
        }
        for (int i = 0; i < 3; i++)
        {
            // Console.WriteLine($"Number of words to hide: {numberOfWordsToHide}");
            if (numberOfWordsToHide <= 3)
            {
                foreach (Word word in _wordObjectList)
                {
                    word.SetStatusAsHidden();
                    numberOfWordsToHide = 0;
                }
                break;
            }
            int randomIndex = rn.Next(_wordObjectList.Count);
            if (!_wordObjectList[randomIndex].IsWordHidden())
            {
                _wordObjectList[randomIndex].SetStatusAsHidden();
            }
            else
            {
                i--;
            }
        }


    }



}


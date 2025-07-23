class Reference
{
    bool _moreThanOneVerse = false;
    string _book = "";
    int _chapter = 0;
    int _startVerse = 0;
    int _endVerse = 0;

    public Reference(string book, int chapter, int verse)
    {
        _chapter = chapter;
        _book = book;
        _startVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _moreThanOneVerse = true;
    }

    public string GetReference()
    {
        if (_moreThanOneVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        return $"{_book} {_chapter}:{_startVerse}";
    }

    public void DisplayReference()
    {
        if (_moreThanOneVerse)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
            return;
        }

        Console.Write($"{_book} {_chapter}:{_startVerse} ");
    }
}
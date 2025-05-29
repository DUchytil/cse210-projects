class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }

    public string getWord()
    {
        return _word;
    }

    public string getUnderscoredWord()
    {
        string underscoredWord = "";

        foreach (char character in _word)
        {
            underscoredWord += "_";
        }

        return underscoredWord;
    }

}
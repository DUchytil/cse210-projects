
class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string getWord()
    {
        return _word;
    }

    public bool getWordStatus()
    {
        return _isHidden;
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

class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetWord()
    {

        if (_isHidden)
        {
            string underscoredWord = "";
            foreach (char character in _word)
            {
                underscoredWord += "_";
            }
            return underscoredWord;
        }

        return _word;
    }

    public void ResetWordStatus()
    {
        _isHidden = false;
    }

    public void SetStatusAsHidden()
    {
        _isHidden = true;
    }

    public bool IsWordHidden()
    {
        return _isHidden;
    }

}
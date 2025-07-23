
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

    public void resetWordStatus()
    {
        _isHidden = false;
    }

    public void setStatusAsHidden()
    {
        _isHidden = true;
    }

}